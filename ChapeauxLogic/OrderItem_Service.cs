using ChapeauxDAL;
using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxLogic
{
    public class OrderItem_Service
    {
        OrderItemDAL orderItemdb;

        public OrderItem_Service()
        {
            orderItemdb = new OrderItemDAL();

        }

        public List<OrderItem> getDrinksStatus(int tableNumber)
        {
            return orderItemdb.GetDrinksStatus(tableNumber);
        }

        public List<OrderItem> getFoodStatus(int tableNumber)
        {
            return orderItemdb.GetFoodStatus(tableNumber);
        }
    }
}
