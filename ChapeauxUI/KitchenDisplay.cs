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
                ShowRunningKitchenOrder();
            }

            else if (user.Role == Role.Bartender)
            {
                ShowPanel("Bar");
                ShowRunningBarOrder();
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
        private void ShowRunningBarOrder()
        {
            try
            {
                //Change to OrderItems
                listViewBarmanOrdersDetail.Items.Clear();
                OrderItem_Service orderitemservice = new OrderItem_Service();
                Order_Service orderservice = new Order_Service();
                //Order order
                List<OrderItem> orderitemlist = orderitemservice.GetLoadingDrinkItems();

                foreach (OrderItem orderitem in orderitemlist)
                {
                    Order order = orderservice.GetOrderByID(orderitem.OrderID);
                    ListViewItem list = new ListViewItem(orderitem.OrderItemID.ToString());
                    list.SubItems.Add(order.TableID.ToString());
                    list.SubItems.Add(orderitem.Name);
                    list.SubItems.Add(orderitem.Count.ToString());
                    list.SubItems.Add(orderitem.State.ToString());
                    list.SubItems.Add(orderitem.Comment);
                    list.SubItems.Add(orderitem.OrderDateTime.ToString("HH:mm"));
                    list.Tag = orderitem;

                    listViewBarmanOrdersDetail.Items.Add(list);
                }

                /*listViewBarmanOrdersDetail.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewBarmanOrdersDetail.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);*/

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
           
        }
        private void ShowRunningKitchenOrder()
        {
            try
            {
                //Change to OrderItems
                listViewKitchenOrdersDetail.Items.Clear();
                OrderItem_Service orderitemservice = new OrderItem_Service();
                Order_Service orderservice = new Order_Service();
                //Order order
                List<OrderItem> orderitemlist = orderitemservice.GetLoadingFoodItems();
                
                foreach (OrderItem orderitem in orderitemlist)
                {
                    Order order = orderservice.GetOrderByID(orderitem.OrderID);
                    ListViewItem list = new ListViewItem(orderitem.OrderItemID.ToString());
                    list.SubItems.Add(order.TableID.ToString());
                    list.SubItems.Add(orderitem.Name);
                    list.SubItems.Add(orderitem.Count.ToString());
                    list.SubItems.Add(orderitem.State.ToString());
                    list.SubItems.Add(orderitem.Comment);
                    list.SubItems.Add(orderitem.OrderDateTime.ToString("HH:mm:ss"));
                    list.Tag = orderitem;
                    listViewKitchenOrdersDetail.Items.Add(list);
                    
                }
               /* listViewKitchenOrdersDetail.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewKitchenOrdersDetail.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);*/



            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            

        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KitchenDisplay_Load(object sender, EventArgs e)
        {

        }

        private void FrameBoxKitchen_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
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
            OrderItem_Service orderItem_Service = new OrderItem_Service();
            orderItem_Service.UpdateOrderItemStatus(orderItem, State.ready);
            ShowRunningKitchenOrder();//Updated method for Kitchen
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
            OrderItem_Service orderItem_Service = new OrderItem_Service();
            orderItem_Service.UpdateOrderItemStatus(orderItem, State.ready);
            ShowRunningBarOrder();//Updated method for Bar
        }
        #endregion

        private void btnReloadBar_Click(object sender, EventArgs e)
        {
            ShowRunningBarOrder();

        }

        private void btnReloadKitchen_Click(object sender, EventArgs e)
        {
            ShowRunningKitchenOrder();
        }

        private void tmrReloadListViews_Tick(object sender, EventArgs e)
        {
            ShowRunningKitchenOrder();
            ShowRunningBarOrder();
        }
    }
}
