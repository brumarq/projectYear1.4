using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxModel
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentType { get; set; }
        public decimal TipAmount { get; set; }
        public string Feedback { get; set; }
        public string OrderID { get; set; }
    }
}
