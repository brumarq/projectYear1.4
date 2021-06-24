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
        public List<Order> GetOrders()
        {
            return orderdb.GetAllOrders();
        }

        public bool tableContainsOrder(int tableNumber)
        {
            return orderdb.IsThereAnOrder(tableNumber);
        }

        public void AddNewOrder(Order order)
        {
            orderdb.AddNewOrder(order);
        }

        public void DeleteOrder(Order order)
        {
            orderdb.DeleteOrder(order);
        }
        public Order GetOrderByID(int orderid)
        {
            return orderdb.GetByID(orderid);
        }

        public Order GetByTableID(int tableID)
        {
            Order order = orderdb.GetByTableID(tableID);

            if (order == null)
            {
                return null;
            }

            order.FoodItems = orderItemdb.GetOrderFood(order.OrderID);
            order.DrinkItems = orderItemdb.GetOrderDrinks(order.OrderID);

            foreach (OrderItem foodItem in order.FoodItems)
            {
                order.OrderItems.Add(foodItem);
            }

            foreach (OrderItem drinkItem in order.DrinkItems)
            {
                order.OrderItems.Add(drinkItem);
            }
            return order;
        }
    }
}
