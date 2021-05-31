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

        public CheckoutForm(Table currentTable)
        {
            this.currentTable = currentTable;
            InitializeComponent();
            GetOrder();
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
            txtTipAmount.Clear();
        }

        private void btnToPayment_Click(object sender, EventArgs e)
        {
            ShowPanel("Payment");
        }

        private void txtTipAmount_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtTipAmount.Text) >= 0)
            {
                txtToPay.Text = (currentOrder.TotalPrice + Convert.ToDecimal(txtTipAmount.Text).ToString());
            }

            else if (Convert.ToDecimal(txtToPay.Text) >= currentOrder.TotalPrice)
            {
                txtTipAmount.Text = (Convert.ToDecimal(txtToPay.Text) - currentOrder.TotalPrice).ToString();
            }
            else
            {
                throw new Exception("Price to pay cannot be less than total order price");
            }
        }

        //Methods
        private void GetOrder()
        {
            try
            {
                listViewCheckoutOrder.Clear();

                Order_Service orderService = new Order_Service();

                currentOrder = null;
                if (orderService.getOrderForTable(currentTable.TableID))
                {
                    currentOrder = orderService.GetByTableID(currentTable.TableID);
                }

                else
                {
                    throw new Exception("There are no open orders for this table");
                }
               
                //NULL REFERENCE?

                foreach (OrderItem orderItem in currentOrder.orderItems)
                {
                    ListViewItem li = new ListViewItem(orderItem.ItemID.ToString(), 0);
                    li.SubItems.Add(orderItem.Name);
                    li.SubItems.Add(orderItem.Count.ToString());
                    li.SubItems.Add(orderItem.Price.ToString());
                    listViewCheckoutOrder.Items.Add(li);
                }

                lblCheckoutOrderID.Text = currentOrder.OrderID.ToString();
                lblTotalResult.Text = currentOrder.TotalPrice.ToString();
                lblVATHighResult.Text = currentOrder.VATHigh.ToString();
                lblVATLowResult.Text = currentOrder.VATLow.ToString();

                //TEXBOX TextChanged EVENT!!!!!! ---> DONE, REMOVE COMMENTS IF WORKS...

                //decimal toPay = currentOrder.TotalPrice + Convert.ToDecimal(txtTipAmount);
                //decimal tipAmount = Convert.ToDecimal(txtToPay) - currentOrder.TotalPrice;
                //if (Convert.ToDecimal(txtToPay) < currentOrder.TotalPrice)
                //{
                //    throw new Exception("Price to pay cannot be lower than the total price");
                //}

                //else if ()
                //{

                //}
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
