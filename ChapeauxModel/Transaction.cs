using System;

namespace ChapeauxModel
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentType { get; set; }
        public decimal TipAmount { get; set; }
        public string Feedback { get; set; }
        public DateTime TransactionDate { get; set; }
        public Order Order { get; set; }
    }
}
