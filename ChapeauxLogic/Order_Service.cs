using ChapeauxDAL;
using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxLogic
{
    public class Order_Service
    {
        OrderDAL orderdb;
        OrderItemDAL orderItemdb;

        public Order_Service()
        {
            orderdb = new OrderDAL();
            orderItemdb = new OrderItemDAL();
        }

        public bool getOrderForTable(int tableNumber)
        {
            return orderdb.IsThereAnOrder(tableNumber);
        }

        public Order GetByTableID(int tableID)
        {
            Order order = orderdb.GetByTableID(tableID);
            order.foodItems = orderItemdb.GetOrderFood(order.OrderID);
            order.drinkItems = orderItemdb.GetOrderDrinks(order.OrderID);

            foreach (OrderItem foodItem in order.foodItems)
            {
                order.orderItems.Add(foodItem);
            }

            foreach (OrderItem drinkItem in order.drinkItems)
            {
                order.orderItems.Add(drinkItem);
            }
            return order;
        }
    }
}
