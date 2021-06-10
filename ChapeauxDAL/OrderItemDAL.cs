using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxDAL
{
    public class OrderItemDAL : Base
    {
        public List<OrderItem> GetDrinksStatus(int tableNumber)
        {
            string query = "SELECT ORDERITEMS.state FROM ORDERITEMS INNER JOIN ORDERS ON ORDERS.orderID = ORDERITEMS.orderID INNER JOIN ITEMS ON ITEMS.itemID = ORDERITEMS.itemID WHERE ITEMS.category = 'Drink' AND ORDERS.tableID = @tableID AND ORDERs.isPaid = 0; ";
            SqlParameter[] sqlParameters = {
                 new SqlParameter("@tableID", tableNumber),
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderItem> GetFoodStatus(int tableNumber)
        {
            string query = "SELECT ORDERITEMS.state, ORDERS.orderID, ORDERS.tableID FROM ORDERITEMS INNER JOIN ORDERS ON ORDERS.orderID = ORDERITEMS.orderID INNER JOIN ITEMS ON ITEMS.itemID = ORDERITEMS.itemID WHERE (ITEMS.category = 'Lunch' OR ITEMS.category = 'Dinner') AND ORDERS.tableID=@tableID AND ORDERs.isPaid = 0;";
            SqlParameter[] sqlParameters = {
                 new SqlParameter("@tableID", tableNumber),
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        #region Checkout
        public List<OrderItem> GetOrderFood(int orderID)
        {
            string query = "SELECT ORDERITEMS.orderID, ORDERITEMS.itemID, ORDERITEMS.[count], ITEMS.[name], ITEMS.category, ITEMS.price, ITEMS.VATRate " +
                            "FROM ORDERITEMS " +
                            "INNER JOIN ORDERS ON ORDERS.orderID = ORDERITEMS.orderID " +
                            "INNER JOIN ITEMS ON ITEMS.itemID = ORDERITEMS.itemID " +
                            "WHERE (ITEMS.category = 'Lunch' OR ITEMS.category = 'Dinner') " +
                            "AND ORDERITEMS.orderID = @orderID " +
                            "ORDER BY ITEMS.[itemID]";
            SqlParameter[] sqlParameters = {
                 new SqlParameter("@orderID", orderID),
            };
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderItem> GetOrderDrinks(int orderID)
        {
            string query = "SELECT ORDERITEMS.orderID, ORDERITEMS.itemID, ORDERITEMS.[count], ITEMS.[name], ITEMS.category, ITEMS.price, ITEMS.VATRate " +
                            "FROM ORDERITEMS " +
                            "INNER JOIN ORDERS ON ORDERS.orderID = ORDERITEMS.orderID " +
                            "INNER JOIN ITEMS ON ITEMS.itemID = ORDERITEMS.itemID " +
                            "WHERE ITEMS.category = 'Drink' " +
                            "AND ORDERITEMS.orderID = @orderID " +
                            "ORDER BY ITEMS.[itemID]";
            SqlParameter[] sqlParameters = {
                 new SqlParameter("@orderID", orderID),
            };
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadOrderItems(DataTable dataTable)
        {
            List<OrderItem> listOfItems = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                     OrderID = (int)dr["orderID"],
                     ItemID = (int)dr["itemID"],
                     Count = (int)dr["count"],
                     Name = (string)dr["name"],
                     Category = (string)dr["category"],
                     Price = (decimal)dr["price"],
                     VATRate = (decimal)dr["VATRate"]                      
                };

                listOfItems.Add(orderItem);
            }

            return listOfItems;
        }
        #endregion

        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            List<OrderItem> listOfItems = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    State = (State)Enum.Parse(typeof(State), dr["state"].ToString()),
                };

                listOfItems.Add(orderItem);
            }

            return listOfItems;
        }

        public void AddItemToOrder(OrderItem orderItem)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ORDERITEMS (orderID, itemID, [count], [state], comments, orderDateTime)" +
                                            "VALUES (@orderID, @itemID, @count, @state, @comment, @dateTime)", conn);

            OpenConnection();

            cmd.Parameters.AddWithValue("@orderID", orderItem.OrderID);
            cmd.Parameters.AddWithValue("@itemID", orderItem.ItemID);
            cmd.Parameters.AddWithValue("@count", orderItem.Count);
            cmd.Parameters.AddWithValue("@state", orderItem.State.ToString());
            cmd.Parameters.AddWithValue("@comment", orderItem.Comment);
            cmd.Parameters.AddWithValue("@dateTime", orderItem.orderDateTime);
            SqlDataReader reader = cmd.ExecuteReader();

            CloseConnection();
        }
    }
}
