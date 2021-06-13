using ChapeauxLogic;
using ChapeauxModel;
using ChapeauxUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class TableDetails : Form
    {
        private User loggedUser;
        private Table currentTable;
        private Timer tmr;
        private Order order;

        private bool tableHasOrder; // Used to check if table has any active orders
        private bool tableHasItems; // Used to check if active order has any items

        List<OrderItem> itemsThatHaveNotBeenServed; // Used to select the latest order that have not been served

        public TableDetails(User user, int tableNumber)
        {
            loggedUser = user;
            itemsThatHaveNotBeenServed = new List<OrderItem>();

            Table_Service table_service = new Table_Service();
            currentTable = table_service.getTable(tableNumber);

            InitializeComponent();
        }

        private void TableDetails_Load(object sender, EventArgs e)
        {
            lblUserFullName.Text = $"{loggedUser.FirstName} {loggedUser.LastName}";
            btnCheckout.Enabled = false;

            // Creating Timer object
            tmr = new Timer();
            tmr.Interval = 1000;
            itemsThatHaveNotBeenServed = null;
            tmr.Tick += new EventHandler(Timer_Tick);

            Reload();
        }

        #region Timer
        private void StartTimer()
        {
            if (order != null)
            {
                itemsThatHaveNotBeenServed = new List<OrderItem>();

                // Getting all the orderItems that have not been served yet
                foreach (OrderItem orderItems in order.orderItems)
                {
                    if (orderItems.State != State.served)
                    {
                        itemsThatHaveNotBeenServed.Add(orderItems);
                    }
                }

                // Only create timer if there is at least one ordertime with loading or ready
                if (itemsThatHaveNotBeenServed.Count != 0)
                {
                    //tmr.Tick += new EventHandler(Timer_Tick);
                    tmr.Enabled = true;
                    tmr.Start();
                }
                else
                {
                    tmr.Enabled = false;
                    LblTimer.Text = "";
                }
            }
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Order the items by orderItemID, so we can select the latest one
            List<OrderItem> orderedListByID = itemsThatHaveNotBeenServed.OrderBy(o => o.OrderItemID).ToList();
            TimeSpan diff = DateTime.Now - orderedListByID[0].OrderDateTime;

            //Update label every second
            LblTimer.Text = $"{diff:hh\\:mm\\:ss}";
        }

        #endregion

        #region Methods to update Table Details 
        public void Reload()
        {
            FillUpOrderDetails();
            UpdateTableState();
            UpdateTableDetailsFunctionality();
            StartTimer();
        }

        private void FillUpOrderDetails()
        {
            try
            {
                Order_Service orderService = new Order_Service();
                order = orderService.GetByTableID(currentTable.TableID);

                if (order == null)
                {
                    return;
                }

                listViewOrderOverview.Items.Clear();

                foreach (OrderItem orderItem in order.orderItems)
                {
                    ListViewItem li = new ListViewItem(orderItem.OrderItemID.ToString());
                    li.SubItems.Add(orderItem.Name);
                    li.SubItems.Add(orderItem.Count.ToString());
                    li.SubItems.Add(orderItem.Price.ToString("0.00"));
                    li.SubItems.Add(orderItem.State.ToString());
                    li.Tag = orderItem;
                    listViewOrderOverview.Items.Add(li);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void UpdateTableState()
        {
            Table_Service table_service = new Table_Service();
            currentTable = table_service.getTable(currentTable.TableID);

            lblTableStatus.Text = $"Table {currentTable.TableID}: {currentTable.Status}";
        }

        private void UpdateTableDetailsFunctionality()
        {
            if (currentTable.Status == Status.Occupied)
            {
                // Checking if there is an order
                Order_Service order_service = new Order_Service();
                bool thereIsAnOrder = order_service.tableContainsOrder(currentTable.TableID);

                if (thereIsAnOrder)
                {
                    tableHasOrder = true;
                    bool itemsServed = true;
                    
                    if (order.orderItems.Count != 0)
                    {
                        tableHasItems = true;

                        // There are orderItems, so we cannot free up table
                        btnOccupyTable.BackgroundImage = ChapeauxUI.Properties.Resources.btnFreeTable_hover;
                        btnOccupyTable.Enabled = false;

                        // Checking if every Item is served
                        foreach (OrderItem orderItem in order.orderItems)
                        {
                            if (orderItem.State != State.served)
                            {
                                itemsServed = false;
                            }
                        }

                        // If Items are served then enable checkout button
                        if (itemsServed == false)
                        {
                            btnCheckout.BackgroundImage = ChapeauxUI.Properties.Resources.btnCheckout_hover;
                            btnCheckout.Enabled = false;
                        }
                        else
                        {
                            btnCheckout.BackgroundImage = ChapeauxUI.Properties.Resources.btnCheckout_enabled;
                            btnCheckout.Enabled = true;
                        }
                    }
                    else
                    {
                        // Table has an order without item, this means we can free up the table and add a new order
                        btnCheckout.BackgroundImage = ChapeauxUI.Properties.Resources.btnCheckout_hover;
                        btnCheckout.Enabled = false;

                        btnAddNewOrder.BackgroundImage = ChapeauxUI.Properties.Resources.btnAddNewOrder_enabled;

                        btnOccupyTable.BackgroundImage = ChapeauxUI.Properties.Resources.btnFreeTable_enabled;
                        btnOccupyTable.Enabled = true;
                        
                        tableHasItems = false;
                    }
                }
                else
                {
                    // Table has no order, we can Free up table, add new order but not checkout
                    tableHasOrder = false;
                    
                    btnOccupyTable.BackgroundImage = ChapeauxUI.Properties.Resources.btnFreeTable_enabled;
                    btnAddNewOrder.BackgroundImage = ChapeauxUI.Properties.Resources.btnAddNewOrder_enabled;
                    
                    btnCheckout.BackgroundImage = ChapeauxUI.Properties.Resources.btnCheckout_hover;
                    btnCheckout.Enabled = false;
                }
            }
            else if (currentTable.Status == Status.Free)
            {
                // Table is free, so we can only occupy the table
                btnOccupyTable.BackgroundImage = ChapeauxUI.Properties.Resources.btnOccupyTable_enabled;
                btnAddNewOrder.BackgroundImage = ChapeauxUI.Properties.Resources.btnAddNewOrder_hover1;
                btnCheckout.BackgroundImage = ChapeauxUI.Properties.Resources.btnCheckout_hover1;
            }
        }
        #endregion

        #region Selected
        // Change selected item to served if the item is ready by clicking on it
        private void listViewOrderOverview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrderOverview.SelectedItems.Count == 1)
            {
                OrderItem item = listViewOrderOverview.SelectedItems[0].Tag as OrderItem;

                
                if (item.State == State.ready)
                {
                    OrderItem_Service orderItem_service = new OrderItem_Service();
                    orderItem_service.UpdateOrderItemStatus(item, State.served);
                    Reload();
                }
                else
                {
                    return;
                }
            }
        }
        #endregion

        #region Buttons
        private void btnOccupyTable_Click(object sender, EventArgs e)
        {
            Table_Service table_service = new Table_Service();
            Order_Service order_Service = new Order_Service();

            if (currentTable.Status == Status.Free)
            {
                // Change value in databse to occupied
                table_service.UpdateStatus(currentTable.TableID, Status.Occupied);
                currentTable.Status = Status.Occupied;
                Reload();
            }
            else
            {
                if (tableHasOrder && tableHasItems)
                {
                    return;
                }
                else if (tableHasOrder && !tableHasItems)
                {
                    table_service.UpdateStatus(currentTable.TableID, Status.Free);
                    order_Service.DeleteOrder(order);

                    order = null;
                    currentTable.Status = Status.Free;

                    Reload();
                }
                else
                {
                    table_service.UpdateStatus(currentTable.TableID, Status.Free);
                    currentTable.Status = Status.Free;

                    Reload();
                }
            }
        }

        private void CreateNewOrder()
        {
            order = new Order();
            order.UserID = loggedUser.UserID;
            order.TableID = currentTable.TableID;
            Order_Service orderService = new Order_Service();
            orderService.AddNewOrder(order);
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            if (currentTable.Status == Status.Free)
            {
                return;
            }

            if (!tableHasOrder)
            {
                CreateNewOrder();

                tableHasOrder = true;
            }


            Order_Service orderService = new Order_Service();
            order = orderService.GetByTableID(currentTable.TableID);
            TakeOrderForm form = new TakeOrderForm(order);

            this.Hide();
            form.ShowDialog();
            Reload();
            this.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (currentTable.Status == Status.Free)
            {
                return;
            }
            CheckoutForm checkout = new CheckoutForm(currentTable, loggedUser);
            this.Hide();

            checkout.ShowDialog();
            Reload();
            this.Show();

        }

        private void btnBackToOverview_Click(object sender, EventArgs e)
        {
            TableOverviewForm tableOverview = new TableOverviewForm(loggedUser);
            tableOverview.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
        #endregion
    }
}
