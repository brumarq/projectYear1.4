using System;
using System.Windows.Forms;
using ChapeauxModel;
using ChapeauxLogic;

namespace ChapeauxUI
{
    public partial class AddNewItemForm : Form
    {
        Item menuItem = new Item();
        Item_Service item_Service = new Item_Service();
        MenuItemDisplayForm itemForm;
        
        public AddNewItemForm(MenuItemDisplayForm itemForm, Item item)
        {
            InitializeComponent();
            this.itemForm = itemForm;
            menuItem = item;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Are you sure you want to add '{txtName.Text}' to the menu?", "Add", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    menuItem.Name = txtName.Text;
                    menuItem.Price = decimal.Parse(txtPrice.Text);
                    menuItem.Stock = int.Parse(txtStock.Text);
                    menuItem.Category = cbCategory.Text;
                    menuItem.Course = cbType.Text;
                    menuItem.VATRate = decimal.Parse(txtVATRate.Text);

                    item_Service.AddMenuItem(menuItem);
                    itemForm.GetItemList();

                    MessageBox.Show($"'{txtName.Text}' added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
