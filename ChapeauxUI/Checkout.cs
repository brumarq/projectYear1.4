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
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
        }

        #region Buttons
        private void btnClearTip_Click(object sender, EventArgs e)
        {
            txtTipAmount.Clear();
        }
        #endregion

        private void btnClearTip_MouseHover(object sender, EventArgs e)
        { 

        }
    }
}
