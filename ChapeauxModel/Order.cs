using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxModel
{
    public class Order
    {
        public List<OrderItem> orderItems;

        public int OrderID { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime endDateTime { get; set; }
        public bool IsPaid { get; set; }
        public int TableID { get; set; }
        public int UserID { get; set; }
        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 150;
                foreach (OrderItem orderItem in orderItems)
                {
                    totalPrice += orderItem.Price;
                }
                return totalPrice;
            }
        }
        public decimal VATHigh
        {
            get
            {
                decimal vatHighResult = 0;
                foreach (OrderItem orderItem in orderItems)
                {
                    if (orderItem.VATRate == 0.21m)
                    {
                        vatHighResult += orderItem.Price / 121 * 21;
                    }
                }
                return vatHighResult;
            }
        }

        public decimal VATLow
        {
            get
            {
                decimal vatLowResult = 0;
                foreach (OrderItem orderItem in orderItems)
                {
                    if (orderItem.VATRate == 0.09m)
                    {
                        vatLowResult += orderItem.Price / 109 * 9;
                    }
                }
                return vatLowResult;
            }
        }

        public Order()
        {
            orderItems = new List<OrderItem>();
        }
    }
}
