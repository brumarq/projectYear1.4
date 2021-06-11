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
        private Transaction transaction;
        private decimal toPay;              //for processing cash
        private decimal receivedCash;       //      +
        private decimal totalReceivedCash;  //      +
        private decimal changeToGive;       //bills and coins

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
            transaction.Order = GetOrder(currentTable);
            ShowCurrentOrder(transaction.Order);
            btnFinishPayment.Enabled = false;
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
            subPnlCard.Hide();
        }
        #endregion

        #region PanelSelection
        private void ShowPanel(string panelName)
        {
            //Hide panels
            HideAllPanels();

            //show requested panel
            if (panelName == "Checkout")
                pnlCheckout.Show();

            else if (panelName == "Payment")
            {
                pnlPayment.Show();
                subPnlCash.Show();
            }

            else if (panelName == "Overview")
                pnlPaymentOverview.Show();
        }
        #endregion

        //Panels
        #region Checkout
        #region Events
        private void btnClearTip_Click(object sender, EventArgs e)
        {
            transaction.TipAmount = 0.0m;
            txtTipAmount.Text = $"{transaction.TipAmount:0.00}";
            txtToPay.Text = $"{transaction.Order.TotalPrice:0.00}";
        }

        private void btnToPayment_Click(object sender, EventArgs e)
        {
            ShowPanel("Payment");
            toPay = Convert.ToDecimal(txtToPay.Text);

            //cash
            lblToPayCash.Text = toPay.ToString();
            totalReceivedCash = 0;
            lblReceivedCash.Text = totalReceivedCash.ToString();
            changeToGive = 0;
            lblChangeToGive.Text = changeToGive.ToString();
            transaction.PaymentType = PaymentType.Cash;

            //card
            lblToPayByCard.Text = toPay.ToString();
            lblCardPaymentStatus.ForeColor = Color.Red;
            lblCardPaymentStatus.Text = "NOT PAID";
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
                decimal tipAmount = toPay - transaction.Order.TotalPrice;

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
        #endregion
        #region Methods
        private bool CheckForNegative(decimal tipAmount, decimal toPay)
        {
            //if (tipAmount < 0)
            //{
            //    txtTipAmount.Text = 
            //    throw new Exception("Negative values are not allowed!");
            //}

            if (toPay < transaction.Order.TotalPrice)
            {
                txtToPay.Text = $"{transaction.Order.TotalPrice:0.00}";
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
                foreach (OrderItem orderItem in transaction.Order.orderItems)
                {
                    ListViewItem li = new ListViewItem(orderItem.ItemID.ToString(), 0);
                    li.SubItems.Add(orderItem.Name);
                    li.SubItems.Add(orderItem.Count.ToString());
                    li.SubItems.Add(orderItem.Price.ToString("0.00"));
                    listViewCheckoutOrder.Items.Add(li);
                }

                lblCheckoutOrderID.Text = $"#{transaction.Order.OrderID}";
                lblTotalResult.Text = $"{transaction.Order.TotalPrice: 0.00}";
                lblVATHighResult.Text = $"{transaction.Order.VATHigh: 0.00}";
                lblVATLowResult.Text = $"{transaction.Order.VATLow: 0.00}";
                txtTipAmount.Text = $"{transaction.TipAmount: 0.00}";
                txtToPay.Text = $"{transaction.Order.TotalPrice: 0.00}";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion
        #endregion

        #region Payment
        #region Events
        //Navigation
        private void btnBackToCheckout_Click(object sender, EventArgs e)
        {
            ShowPanel("Checkout");
        }

        private void btnFinishPayment_Click(object sender, EventArgs e)
        {
            transaction.TotalPrice = Convert.ToDecimal(lblTotalResult.Text);
            transaction.TipAmount = Convert.ToDecimal(txtTipAmount.Text);
            transaction.Feedback = txtFeedback.Text;
            transaction.Order.endDateTime = DateTime.Now;
            transaction.TransactionDate = DateTime.Now;
            transaction.VAT = transaction.Order.VATHigh + transaction.Order.VATLow;

            Transaction_Service transactionService = new Transaction_Service();
            transactionService.AddTransaction(transaction);

            ShowPanel("Overview");
            LoadPaymentOverView();
        }

        //Cash
        private void btnCash_Click(object sender, EventArgs e)
        {
            btnCash.Enabled = false;
            btnCard.Enabled = true;
            subPnlCard.Hide();
            subPnlCash.Show();
            transaction.PaymentType = PaymentType.Cash;
        }

        private void btn5eu_Click(object sender, EventArgs e)
        {
            receivedCash = 5.00m;
            ProcessReceivedCash(receivedCash);
        }

        private void btn10eu_Click(object sender, EventArgs e)
        {
            receivedCash = 10.00m;
            ProcessReceivedCash(receivedCash);
        }

        private void btn20eu_Click(object sender, EventArgs e)
        {
            receivedCash = 20.00m;
            ProcessReceivedCash(receivedCash);
        }

        private void btn50eu_Click(object sender, EventArgs e)
        {
            receivedCash = 50.00m;
            ProcessReceivedCash(receivedCash);
        }

        private void btn100eu_Click(object sender, EventArgs e)
        {
            receivedCash = 100.00m;
            ProcessReceivedCash(receivedCash);
        }

        private void btn200eu_Click(object sender, EventArgs e)
        {
            receivedCash = 200.00m;
            ProcessReceivedCash(receivedCash);
        }

        private void btn2eu_Click(object sender, EventArgs e)
        {
            receivedCash = 2.00m;
            ProcessReceivedCash(receivedCash);
        }

        private void btn1eu_Click(object sender, EventArgs e)
        {
            receivedCash = 1.00m;
            ProcessReceivedCash(receivedCash);
        }

        private void btn50cent_Click(object sender, EventArgs e)
        {
            receivedCash = 0.50m;
            ProcessReceivedCash(receivedCash);
        }

        private void btn20cent_Click(object sender, EventArgs e)
        {
            receivedCash = 0.20m;
            ProcessReceivedCash(receivedCash);
        }

        private void btn10cent_Click(object sender, EventArgs e)
        {
            receivedCash = 0.10m;
            ProcessReceivedCash(receivedCash);
        }

        private void btn5cent_Click(object sender, EventArgs e)
        {
            receivedCash = 0.05m;
            ProcessReceivedCash(receivedCash);
        }

        private void btnResetCash_Click(object sender, EventArgs e)
        {
            totalReceivedCash = 0;
            changeToGive = 0;
            ProcessReceivedCash(0);
        }

        //Card
        private void btnCard_Click(object sender, EventArgs e)
        {
            btnCard.Enabled = false;
            btnCash.Enabled = true;
            subPnlCash.Hide();
            subPnlCard.Show();
            lblPaymentMethod.Text = "";
        }

        private void btnMaestro_Click(object sender, EventArgs e)
        {
            transaction.PaymentType = PaymentType.Maestro;
            lblPaymentMethod.Text = transaction.PaymentType.ToString();
        }

        private void btnMasterCard_Click(object sender, EventArgs e)
        {
            transaction.PaymentType = PaymentType.MasterCard;
            lblPaymentMethod.Text = transaction.PaymentType.ToString();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            transaction.PaymentType = PaymentType.VISA;
            lblPaymentMethod.Text = transaction.PaymentType.ToString();
        }

        private void btnAmex_Click(object sender, EventArgs e)
        {
            transaction.PaymentType = PaymentType.AMEX;
            lblPaymentMethod.Text = transaction.PaymentType.ToString();
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            lblCardPaymentStatus.ForeColor = Color.Orange;
            lblCardPaymentStatus.Text = "PENDING";

            DialogResult result = MessageBox.Show("Was the payment successful?", "Perform/Decline Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                transaction.Order.IsPaid = true;
                transaction.State = PaymentState.Received;
                DisablePaymentButtons();
                lblCardPaymentStatus.ForeColor = Color.DarkGreen;
                lblCardPaymentStatus.Text = "PAID";
                btnFinishPayment.Enabled = true;
            }

            else
            {
                transaction.State = PaymentState.Failed;
                MessageBox.Show("ERROR: Payment Declined!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblCardPaymentStatus.ForeColor = Color.Red;
                lblCardPaymentStatus.Text = "NOT PAID";
            }

        }
        #endregion
        #region Methods
        //Cash
        private void ProcessReceivedCash(decimal received)
        {
            totalReceivedCash += received;

            if (toPay <= 0)
            {
                btnFinishPayment.Enabled = true;
            }

            if (totalReceivedCash > toPay)
            {
                changeToGive = totalReceivedCash - toPay;
            }

            lblToPayCash.Text = toPay.ToString();
            lblReceivedCash.Text = totalReceivedCash.ToString();
            lblChangeToGive.Text = changeToGive.ToString();
        }

        //Card
        private void DisablePaymentButtons()
        {
            btnCash.Enabled = false;
            btnMaestro.Enabled = false;
            btnMasterCard.Enabled = false;
            btnVisa.Enabled = false;
            btnAmex.Enabled = false;
            btnPayNow.Enabled = false;
            btnBackToCheckout.Enabled = false;
        }
        #endregion
        #endregion

        #region PaymentOverview
        private void btnBackToPayment_Click(object sender, EventArgs e)
        {
            ShowPanel("Payment");
            if (transaction.Order.IsPaid && transaction.PaymentType != PaymentType.Cash)
                subPnlCard.Show();
        }

        private void LoadPaymentOverView()
        {
            FillListViewOverview();

        }

        private void FillListViewOverview()
        {
            
        }

        //*** add method to load listview of transaction/order
        //*** add option to write and store comments: popup + open digital keyboard + store comment into order

        private void btnCloseOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Free Up Table?", "Set Table Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Table_Service tableService = new Table_Service();
                tableService.UpdateStatus(currentTable.TableID, Status.Free);

            }
            this.Close();
        }
        #endregion


    }
}
