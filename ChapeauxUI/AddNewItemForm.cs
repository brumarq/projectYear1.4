using System;
using System.Windows.Forms;
using ChapeauxModel;
using ChapeauxLogic;

namespace ChapeauxUI
{
    public partial class AddNewItemForm : Form
    {
        Item menuItem;
        Item_Service item_Service;
        //need this to call method itemForm.RefreshItemList'
        MenuItemDisplayForm itemForm;
        
        public AddNewItemForm(MenuItemDisplayForm itemForm)
        {
            InitializeComponent();
            this.itemForm = itemForm;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Are you sure you want to add '{txtName.Text}' to the menu?", "Add", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    menuItem = new Item();
                    menuItem.Name = txtName.Text;
                    menuItem.Price = decimal.Parse(txtPrice.Text);
                    menuItem.Stock = int.Parse(txtStock.Text);
                    menuItem.Category = cbCategory.Text;
                    menuItem.Course = cbType.Text;
                    menuItem.VATRate = decimal.Parse(txtVATRate.Text);

                    item_Service = new Item_Service();
                    item_Service.AddMenuItem(menuItem);
                    itemForm.RefreshItemList();

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
            Close();
        }
    }
}
