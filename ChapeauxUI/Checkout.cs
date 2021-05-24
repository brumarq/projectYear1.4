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
            btnClearTip.Size = new Size(74, 36);
            txtTipAmount.Clear();
        }
        #endregion

        private void btnClearTip_MouseEnter(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap("./");
            b.MakeTransparent(b.GetPixel(0, 0));
        }

        private void btnClearTip_MouseLeave(object sender, EventArgs e)
        {
            btnClearTip.Size = new Size(98, 48);
        }
    }
}
