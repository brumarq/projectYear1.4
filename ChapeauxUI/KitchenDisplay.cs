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
        private Order order;

        public KitchenDisplay(User user)
        {
            this.user = user;
            InitializeComponent();
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

        private void ShowRunningBarOrder()
        {
            try
            {
                //if (listViewBarmanDisplay.SelectedItems.Count == 0)
                //{
                //    return;
                //}
                //order = listViewBarmanDisplay.SelectedItems[0].Tag as Order;

                //Change to OrderItems
                listViewBarmanOrdersDetail.Items.Clear();
                OrderItem_Service orderitemservice = new OrderItem_Service();
                //Order order
                List<OrderItem> orderitemlist = orderitemservice.GetLoadingDrinkItems();

                foreach (OrderItem orderitem in orderitemlist)
                {
                    ListViewItem list = new ListViewItem(orderitem.OrderItemID.ToString());
                    list.SubItems.Add(orderitem.Count.ToString());
                    list.SubItems.Add(orderitem.State.ToString());
                    list.SubItems.Add(orderitem.Comment);
                    list.SubItems.Add(orderitem.OrderDateTime.ToString("HH:mm"));

                    listViewBarmanOrdersDetail.Items.Add(list);

                    listViewBarmanOrdersDetail.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    listViewBarmanOrdersDetail.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }



            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            //    pnlKitchenDisplay.Hide();

            //    pnlBarmanDisplay.Show();
            //    try
            //    {
            //        Order_Service order_Service = new Order_Service();
            //        List<Order> orders = order_Service.GetDrinkOrders();
            //        listViewBarmanDisplay.Items.Clear();
            //        foreach (Order order in orders)
            //        {
            //            ListViewItem li = new ListViewItem(order.OrderID.ToString(), 0);
            //            li.SubItems.Add(order.TableID.ToString());
            //            li.SubItems.Add(order.startDateTime.ToString("HH:mm"));
            //            li.Tag = order;

            //            listViewBarmanDisplay.Items.Add(li);

            //            listViewBarmanDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //            listViewBarmanDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //        }
            //    }
            //    catch (Exception exc)
            //    {
            //        MessageBox.Show(exc.Message);
            //    }
        }
        private void ShowRunningKitchenOrder()
        {
            try
            {
                //if (listViewTableKitchen.SelectedItems.Count == 0)
                //{
                //    return;
                //}
                //order = listViewTableKitchen.SelectedItems[0].Tag as Order;

                //Change to OrderItems
                listViewKitchenOrdersDetail.Items.Clear();
                OrderItem_Service orderitemservice = new OrderItem_Service();
                //Order order
                List<OrderItem> orderitemlist = orderitemservice.GetLoadingFoodItems();

                foreach (OrderItem orderitem in orderitemlist)
                {
                    ListViewItem list = new ListViewItem(orderitem.OrderItemID.ToString());
                    list.SubItems.Add(orderitem.Count.ToString());
                    list.SubItems.Add(orderitem.State.ToString());
                    list.SubItems.Add(orderitem.Comment);
                    list.SubItems.Add(orderitem.OrderDateTime.ToString("HH:mm:ss"));

                    listViewKitchenOrdersDetail.Items.Add(list);

                    listViewKitchenOrdersDetail.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    listViewKitchenOrdersDetail.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }



            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            //    pnlBarmanDisplay.Hide();

            //    pnlKitchenDisplay.Show();
            //    try
            //    {
            //        Order_Service order_Service = new Order_Service();
            //        List<Order> orders = order_Service.GetFoodOrders();
            //        listViewTableKitchen.Items.Clear();
            //        foreach (Order order in orders)
            //        {
            //            ListViewItem li = new ListViewItem(order.OrderID.ToString(), 0);
            //            li.SubItems.Add(order.TableID.ToString());
            //            li.SubItems.Add(order.startDateTime.ToString("HH:mm"));
            //            li.Tag = order;

            //            listViewTableKitchen.Items.Add(li);

            //            listViewTableKitchen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //            listViewTableKitchen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //        }
            //    }
            //    catch (Exception exc)
            //    {
            //        MessageBox.Show(exc.Message);
            //    }

        }


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

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewKitchenOrdersDetail.SelectedItems.Count != 1)
            {
                return;
            }
        }

        private void listViewTableKitchen_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnOrderReadyToBeServed_Click_1(object sender, EventArgs e)
        {
            OrderItem_Service orderItem_Service = new OrderItem_Service();
            orderItem_Service.UpdateOrderItemStatus(orderItem, State.ready);
        }

        private void listViewKitchenOrdersDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderItem = listViewKitchenOrdersDetail.SelectedItems[0].Tag as OrderItem;
        }
        private void listViewBarmanOrdersDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            //orderitem = new OrderItem
            //{
            //    OrderItemID = Convert.ToInt32(listViewTableKitchen.SelectedItems[0].SubItems[0].Text),
            //    OrderID = Convert.ToInt32(listViewTableKitchen.SelectedItems[0].SubItems[0].Text),
            //    Count = Convert.ToInt32(listViewTableKitchen.SelectedItems[0].SubItems[0].Text),
            //    State = State.ready,
            //    Comment = "",
            //    orderDateTime = DateTime.Now,
            //};
        }

        private void listViewBarmanDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

    }
}
