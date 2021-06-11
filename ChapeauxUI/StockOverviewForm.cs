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
    public partial class StockOverviewForm : Form
    {
        public StockOverviewForm()
        {
            InitializeComponent();
        }

        private void lblStockOverview_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void butQuantityRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
