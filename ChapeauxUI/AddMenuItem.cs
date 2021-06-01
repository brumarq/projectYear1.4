﻿using System;
using ChapeauxModel;
using ChapeauxLogic;
using System.Windows.Forms;

namespace ChapeauxUI
{
    public partial class AddMenuItem : Form
    {
        public AddMenuItem()
        {
            InitializeComponent();
        }

        private void butAddMenuItem_Click(object sender, EventArgs e)
        {
            Item_Service item_Service = new Item_Service();
            int effectedRows = 0;
            bool emptyFields = false;

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text)
                || string.IsNullOrEmpty(txtStock.Text) || string.IsNullOrEmpty(txtCategory.Text) || string.IsNullOrEmpty(txtCourse.Text)
                || string.IsNullOrEmpty(txtVATRate.Text)) 
            {
                emptyFields = true; 
            }

            if (emptyFields)
            {
                MessageBox.Show("Please Fill All Fields!", "Required Fields are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure?", "Add Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {

                    Item existingMenuItem = item_Service.GetItemByName(txtName.Text);

                    if (existingMenuItem != null)
                        MessageBox.Show("Item already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        Item newMenuItem = new Item()
                        {
                            Name = txtName.Text,
                            Price = int.Parse(txtPrice.Text),
                            Stock = int.Parse(txtStock.Text),
                            Category = txtCategory.Text,
                            VATRate = decimal.Parse(txtVATRate.Text),
                            Course = txtCourse.Text
                        };

                        if (effectedRows >= 0)
                        {
                            item_Service.AddMenuItem(newMenuItem);  //add the new Item to the DB
                            MessageBox.Show("Item Added Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                            MessageBox.Show("Could not add the item!");
                    }
                }
            }
        }                
    }
}
