using ChapeauxLogic;
using ChapeauxModel;
using ChapeauxUI;
using System;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class TableDetails : Form
    {
        private User loggedUser;
        public Table currentTable;
        bool tableHasOrders;
        Order order;

        public TableDetails(User user, int tableNumber)
        {
            this.loggedUser = user;

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
        }

        private void TableDetails_Load(object sender, EventArgs e)
        {
            lblUserFullName.Text = $"{loggedUser.FirstName} {loggedUser.LastName}";
            lblTableStatus.Text = $"Table {currentTable.TableID}: {currentTable.Status}";
            btnCheckout.Enabled = false;
            fillUpOrderDetails();
            updateStatus();
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
                listViewOrderOverview4.Items.Clear();

                if (order == null)
                {
                    return;
                }

                listViewOrderOverview4.Items.Clear();

                foreach (OrderItem orderItem in order.orderItems)
                {
                    ListViewItem li = new ListViewItem(orderItem.Name);
                    li.SubItems.Add(orderItem.Count.ToString());
                    li.SubItems.Add(orderItem.Price.ToString("0.00"));
                    li.SubItems.Add(orderItem.State.ToString());
                    listViewOrderOverview4.Items.Add(li);
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

            if (currentTable.Status == Status.Free)
            {
                // Change value in databse to occupied
                table_service.UpdateStatus(currentTable.TableID, Status.Occupied);
                currentTable.Status = Status.Occupied;
                updateStatus();
            }
            else
            {
                if (tableHasOrders)
                {
                    updateStatus();
                    return;
                }
                else
                {
                    table_service.UpdateStatus(currentTable.TableID, Status.Free);
                    currentTable.Status = Status.Free;
                    updateStatus();
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
                    tableHasOrders = true;
                    bool itemsServed = true;
                    if (order.orderItems.Count != 0)
                    {
                        // check if every orderitems have been served
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
                        btnCheckout.Enabled = false;
                    }

                    btnOccupyTable.BackgroundImage = ChapeauxUI.Properties.Resources.btnFreeTable_hover;
                }
                else
                {
                    tableHasOrders = false;
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

            if (!tableHasOrders)
            {
                CreateNewOrder();

                tableHasOrders = true;
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
            CheckoutForm checkout = new CheckoutForm(currentTable);
            this.Hide();

            checkout.ShowDialog();
            Reload();
            this.Show();

        }
    }
}
