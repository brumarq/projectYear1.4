using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ChapeauxModel;
using ChapeauxLogic;

namespace ChapeauxUI
{
    public partial class MenuItemDisplayForm : Form
    {
        Item menuItem;
        Item_Service itemService;
        ListViewItem lvItem;

        public MenuItemDisplayForm(Item menuItem)
        {
            InitializeComponent();
            this.menuItem = menuItem;
         
            GetItemList();
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

        private void listViewDisplayForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDisplayForm.SelectedItems.Count == 1)
            {
                menuItem = listViewDisplayForm.SelectedItems[0].Tag as Item;

                txtName.Text = menuItem.Name.ToString();
                txtPrice.Text = menuItem.Price.ToString();
                txtStock.Text = menuItem.Stock.ToString();
                txtCategory.Text = menuItem.Category.ToString();
                txtCourse.Text = menuItem.Course.ToString();
                txtVatRate.Text = menuItem.VATRate.ToString();
            }
        }

        public void AddItem()
        {

            menuItem.Name = txtName.Text;
            menuItem.Price = decimal.Parse(txtPrice.Text);
            menuItem.Stock = int.Parse(txtStock.Text);
            menuItem.Category = txtCategory.Text;
            menuItem.Course = txtCourse.Text;
            menuItem.VATRate = decimal.Parse(txtVatRate.Text);

            itemService.AddMenuItem(menuItem);

            MessageBox.Show($"Menu Item added successfully.");

        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void DeleteItem()
        {
            try 
            {
                if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    GetItemList();
                    menuItem = listViewDisplayForm.SelectedItems[0].Tag as Item;
                    itemService.DeleteMenuItem(menuItem);
                    MessageBox.Show("Menu item deleted successfully.");
                }
                else
                    return;
                
                if (listViewDisplayForm.SelectedItems.Count < 1)
                {
                    throw new Exception("Please select a row.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        public void EditItem()
        {
            try
            {
                menuItem = listViewDisplayForm.SelectedItems[0].Tag as Item;
                menuItem.Name = txtName.Text;
                menuItem.Price = decimal.Parse(txtPrice.Text);
                menuItem.Stock = int.Parse(txtStock.Text);
                menuItem.Category = txtCategory.Text;
                menuItem.Course = txtCourse.Text;
                menuItem.VATRate = decimal.Parse(txtVatRate.Text);

                if (MessageBox.Show("Are you sure?", "Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    itemService.EditMenuItem(menuItem);
                    MessageBox.Show("Menu item edit successful.");
                }
                else
                    return;
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            EditItem();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
