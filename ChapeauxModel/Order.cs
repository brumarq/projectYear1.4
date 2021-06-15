using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxModel
{
    public class Order
    {
        public List<OrderItem> OrderItems { get; set; } //To seperate food and drinks within the listview
        public List<OrderItem> FoodItems { get; set; }
        public List<OrderItem> DrinkItems { get; set; }

        public int OrderID { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public bool IsPaid { get; set; }
        public int TableID { get; set; }
        public int UserID { get; set; }
        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;

                foreach (OrderItem orderItem in OrderItems)
                {
                    
                    totalPrice += (orderItem.Price * orderItem.Count);
                }

                return totalPrice;
            }
        }
        public decimal VATHigh
        {
            get
            {
                decimal vatHighResult = 0;
                
                    foreach (OrderItem orderItem in OrderItems)
                    {
                        if (orderItem.VATRate == 0.21m)
                        {
                            vatHighResult += orderItem.Price * orderItem.Count / 121 * 21;
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
              
                    foreach (OrderItem orderItem in OrderItems)
                    {
                        if (orderItem.VATRate == 0.09m)
                        {
                            vatLowResult += orderItem.Price * orderItem.Count / 109 * 9;
                        }
                    }
                
                return vatLowResult;
            }
        }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
    }
}
