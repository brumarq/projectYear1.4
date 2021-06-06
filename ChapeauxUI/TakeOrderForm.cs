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
    public partial class TakeOrderForm : Form
    {
        Order order;
        OrderItem item;
        List<Item> selectedItems;

        public TakeOrderForm(Table table, Order order)
        {
            InitializeComponent();
            selectedItems = new List<Item>();
            this.order = order;

        }

        private void TakeOrderForm_Load(object sender, EventArgs e)
        {
            GetMenu();
        }

        private void GetMenu()
        {
            try
            {
                listView1.Clear();
                Item_Service itemService = new Item_Service();
                List<Item> menu = itemService.GetItems();

                foreach (Item menuItem in menu)
                {
                    ListViewItem li = new ListViewItem(menuItem.ItemID.ToString(), 0);
                    li.SubItems.Add(menuItem.Name);
                    li.SubItems.Add(menuItem.Category);
                    listView1.Items.Add(li);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = new OrderItem
            {
                OrderItemID = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text),
                OrderID = order.OrderID,
                Count = Convert.ToInt32(txtSelectedCount.Text),
                State = State.loading,
                Comment = "",
                orderDateTime = DateTime.Now
            };
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                return;
            }


        }

        private void txtSelectedCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}
