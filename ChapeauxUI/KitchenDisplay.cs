using ChapeauxLogic;
using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauxUI
{
    public partial class KitchenDisplay : Form
    {

        public KitchenDisplay()
        {
            InitializeComponent();
        }
        private void LoadListViews()
        {
            ShowRunningBarOrder();
            ShowRunningKitchenOrder();
        }
        private void ShowRunningBarOrder()
        {
            pnlKitchenDisplay.Hide();

            pnlBarmanDisplay.Show();
            try
            {
                Item_Service itemservice = new Item_Service();
                List<Item> itemlist = itemservice.GetItems();

                listViewBarmanDisplay.Clear();

                foreach (Item item in itemlist)
                {
                    ListViewItem list = new ListViewItem(item.ItemID.ToString());
                    list.SubItems.Add(item.Name.ToString());
                    list.SubItems.Add(item.Price.ToString());
                    list.SubItems.Add(item.Stock.ToString());
                    list.SubItems.Add(item.Category.ToString());
                    list.SubItems.Add(item.VATRate.ToString());
                    list.SubItems.Add(item.menuType.ToString());

                    listViewBarmanDisplay.Items.Add(list);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ShowRunningKitchenOrder()
        {
            pnlBarmanDisplay.Hide();

            pnlKitchenDisplay.Show();
            try
            {
                Item_Service itemservice = new Item_Service();
                List<Item> itemlist = itemservice.GetItems();

                listViewBarmanDisplay.Clear();

                foreach (Item item in itemlist)
                {
                    ListViewItem list = new ListViewItem(item.ItemID.ToString());
                    list.SubItems.Add(item.Name.ToString());
                    list.SubItems.Add(item.Price.ToString());
                    list.SubItems.Add(item.Stock.ToString());
                    list.SubItems.Add(item.Category.ToString());
                    list.SubItems.Add(item.VATRate.ToString());
                    list.SubItems.Add(item.menuType.ToString());

                    listViewBarmanDisplay.Items.Add(list);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KitchenDisplay_Load(object sender, EventArgs e)
        {

        }

        private void FrameBoxKitchen_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlKitchenDisplay.Hide();
            pnlBarmanDisplay.Show();
        }

        private void listViewTableKitchen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOrderReadyToBeServed_Click_1(object sender, EventArgs e)
        {

        }
    }
}
