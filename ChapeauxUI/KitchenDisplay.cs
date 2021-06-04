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
            try
            {
                //listViewBarmanDisplay.Clear();
                //foreach (Item item in collection)
                //{

                //}
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ShowRunningKitchenOrder()
        {

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
