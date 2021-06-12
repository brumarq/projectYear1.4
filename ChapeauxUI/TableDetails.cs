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
        public Table currentTable;
        Timer tmr;
        bool tableHasOrder;
        bool tableHasItems;

        Order order;
        List<OrderItem> itemsThatHaveNotBeenServed;

        public TableDetails(User user, int tableNumber)
        {
            this.loggedUser = user;
            itemsThatHaveNotBeenServed = new List<OrderItem>();

            Table_Service table_service = new Table_Service();
            Table selectedTable = table_service.getTable(tableNumber);
            this.currentTable = selectedTable;
            InitializeComponent();
        }
        public void Reload()
        {
            fillUpOrderDetails();
            updateTableState();
            updateStatus();
            if (order != null)
            {
                startTimer();
            }

        }

        private void TableDetails_Load(object sender, EventArgs e)
        {
            lblUserFullName.Text = $"{loggedUser.FirstName} {loggedUser.LastName}";
            lblTableStatus.Text = $"Table {currentTable.TableID}: {currentTable.Status}";
            btnCheckout.Enabled = false;

            tmr = new Timer();
            tmr.Interval = 1000;//ticks every 1 second

            fillUpOrderDetails();
            updateStatus();
            if (order != null)
            {
                startTimer();
            }

        }

        private void startTimer()
        {

            bool everyOrderServed = true;

            foreach (OrderItem orderItems in order.orderItems)
            {
                if (orderItems.State != State.served)
                {
                    itemsThatHaveNotBeenServed.Add(orderItems);
                    everyOrderServed = false;
                }
            }

            if (order != null && !everyOrderServed)
            {
                tmr.Tick += new EventHandler(tmr_Tick);
                tmr.Start();
            }
            else if (order != null && everyOrderServed)
            {
                tmr.Stop();
                LblLocalTime.Text = "";
            }
            else
            {
                tmr.Stop();
                LblLocalTime.Text = "";
            }
        }


        //change the label text inside the tick event
        private void tmr_Tick(object sender, EventArgs e)
        {
            List<OrderItem> orderedListByID = itemsThatHaveNotBeenServed.OrderBy(o => o.OrderItemID).ToList();
            TimeSpan diff = DateTime.Now - orderedListByID[0].OrderDateTime;

            LblLocalTime.Text = $"{diff:hh\\:mm\\:ss}";
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

        private void fillUpOrderDetails()
        {
            try
            {
                Order_Service orderService = new Order_Service();
                order = orderService.GetByTableID(currentTable.TableID);
                listViewOrderOverview.Items.Clear();

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

        private void updateTableState()
        {
            Table_Service table_service = new Table_Service();
            currentTable = table_service.getTable(currentTable.TableID);
        }

        private void updateStatus()
        {
            lblTableStatus.Text = $"Table {currentTable.TableID}: {currentTable.Status}";

            if (currentTable.Status == Status.Occupied || currentTable.Status == Status.Late)
            {
                Order_Service order_service = new Order_Service();
                bool thereIsAnOrder = order_service.tableContainsOrder(currentTable.TableID);

                if (thereIsAnOrder)
                {
                    tableHasOrder = true;
                    bool itemsServed = true;
                    if (order.orderItems.Count != 0)
                    {
                        // check if every orderitems have been served
                        tableHasItems = true;
                        btnOccupyTable.Enabled = false;

                        btnOccupyTable.BackgroundImage = ChapeauxUI.Properties.Resources.btnFreeTable_hover;


                        foreach (OrderItem orderItem in order.orderItems)
                        {
                            if (orderItem.State != State.served)
                            {
                                itemsServed = false;
                            }
                        }

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
                        btnCheckout.BackgroundImage = ChapeauxUI.Properties.Resources.btnCheckout_hover;
                        btnAddNewOrder.BackgroundImage = ChapeauxUI.Properties.Resources.btnAddNewOrder_enabled;
                        btnOccupyTable.BackgroundImage = ChapeauxUI.Properties.Resources.btnFreeTable_enabled;
                        btnCheckout.Enabled = false;
                        btnOccupyTable.Enabled = true;
                        tableHasItems = false;
                    }
                }
                else
                {
                    tableHasOrder = false;
                    btnOccupyTable.BackgroundImage = ChapeauxUI.Properties.Resources.btnFreeTable_enabled;
                    btnAddNewOrder.BackgroundImage = ChapeauxUI.Properties.Resources.btnAddNewOrder_enabled;
                    btnCheckout.BackgroundImage = ChapeauxUI.Properties.Resources.btnCheckout_hover;
                    btnCheckout.Enabled = false;
                }
            }
            else if (currentTable.Status == Status.Free)
            {
                btnOccupyTable.BackgroundImage = ChapeauxUI.Properties.Resources.btnOccupyTable_enabled;
                btnAddNewOrder.BackgroundImage = ChapeauxUI.Properties.Resources.btnAddNewOrder_hover1;
                btnCheckout.BackgroundImage = ChapeauxUI.Properties.Resources.btnCheckout_hover1;
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
    }
}
