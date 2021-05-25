using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxModel
{
    public class OrderItem : Item
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int Count { get; set; }
        public string State { get; set; }
        public string Comment { get; set; }
        public DateTime orderDateTime { get; set; }

        public OrderItem()
        {
            OrderItemID = ItemID; //from base
        }
    }
}
