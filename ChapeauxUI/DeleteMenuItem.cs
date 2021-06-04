﻿using System;
using ChapeauxModel;
using ChapeauxLogic;
using System.Windows.Forms;

namespace ChapeauxUI
{
    public partial class DeleteMenuItem : Form
    {
        public DeleteMenuItem(Item menuItem)
        {
            InitializeComponent();
        }

        private void butDeleteMenuItem_Click(object sender, EventArgs e)
        {
            Item_Service item_Service = new Item_Service();

            bool emptyFields = false;
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text)
                || string.IsNullOrEmpty(txtStock.Text) || string.IsNullOrEmpty(txtCategory.Text) || string.IsNullOrEmpty(txtCourse.Text)
                || string.IsNullOrEmpty(txtVATRate.Text))
            {
                emptyFields = true;
            }

            if (emptyFields == true)
            {
                MessageBox.Show("Please Fill All Required Fields To Delete!", "Required Fields are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Item itemToDelete = new Item()
                {
                    Name = txtName.Text,
                    Price = double.Parse(txtPrice.Text),
                    Stock = int.Parse(txtStock.Text),
                    Category = txtCategory.Text,
                    VATRate = decimal.Parse(txtVATRate.Text),
                    Course = txtCourse.Text
                };

                DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                        item_Service.DeleteMenuItem(itemToDelete); //delete the item from the DB 
                        MessageBox.Show("Item deletion successful!");
                }
                else
                    MessageBox.Show("Could not delete the item!");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}