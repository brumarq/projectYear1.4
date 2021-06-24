using ChapeauxLogic;
using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauxUI
{
    public partial class KitchenDisplay : Form
    {
        private OrderItem orderItem;
        private User user;

        public KitchenDisplay(User user)
        {
            this.user = user;
            InitializeComponent();

            lblUserFullName.Text = $"{this.user.FirstName} {this.user.LastName}";

            DisplayForUser();
        }

        private void DisplayForUser()
        {
            if (user.Role == Role.Chef)
            {
                ShowPanel("Kitchen");
                try
                {
                    //Change to OrderItems

                    //Order order
                    FillingTheListViews();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

            else if (user.Role == Role.Bartender)
            {
                ShowPanel("Bar");
                try
                {
                    //Change to OrderItems

                    //Order order
                    FillingTheListViews();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        }
        private void FillingTheListViews()
        {
            OrderItem_Service orderitemservice = new OrderItem_Service();
            List<OrderItem> orderitems;
            ListView listvieworderitems;
            
            if (user.Role == Role.Chef)
            {
                orderitems = orderitemservice.GetLoadingFoodItems();
                listViewKitchenOrdersDetail.Items.Clear();
                listvieworderitems = listViewKitchenOrdersDetail;
            }
            else
            {
                orderitems = orderitemservice.GetLoadingDrinkItems();
                listViewBarmanOrdersDetail.Items.Clear();
                listvieworderitems = listViewBarmanOrdersDetail;

            }

            Order_Service orderservice = new Order_Service();
            List<Order> orders = orderservice.GetOrders();
            foreach (OrderItem orderitem in orderitems)
            {
                //Order order = orderservice.GetOrderByID(orderitem.OrderID);
                
                ListViewItem list = new ListViewItem(orderitem.OrderItemID.ToString());
                
                foreach (Order order in orders)
                {
                    if (order.OrderID == orderitem.OrderID)
                    {
                        list.SubItems.Add(order.TableID.ToString());
                    }
                }
                list.SubItems.Add(orderitem.Name);
                list.SubItems.Add(orderitem.Count.ToString());
                list.SubItems.Add(orderitem.State.ToString());
                list.SubItems.Add(orderitem.Comment);
                list.SubItems.Add(orderitem.OrderDateTime.ToString("HH:mm:ss"));
                list.Tag = orderitem;
                listvieworderitems.Items.Add(list);

            }
        }

        private void ShowPanel(string panelName)
        {
            HideAllPanels();

            if (panelName == "Kitchen")
            {
                pnlKitchenDisplay.Show();
            }

            else if (panelName == "Bar")
            {
                pnlBarmanDisplay.Show();
            }
        }

        private void HideAllPanels()
        {
            pnlBarmanDisplay.Hide();
            pnlKitchenDisplay.Hide();
        }
        #region ShowRunningKitchen And BarOrder

        #endregion

        private void KitchenDisplay_Load(object sender, EventArgs e)
        {

        }

        #region ListviewsOfBothKitchenAndBar
        private void listViewKitchenOrdersDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewKitchenOrdersDetail.SelectedItems.Count == 1)
            {
                orderItem = listViewKitchenOrdersDetail.SelectedItems[0].Tag as OrderItem;
            }
        }
        
        private void listViewBarmanOrdersDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBarmanOrdersDetail.SelectedItems.Count == 1)
            {
                orderItem = listViewBarmanOrdersDetail.SelectedItems[0].Tag as OrderItem;
            }
        }
        #endregion
        #region Buttons
        private void btnOrderReadyToBeServed_Click_1(object sender, EventArgs e)
        {
            OrderItem_Service orderitemservice = new OrderItem_Service();
            orderitemservice.UpdateOrderItemStatus(orderItem, State.ready);
            FillingTheListViews();//Updated method for Kitchen
        }
        private void btnLogOutKitchen_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void btnLogOutBarman_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OrderItem_Service orderitemservice = new OrderItem_Service();
            orderitemservice.UpdateOrderItemStatus(orderItem, State.ready);
            FillingTheListViews();//Updated method for Bar
        }
        #endregion

        private void btnReloadBar_Click(object sender, EventArgs e)
        {
            DisplayForUser();

        }

        private void btnReloadKitchen_Click(object sender, EventArgs e)
        {
            listViewKitchenOrdersDetail.Items.Clear();
            FillingTheListViews();
        }

        private void tmrReloadListViews_Tick_1(object sender, EventArgs e)
        {
            FillingTheListViews();
        }
    }
}
