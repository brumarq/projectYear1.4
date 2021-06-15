using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ChapeauxModel;
using ChapeauxLogic;
using System.Drawing;

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
                lvItem = new ListViewItem(i.ItemID.ToString(), "0");
                lvItem.SubItems.Add(i.Name);
                lvItem.SubItems.Add(i.Price.ToString("0.00"));
                lvItem.SubItems.Add(i.Stock.ToString("0"));
                lvItem.SubItems.Add(i.Category.ToString());
                lvItem.SubItems.Add(i.Course.ToString());
                lvItem.SubItems.Add(i.VATRate.ToString("0.00"));
                
                lvItem.Tag = i;

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
                cbCategory.Text = menuItem.Category.ToString();
                cbCourse.Text = menuItem.Course.ToString();
                txtVatRate.Text = menuItem.VATRate.ToString();
            }
        }

        public void AddItem()
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Add", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    menuItem.Name = txtName.Text;
                    menuItem.Price = decimal.Parse(txtPrice.Text);
                    menuItem.Stock = int.Parse(txtStock.Text);
                    menuItem.Category = cbCategory.Text;
                    menuItem.Course = cbCourse.Text;
                    menuItem.VATRate = decimal.Parse(txtVatRate.Text);

                    itemService.AddMenuItem(menuItem);

                    MessageBox.Show($"Menu Item added successfully.");
                    
                    GetItemList();
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EditItem()
        {
            try
            {
                menuItem.Name = txtName.Text;
                menuItem.Price = decimal.Parse(txtPrice.Text);
                menuItem.Stock = int.Parse(txtStock.Text);
                menuItem.Category = cbCategory.Text;
                menuItem.Course = cbCourse.Text;
                menuItem.VATRate = decimal.Parse(txtVatRate.Text);

                if (MessageBox.Show("Are you sure?", "Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    itemService.EditMenuItem(menuItem);
                    MessageBox.Show("Menu item edit successful.");

                    GetItemList();
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    menuItem = listViewDisplayForm.SelectedItems[0].Tag as Item;
                    itemService.DeleteMenuItem(menuItem);
                    MessageBox.Show("Menu item deleted successfully.");

                    GetItemList();
                }
                else
                    return;
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

        private void butMenuItemOverview_Click(object sender, EventArgs e)
        {
            if (butMenuItemOverview.Enabled)
            {
                GetItemList();
            }
        }

        private void butUserOverview_Click(object sender, EventArgs e)
        {
            if (butUserOverview.Enabled)
            {
                UsersDisplayForm usersDisplayForm = new UsersDisplayForm();
                usersDisplayForm.Show();
            }
        }

        private void MenuItemDisplayForm_Load(object sender, EventArgs e)
        {
            butMenuItemOverview.BackColor = Color.Yellow;
        }
    }
}
