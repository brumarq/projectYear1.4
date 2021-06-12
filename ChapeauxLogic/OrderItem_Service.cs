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
        public List<OrderItem> GetItems()
        {
            return orderItemdb.Get_All_Order_Items_DB();
        }
        public List<OrderItem> getDrinksStatus(int tableNumber)
        {
            return orderItemdb.GetDrinksStatus(tableNumber);
        }

        public List<OrderItem> getFoodStatus(int tableNumber)
        {
            return orderItemdb.GetFoodStatus(tableNumber);
        }
        #region GetFood/Drink
        public List<OrderItem> GetFoodItems(int orderID)
        {
            return orderItemdb.GetOrderFood(orderID);
        }

        public List<OrderItem> GetDrinkItems(int orderID)
        {
            return orderItemdb.GetOrderDrinks(orderID);
        }
        #endregion
    }
}
