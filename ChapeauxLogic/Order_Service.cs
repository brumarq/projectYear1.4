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

        //public void UpdateIsPaid(Order orderID)
        //{
        //    orderdb.UpdateOrderIsPaid(order);
        //}
        
        public Order_Service()
        {
            orderdb = new OrderDAL();
            orderItemdb = new OrderItemDAL();
        }

        public bool tableContainsOrder(int tableNumber)
        {
            return orderdb.IsThereAnOrder(tableNumber);
        }
        #region GetFood And Drinks Orders
        public List<Order> GetFoodOrders()
        {
            List<Order> foodorders = orderdb.GetFoodOrders();
            for (int i = 0; i < foodorders.Count; i++)
            {
                foodorders[i].orderItems = orderItemdb.GetOrderFood(foodorders[i].OrderID);
                for (int j = 0; j < foodorders[i].orderItems.Count; j++)
                {
                    if (foodorders[i].orderItems[j].State == State.loading)
                    {
                        continue;
                    }
                    else
                    {
                        foodorders.Remove(foodorders[i]);
                    }
                }
               
            }

            return foodorders;

        }
        public List<Order> GetDrinkOrders()
        {
            List<Order> drinkorder = orderdb.GetDrinkOrders();
            for (int i = 0; i < drinkorder.Count; i++)
            {
                drinkorder[i].orderItems = orderItemdb.GetOrderDrinks(drinkorder[i].UserID);
                for (int j = 0; j < drinkorder[i].orderItems.Count; j++)
                {
                    if (drinkorder[i].orderItems[j].State == State.loading)
                    {
                        continue;
                    }
                    else
                    {
                        drinkorder.Remove(drinkorder[i]);
                    }
                }
            }
            return drinkorder;
        }
        #endregion

        public void AddNewOrder(Order order)
        {
            orderdb.AddNewOrder(order);
        }

        public void DeleteOrder(Order order)
        {
            orderdb.DeleteOrder(order);
        }

        public Order GetByTableID(int tableID)
        {
            Order order = orderdb.GetByTableID(tableID);

            if (order == null)
            {
                return null;
            }

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
