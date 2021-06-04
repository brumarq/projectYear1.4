using ChapeauxLogic;
using ChapeauxModel;
using ChapeauxUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class TableDetails : Form
    {
        private User loggedUser;
        public Table selectedTable;
        bool tableHasOrders;

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
                bool thereIsAnOrder = order_service.getOrderForTable(selectedTable.TableID);

                if (thereIsAnOrder)
                {
                    tableHasOrders = true;
                    btnOccupyTable.BackgroundImage = ChapeauxUI.Properties.Resources.btnFreeTable_hover;

                }
                else
                {
                    tableHasOrders = false;
                    btnOccupyTable.BackgroundImage = ChapeauxUI.Properties.Resources.btnFreeTable_enabled;
                    btnAddNewOrder.BackgroundImage = ChapeauxUI.Properties.Resources.btnAddNewOrder_enabled;
                    btnCheckout.BackgroundImage = ChapeauxUI.Properties.Resources.btnCheckout_enabled;
                }
            }
            else if (selectedTable.Status == Status.Free)
            {
                btnOccupyTable.BackgroundImage = ChapeauxUI.Properties.Resources.btnOccupyTable_enabled;
                btnAddNewOrder.BackgroundImage = ChapeauxUI.Properties.Resources.btnAddNewOrder_hover1;
                btnCheckout.BackgroundImage = ChapeauxUI.Properties.Resources.btnCheckout_hover1;
            }
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            if (selectedTable.Status == Status.Free)
            {
                return;
            }

            // Add code here for new order
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
