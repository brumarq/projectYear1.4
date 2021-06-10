using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxModel
{
    public enum PaymentType { Cash, Maestro, MasterCard, VISA, AMEX}
    public enum PaymentState { Received, Failed}

    public class Transaction
    {
        public int TransactionID { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentType PaymentType { get; set; }
        public PaymentState State { get; set; }
        public decimal TipAmount { get; set; }
        public string Feedback { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal VAT { get; set; }
        public Order Order { get; set; }
    }
}
