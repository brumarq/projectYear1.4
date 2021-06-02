using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChapeauxLogic;
using ChapeauxModel;

namespace ChapeauxUI
{
    public partial class EditMenuItemForm : Form
    {
        Item existingItem;
        Item itemToEdit;

        public EditMenuItemForm()
        {
            InitializeComponent();
        }

        private void EditMenuItemForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        public void Initialize()
        {
            // it fills the textboxes with the current information
            txtName.Text = itemToEdit.Name;
            itemToEdit.Price = double.Parse(txtPrice.Text);
            itemToEdit.Stock  = int.Parse(txtStock.Text);
            itemToEdit.Category = txtCategory.Text;
            itemToEdit.Course = txtCourse.Text;
            itemToEdit.VATRate = decimal.Parse(txtVATRate.Text);
        }

        private void butEditMenuItem_Click(object sender, EventArgs e)
        {
            bool emptyFields = false;
            Item_Service item_Service = new Item_Service();
            
            //validating the variables above are not null or empty
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.Text = editUser.LoginUsername;
            }
            else if (string.IsNullOrEmpty(txtPrice.Text))
            {
                txtPrice.Text = editUser.FirstName;
            }
            else if (string.IsNullOrEmpty(txtStock.Text))
            {
                txtStock.Text = editUser.LastName;
            }
            else if (string.IsNullOrEmpty(txtCategory.Text))
            {
                txtCategory.Text = editUser.LoginPassword;
            }
            else if (string.IsNullOrEmpty(txtCourse.Text))
            {
                txtCourse.Text = editUser.LoginPassword;
            }
            else if (string.IsNullOrEmpty(txtVATRate.Text))
            {
                txtVATRate.Text = editUser.LoginPassword;
            }

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text)
                || string.IsNullOrEmpty(txtStock.Text) || string.IsNullOrEmpty(txtCategory.Text) || string.IsNullOrEmpty(txtCourse.Text)
                || string.IsNullOrEmpty(txtVATRate.Text))
            {
                emptyFields = true;
            }
            if (emptyFields == true)
            {
                MessageBox.Show("Please Fill All Required Fields", "Required Fields are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure?", "Edit Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Item newMenuItem = new Item()
                    {
                        Name = txtName.Text,
                        Price = double.Parse(txtPrice.Text),
                        Stock = int.Parse(txtStock.Text),
                        Category = txtCategory.Text,
                        VATRate = decimal.Parse(txtVATRate.Text),
                        Course = txtCourse.Text
                    };

                    item_Service.AddMenuItem(newMenuItem);  //add the new Item to the DB
                    MessageBox.Show("Item Added Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Could not edit the account!");
            }

        }

    }
}
