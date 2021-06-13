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
    public partial class Receipt : Form
    {
        public Receipt(Transaction transaction)
        {
            InitializeComponent();
            PrintReceipt(transaction);
        }

        private void PrintReceipt(Transaction transaction)
        {
            listViewReceipt.Items.Clear();
            foreach (OrderItem orderItem in transaction.Order.OrderItems)
            {
                ListViewItem li = new ListViewItem($"{orderItem.Name}  (X{orderItem.Count})");
                li.SubItems.Add($"{(orderItem.Price * orderItem.Count):0.00}  ");
                listViewReceipt.Items.Add(li);
            }

            lblOrderDate.Text = $"{transaction.Order.EndDateTime:dd/MM/yyyy HH:mm}";
            lblTotalWTip.Text = $"€ {(transaction.TotalPrice + transaction.TipAmount):0.00}";
            lblTotal.Text = $"{transaction.TotalPrice:0.00}";
            lblTipAmount.Text = $"{transaction.TipAmount:0.00}";
            lblPaymentMethod.Text = $"{transaction.PaymentType}";
            lblTotalVAT.Text = $"€ {transaction.VAT:0.00}";
            lblVATHigh.Text = $"€ {transaction.Order.VATHigh:0.00}";
            lblVATLow.Text = $"€ {transaction.Order.VATLow:0.00}";
            lblComment.Text = transaction.Feedback;
        }
    }
}
