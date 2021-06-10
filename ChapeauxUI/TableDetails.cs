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
        public Table selectedTable;
        bool tableHasOrders;
        Order order;

        public TableDetails(User user, int tableNumber)
        {
            this.loggedUser = user;

            Table_Service table_service = new Table_Service();
            Table selectedTable = table_service.getTable(tableNumber);
            this.selectedTable = selectedTable;

            InitializeComponent();
        }

        private void TableDetails_Load(object sender, EventArgs e)
        {
            lblUserFullName.Text = $"{loggedUser.FirstName} {loggedUser.LastName}";
            lblTableStatus.Text = $"Table {selectedTable.TableID}: {selectedTable.Status}";
            btnCheckout.Enabled = false;
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

        private void btnOccupyTable_Click(object sender, EventArgs e)
        {
            Table_Service table_service = new Table_Service();

            if (selectedTable.Status == Status.Free)
            {
                // Change value in databse to occupied
                table_service.UpdateStatus(selectedTable.TableID, Status.Occupied);
                selectedTable.Status = Status.Occupied;
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
                    table_service.UpdateStatus(selectedTable.TableID, Status.Free);
                    selectedTable.Status = Status.Free;
                    updateStatus();
                }
            }
        }

        void updateStatus()
        {
            lblTableStatus.Text = $"Table {selectedTable.TableID}: {selectedTable.Status}";

            if (selectedTable.Status == Status.Occupied || selectedTable.Status == Status.Late)
            {
                Order_Service order_service = new Order_Service();
                bool thereIsAnOrder = order_service.getOrderForTable(selectedTable.TableID); // change name

                if (thereIsAnOrder)
                {
                    if (false)
                    {
                        // check if every orderitems have been served
                        btnCheckout.BackgroundImage = ChapeauxUI.Properties.Resources.btnCheckout_hover;
                        btnCheckout.Enabled = false;
                    }
                    tableHasOrders = true;
                    btnOccupyTable.BackgroundImage = ChapeauxUI.Properties.Resources.btnFreeTable_hover;
                    btnCheckout.BackgroundImage = ChapeauxUI.Properties.Resources.btnCheckout_enabled;
                    btnCheckout.Enabled = true;
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
            else if (selectedTable.Status == Status.Free)
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
            order.TableID = selectedTable.TableID;
            Order_Service orderService = new Order_Service();
            orderService.AddNewOrder(order);
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            if (selectedTable.Status == Status.Free)
            {
                return;
            }

            if (!tableHasOrders)
            {
                CreateNewOrder();

                tableHasOrders = true;
            }


            Order_Service orderService = new Order_Service();
            order = orderService.GetByTableID(selectedTable.TableID);
            TakeOrderForm form = new TakeOrderForm(order);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (selectedTable.Status == Status.Free)
            {
                return;
            }

            CheckoutForm checkout = new CheckoutForm(selectedTable);
            this.Hide();
            checkout.ShowDialog();
            this.Show();
        }
    }
}
