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
        User loggedUser;

        public MenuItemDisplayForm(User user)
        {
            InitializeComponent();
            
            lblUserFullName.Text = $"{user.FirstName} {user.LastName}";
            loggedUser = user;
         
            RefreshItemList();
        }

        //this list also get items with 'GetItems' method
        public void RefreshItemList()
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

        //fill textbox information for selected item
        private void listViewDisplayForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDisplayForm.SelectedItems.Count == 1)
            {
                menuItem = listViewDisplayForm.SelectedItems[0].Tag as Item;

                txtName.Text = menuItem.Name.ToString();
                txtPrice.Text = menuItem.Price.ToString();
                txtStock.Text = menuItem.Stock.ToString();
                cbCategory.Text = menuItem.Category.ToString();
                cbType.Text = menuItem.Course.ToString();
                txtVatRate.Text = menuItem.VATRate.ToString();
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            AddNewItemForm addNewItemForm = new AddNewItemForm(this);
            if (addNewItemForm.Enabled)
            {
                //lets not go back to another form before doing something with form infront
                addNewItemForm.ShowDialog();
            }
        }

        public void UpdateItem()
        {
            try
            {
                //updating through txtBoxes
                menuItem.Name = txtName.Text;
                menuItem.Price = decimal.Parse(txtPrice.Text);
                menuItem.Stock = int.Parse(txtStock.Text);
                menuItem.Category = cbCategory.Text;
                menuItem.Course = cbType.Text;
                menuItem.VATRate = decimal.Parse(txtVatRate.Text);

                if (MessageBox.Show($"Are you sure you want to update '{txtName.Text}'?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    itemService.EditMenuItem(menuItem);
                    MessageBox.Show("Menu item updated successfully.");

                    RefreshItemList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            UpdateItem();
        }

        private void RemoveItem()
        {
            try 
            {
                if (MessageBox.Show($"Are you sure you want to remove '{txtName.Text}'?", "Remove", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    menuItem = listViewDisplayForm.SelectedItems[0].Tag as Item;
                    itemService.DeleteMenuItem(menuItem);
                    MessageBox.Show("Menu item deleted successfully.");

                    RefreshItemList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void butMenuItemOverview_Click(object sender, EventArgs e)
        {
            if (butMenuItemOverview.Enabled)
            {
                RefreshItemList();
            }
        }
        //if 'user disply overview button' pressed, pop out user overview form
        private void butUserOverview_Click(object sender, EventArgs e)
        {
            if (butUserOverview.Enabled)
            {
                UsersDisplayForm usersDisplayForm = new UsersDisplayForm(loggedUser);
                usersDisplayForm.Show();
                Close();
            }
        }

        private void MenuItemDisplayForm_Load(object sender, EventArgs e)
        {
            butMenuItemOverview.BackColor = Color.Yellow;
        }
        //shows login screen
        private void butLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            Close();
        }
    }
}
