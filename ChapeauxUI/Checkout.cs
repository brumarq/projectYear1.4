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
    public partial class CheckoutForm : Form
    {
        public Table currentTable;
        private Order currentOrder;
        private Transaction transaction;

        public CheckoutForm(Table currentTable)
        {
            InitializeComponent();
            PrepareCheckoutForm(currentTable);
        }

        #region Global
        private void PrepareCheckoutForm(Table currentTable)
        {
            transaction = new Transaction();
            this.currentTable = currentTable;
            currentOrder = GetOrder(currentTable);
            ShowCurrentOrder(currentOrder);
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            ShowPanel("Checkout");
        }

        private void HideAllPanels()
        {
            //hide main panels
            pnlCheckout.Hide();
            pnlPayment.Hide();
            pnlPaymentOverview.Hide();

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
        //Events
        private void btnClearTip_Click(object sender, EventArgs e)
        {
            transaction.TipAmount = 0.0m;
            txtTipAmount.Text = $"{transaction.TipAmount:0.00}";
            txtToPay.Text = $"{currentOrder.TotalPrice:0.00}";
        }

        private void btnToPayment_Click(object sender, EventArgs e)
        {
            ShowPanel("Payment");
        }

        private void txtTipAmount_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    decimal toPay = 
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message);
            //}
        }

        private void txtToPay_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    lblNegativeError.ResetText();
            //    decimal toPay = Convert.ToDecimal(txtToPay.Text);
            //    decimal tipAmount = toPay - currentOrder.TotalPrice;
            //    txtTipAmount.Text = $"{tipAmount:0.00}";

            //    CheckForNegative(tipAmount, toPay);

            //}
            //catch (Exception exc)
            //{
            //    lblNegativeError.Text = exc.Message;
            //}
        }

        private void btnRemoveComment_Click(object sender, EventArgs e)
        {
            txtFeedback.Clear();
        }

        //Methods
        private bool CheckForNegative(decimal tipAmount, decimal toPay)
        {
            //if (tipAmount < 0)
            //{
            //    txtTipAmount.Text = 
            //    throw new Exception("Negative values are not allowed!");
            //}

            if (toPay < currentOrder.TotalPrice)
            {
                txtToPay.Text = $"{currentOrder.TotalPrice:0.00}";
                throw new Exception("Price to pay cannot be lower than total price!");
            }
            return false;
        }

        private Order GetOrder(Table currentTable)
        {
            Order_Service orderService = new Order_Service();
            return orderService.GetByTableID(currentTable.TableID);
        }

        private void ShowCurrentOrder(Order currrentOrder)
        {
            try
            {
                foreach (OrderItem orderItem in currentOrder.orderItems)
                {
                    ListViewItem li = new ListViewItem(orderItem.ItemID.ToString(), 0);
                    li.SubItems.Add(orderItem.Name);
                    li.SubItems.Add(orderItem.Count.ToString());
                    li.SubItems.Add(orderItem.Price.ToString("0.00"));
                    listViewCheckoutOrder.Items.Add(li);
                }

                lblCheckoutOrderID.Text = $"#{currentOrder.OrderID}";
                lblTotalResult.Text = $"{currentOrder.TotalPrice: 0.00}";
                lblVATHighResult.Text = $"{currentOrder.VATHigh: 0.00}";
                lblVATLowResult.Text = $"{currentOrder.VATLow: 0.00}";
                txtTipAmount.Text = $"{transaction.TipAmount: 0.00}";
                txtToPay.Text = $"{currentOrder.TotalPrice: 0.00}";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion

        #region Payment
        private void btnBackToCheckout_Click(object sender, EventArgs e)
        {
            ShowPanel("Checkout");
        }

        private void btnFinishPayment_Click(object sender, EventArgs e)
        {
            transaction.TotalPrice = Convert.ToDecimal(txtToPay.Text);
            transaction.TipAmount = Convert.ToDecimal(txtTipAmount.Text);
            transaction.Feedback = txtFeedback.Text;
            transaction.TransactionDate = DateTime.Now;
            transaction.Order = currentOrder;

            ShowPanel("Overview");
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //prevent unwanted input
        private void txtTipAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        private void txtToPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        private void frameBox_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void txtToPay_Leave(object sender, EventArgs e)
        {
            try
            {
                lblNegativeError.ResetText();
                decimal toPay = Convert.ToDecimal(txtToPay.Text);
                decimal tipAmount = toPay - currentOrder.TotalPrice;
                
                if (!CheckForNegative(tipAmount, toPay))
                {
                    txtTipAmount.Text = $"{tipAmount:0.00}";
                }
            }
            catch (Exception exc)
            {
                lblNegativeError.Text = exc.Message;
            }
        }
    }
}
