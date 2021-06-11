using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ChapeauxModel;
using ChapeauxLogic;

namespace ChapeauxUI
{
    public partial class MenuItemDisplayForm : Form
    {
        Item menuItem = new Item();
        Item_Service itemService;
        ListViewItem lvItem;

        public MenuItemDisplayForm(Item menuItem)
        {
            InitializeComponent();
            this.menuItem = menuItem;
        }

        private void listViewDisplayForm_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void GetItemList()
        {
            itemService = new Item_Service();
            List<Item> menuItems = itemService.GetItems();
            listViewDisplayForm.Items.Clear();

            foreach (Item i in menuItems)
            {
                lvItem = new ListViewItem(i.ItemID.ToString(), 0);
                lvItem.SubItems.Add(i.Name);
                lvItem.SubItems.Add(i.Price.ToString("0.00"));
                lvItem.SubItems.Add(i.Stock.ToString("0"));
                lvItem.SubItems.Add(i.Category.ToString());
                lvItem.SubItems.Add(i.Course.ToString());
                lvItem.SubItems.Add(i.VATRate.ToString("0.00"));

                listViewDisplayForm.Items.Add(lvItem);
            }
        }

        private void butDisplay_Click(object sender, EventArgs e)
        {
            GetItemList();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            AddMenuItem addMenuItem = new AddMenuItem(menuItem);
            addMenuItem.Show();
            this.Close();
        }

        private void Delete()
        {
            if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                GetItemList();
                itemService.DeleteMenuItem(menuItem);
            }
            else
                return;
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
