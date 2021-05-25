using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxModel
{
    public class Order
    {
        private List<OrderItem> orderItems;

        public int OrderID { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime endDateTim { get; set; }
        public bool IsPaid { get; set; }
        public int TableID { get; set; }
        public int UserID { get; set; }


        public Order()
        {
            orderItems = new List<OrderItem>();
        }
    }
}
