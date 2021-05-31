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

        #region Global
        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            ShowPanel("Checkout");
        }

        private void HideAllPanels()
        {
            //hide main panels
            pnlCheckout.Hide();
            pnlPayment.Hide();

            //hide sub-panels
            subPnlCash.Hide();
        }
        #endregion

        #region PanelSelection
        private void ShowPanel(string panelName)
        {
            //Hide panels
            HideAllPanels();

            //show requested panel
            if (panelName == "Checkout")
            {
                pnlCheckout.Show();
            }

            else if (panelName == "Payment")
            {
                pnlPayment.Show();
            }

            else if (panelName == "Overview")
            {
                pnlPaymentOverview.Show();
            }
        }
        #endregion

        //Panels
        #region Checkout
        private void btnClearTip_Click(object sender, EventArgs e)
        {
            txtTipAmount.Clear();
        }

        private void btnToPayment_Click(object sender, EventArgs e)
        {
            ShowPanel("Payment");
        }
        #endregion

        #region Payment
        private void btnBackToCheckout_Click(object sender, EventArgs e)
        {
            ShowPanel("Checkout");
        }

        private void btnFinishPayment_Click(object sender, EventArgs e)
        {
            ShowPanel("Overview");

            //Add code for saving transaction info etc.
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            subPnlCard.Hide(); //!!!!!!!If used more create new method private void HideSubPanels()
            subPnlCash.Show();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            subPnlCash.Hide();
            subPnlCard.Show();
        }
        #endregion

        #region PaymentOverview
        private void btnBackToPayment_Click(object sender, EventArgs e)
        {
            ShowPanel("Payment");
        }

        //*** add method to load listview of transaction/order
        //*** add option to write and store comments: popup + open digital keyboard + store comment into order

        private void btnCloseOrder_Click(object sender, EventArgs e)
        {
            //CLOSE ORDER

            DialogResult result = MessageBox.Show("Free Up Table?", "Set Table Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //set table status to free
            }

            else
            {
                //keep table status as occupied
            }

            //show table overview
        }
        #endregion


    }
}
