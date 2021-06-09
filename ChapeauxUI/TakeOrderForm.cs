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
        Item item;
        OrderItem orderItem;
        List<OrderItem> addedItems = new List<OrderItem>();

        public TakeOrderForm(Order order)
        {
            InitializeComponent();
            this.order = order;
            GetMenu();
        }

        private void TakeOrderForm_Load(object sender, EventArgs e)
        {
            btnAddToOrder.Enabled = false;
        }

        private void GetMenu()
        {
            try
            {
                Item_Service itemService = new Item_Service();
                List<Item> menu = itemService.GetItems();
                listView1.Items.Clear();

                foreach (Item menuItem in menu)
                {
                    ListViewItem li = new ListViewItem(menuItem.ItemID.ToString(), 0);
                    li.SubItems.Add(menuItem.Name);
                    li.SubItems.Add(menuItem.Category);
                    li.SubItems.Add(menuItem.Course);
                    li.SubItems.Add(menuItem.Stock.ToString());
                    li.SubItems.Add(menuItem.Price.ToString("0.00"));
                    li.SubItems.Add(menuItem.VATRate.ToString("#0.##%"));
                    li.Tag = menuItem;
                    listView1.Items.Add(li);

                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void FillOrderItem()
        {
            orderItem = new OrderItem()
            {
                ItemID = item.ItemID,
                OrderID = order.OrderID,
                State = State.loading,
                orderDateTime = DateTime.Now,
                Category = item.Category,
                Course = item.Course,
                Name = item.Name,
                Price = item.Price,
                VATRate = item.VATRate
            };
        }

        private void AddItemToOrder()
        {
            OrderItem_Service orderItemService = new OrderItem_Service();
            orderItemService.AddItemToOrder(orderItem);
        }

        private void AddItemToListView()
        {
            addedItems.Add(orderItem);

            listViewItemsToAdd.Items.Clear();

            foreach (OrderItem orderItem in addedItems)
            {
                ListViewItem li = new ListViewItem(orderItem.ItemID.ToString());
                li.SubItems.Add(orderItem.Name);
                li.SubItems.Add(orderItem.Count.ToString());
                li.SubItems.Add(orderItem.Comment);
                listViewItemsToAdd.Items.Add(li);
            }

            listViewItemsToAdd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewItemsToAdd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelectedCount.Clear();
            txtItemComment.Clear();

            if (listView1.SelectedItems.Count == 1)
            {
                item = listView1.SelectedItems[0].Tag as Item;
                FillOrderItem();
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                orderItem.Count = Convert.ToInt32(txtSelectedCount.Text);
                orderItem.Comment = txtItemComment.Text;
                AddItemToOrder();
                AddItemToListView();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtSelectedCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSelectedCount_TextChanged(object sender, EventArgs e)
        {
            if (txtSelectedCount.Text.Length > 0)
            {
                btnAddToOrder.Enabled = true;
            }
            else
            {
                btnAddToOrder.Enabled = false;
            }
        }

        private void btnBackToTable_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
