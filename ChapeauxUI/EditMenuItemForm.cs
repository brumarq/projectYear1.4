using System;
using System.Windows.Forms;
using ChapeauxLogic;
using ChapeauxModel;

namespace ChapeauxUI
{
    public partial class EditMenuItemForm : Form
    {
        Item existingItem;
        Item itemToEdit;
        public EditMenuItemForm(Item existingItem, Item itemToEdit)
        {
            InitializeComponent();
            this.existingItem = existingItem;
            this.itemToEdit = itemToEdit;
        }

        private void EditMenuItemForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        public void Initialize()
        {
            //it fills the textboxes with the current information
            itemToEdit.Name = txtName.Text;
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
                txtName.Text = itemToEdit.Name;
            }
            else if (string.IsNullOrEmpty(txtPrice.Text))
            {
                itemToEdit.Price = double.Parse(txtPrice.Text);
            }
            else if (string.IsNullOrEmpty(txtStock.Text))
            {
                itemToEdit.Stock = int.Parse(txtStock.Text);
            }
            else if (string.IsNullOrEmpty(txtCategory.Text))
            {
                itemToEdit.Category = txtCategory.Text;
            }
            else if (string.IsNullOrEmpty(txtCourse.Text))
            {
                itemToEdit.Course = txtCourse.Text;
            }
            else if (string.IsNullOrEmpty(txtVATRate.Text))
            {
                itemToEdit.VATRate = decimal.Parse(txtVATRate.Text);
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

                    item_Service.EditMenuItem(existingItem, newMenuItem);  //edits the item
                    MessageBox.Show("Item Added Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Could not edit the account!");
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
