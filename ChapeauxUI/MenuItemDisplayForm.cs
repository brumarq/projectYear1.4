﻿using System;
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

        public MenuItemDisplayForm(Item menuItem, User user)
        {
            InitializeComponent();
            lblUserFullName.Text = $"{user.FirstName} {user.LastName}";
            this.menuItem = menuItem;
            loggedUser = user;
         
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
                txtPrice.Text = menuItem.Price.ToString("0.00");
                txtStock.Text = menuItem.Stock.ToString();
                cbCategory.Text = menuItem.Category.ToString();
                cbType.Text = menuItem.Course.ToString();
                txtVatRate.Text = menuItem.VATRate.ToString();
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
                menuItem.Course = cbType.Text;
                menuItem.VATRate = decimal.Parse(txtVatRate.Text);

                if (MessageBox.Show($"Are you sure you want to update '{txtName.Text}'?", "Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    itemService.EditMenuItem(menuItem);
                    MessageBox.Show("Menu item updated successfully.");

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
            AddNewItemForm addNewItemForm = new AddNewItemForm(menuItem);
            if (addNewItemForm.Enabled)
            {
                this.Hide();
            addNewItemForm.Show();
            }
        }

        private void DeleteItem()
        {
            try 
            {
                if (MessageBox.Show($"Are you sure you want to delete '{txtName.Text}'?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
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
                UsersDisplayForm usersDisplayForm = new UsersDisplayForm(loggedUser);
                usersDisplayForm.Show();
                this.Close();
            }
        }

        private void MenuItemDisplayForm_Load(object sender, EventArgs e)
        {
            butMenuItemOverview.BackColor = Color.Yellow;
        }
    }
}
