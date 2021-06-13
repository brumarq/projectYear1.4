﻿using ChapeauxDAL;
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
        public void UpdateOrderItemStatus(OrderItem orderItem, State status)
        {
            orderItemdb.UpdateOrderItemStatus(orderItem, status);
        }

        public void AddItemToOrder(OrderItem orderItem)
        {
            orderItemdb.AddItemToOrder(orderItem);
        }

        public List<OrderItem> getDrinksStatus(int tableNumber)
        {
            return orderItemdb.GetDrinksStatus(tableNumber);
        }

        public List<OrderItem> getFoodStatus(int tableNumber)
        {
            return orderItemdb.GetFoodStatus(tableNumber);
        }

        public List<Tuple<OrderItem, Order>> GetAllDrinksStatus()
        {
            return orderItemdb.GetAllDrinksStatus();
        }

        public List<Tuple<OrderItem, Order>> GetAllFoodStatus()
        {
            return orderItemdb.GetAllFoodStatus();
        }


        public List<OrderItem> GetFoodItems(int orderID)
        {
            return orderItemdb.GetOrderFood(orderID);
        }

        public List<OrderItem> GetDrinkItems(int orderID)
        {
            return orderItemdb.GetOrderDrinks(orderID);
        }
    }
}
