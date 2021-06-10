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
        private OrderItem orderitem;
        private User user;

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
            pnlKitchenDisplay.Hide();

            pnlBarmanDisplay.Show();
            try
            {
                listViewBarmanDisplay.Clear();


                //Change to OrderItems
                OrderItem_Service orderitemservice = new OrderItem_Service();
                List<OrderItem> orderitemlist = orderitemservice.GetItems();
                foreach (OrderItem orderItem in orderitemlist)
                {
                    ListViewItem list = new ListViewItem(orderItem.OrderItemID.ToString());
                    list.SubItems.Add(orderitem.OrderID.ToString());
                    list.SubItems.Add(orderitem.Count.ToString());
                    list.SubItems.Add(orderitem.State.ToString());
                    list.SubItems.Add(orderitem.Comment.ToString());
                    list.SubItems.Add(orderitem.orderDateTime.ToString());

                    listViewBarmanDisplay.Items.Add(list);
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }
        private void ShowRunningKitchenOrder()
        {
            pnlBarmanDisplay.Hide();

            pnlKitchenDisplay.Show();
            try
            {
                //Change to OrderItems
                listViewTableKitchen.Clear();
                OrderItem_Service orderitemservice = new OrderItem_Service();
                List<OrderItem> orderitemlist = orderitemservice.GetItems();

                foreach (OrderItem orderitem in orderitemlist)
                {
                    ListViewItem list = new ListViewItem(orderitem.OrderItemID.ToString());
                    list.SubItems.Add(orderitem.OrderID.ToString());
                    list.SubItems.Add(orderitem.Count.ToString());
                    list.SubItems.Add(orderitem.State.ToString());
                    list.SubItems.Add(orderitem.Comment.ToString());
                    list.SubItems.Add(orderitem.orderDateTime.ToString());

                    listViewBarmanDisplay.Items.Add(list);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
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
            orderitem = new OrderItem
            {
                OrderItemID = Convert.ToInt32(listViewTableKitchen.SelectedItems[0].SubItems[0].Text),
                OrderID = Convert.ToInt32(listViewTableKitchen.SelectedItems[0].SubItems[0].Text),
                Count = Convert.ToInt32(listViewTableKitchen.SelectedItems[0].SubItems[0].Text),
                State = State.loading ,
                Comment = "",
                orderDateTime = DateTime.Now,
            };
        }

        private void btnOrderReadyToBeServed_Click_1(object sender, EventArgs e)
        {

        }
    }
}
