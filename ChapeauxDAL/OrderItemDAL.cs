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
        public void UpdateOrderItemStatus(OrderItem orderItem, State status)
        {
            SqlCommand cmd = new SqlCommand("UPDATE ORDERITEMS " +
                                            "SET [state] = @state " +
                                            "WHERE orderItemID = @orderItemID; ", conn);

            OpenConnection();

            cmd.Parameters.AddWithValue("@state", status.ToString());
            cmd.Parameters.AddWithValue("@orderItemID", orderItem.OrderItemID);
            cmd.ExecuteReader();

            CloseConnection();
        }
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
        public List<OrderItem> CheckForLoadin()
        {
            string query = "SELECT DISTINCT ORDERITEMS.orderID, ORDERITEMS.[state] FROM ORDERITEMS where ORDERITEMS.state = 'loading'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrdersItems(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> Get_All_Order_Items_DB()
        {
            //read users from database
            String query = "select orderItemID, [orderID], itemID, state, comments, orderDateTime from ORDERITEMS";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadOrdersItems(ExecuteSelectQuery(query, parameters));
        }

        public Item GetOrderItemByName_DB(string name)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("select orderItemID, [orderID], itemID, state, comments, orderDateTime from ORDERITEMS where [orderID] = @orderID", conn);
            command.Parameters.AddWithValue("@orderID", name);

            SqlDataReader reader = command.ExecuteReader();

            OrderItem menuItem = null;
            if (reader.Read())
            {
                menuItem = ReadMenuItem(reader);
            }

            reader.Close();
            conn.Close();
            return menuItem;
        }
        private OrderItem ReadMenuItem(SqlDataReader reader)
        {
            OrderItem menuItem = new OrderItem()
            {   //retrieve data from all fields
                OrderItemID = (int)reader["orderItemID"],
                OrderID = (int)reader["orderID"],
                Count = (int)reader["itemID"],
                State = (State)reader["state"],
                Comment = reader["category"].ToString(),
                Course = reader["comments"].ToString(),
                OrderDateTime = (DateTime)reader["orderDateTime"]
            };
            return menuItem;
        }
        public void AddMenuOrderItem(OrderItem menuItem)
        {
            String query = "insert into ORDERITEMS values (@orderItemID, @orderID, @itemID, @state, @comments, @orderDateTime)";

            SqlParameter[] parameters = new SqlParameter[6]
            {
                    new SqlParameter("@orderItemID", menuItem.OrderItemID),
                    new SqlParameter("@orderID", menuItem.OrderID),
                    new SqlParameter("@itemID", menuItem.Count),
                    new SqlParameter("@state", menuItem.State),
                    new SqlParameter("@comments", menuItem.Comment),
                    new SqlParameter("@orderDateTime", menuItem.OrderDateTime)
            };
            ExecuteEditQuery(query, parameters);
        }

        public void EditMenuOrderItem(OrderItem lastItem, OrderItem newItem)
        {
            String query = "update ORDERITEMS set [orderItemID] = @orderItemID, orderID = @orderID, itemID = @itemID, state = @state, comments = @comments, orderDateTime = @orderDateTIme where [orderItemID] = @orderItemID";

            SqlParameter[] parameters = new SqlParameter[6]
            {
                new SqlParameter("@orderItemID", lastItem.OrderItemID),
                new SqlParameter("@orderID", lastItem.OrderID),
                new SqlParameter("@itemID", lastItem.Count),
                new SqlParameter("@state", lastItem.State),
                new SqlParameter("@comments", lastItem.Comment),
                new SqlParameter("@orderDateTime", lastItem.OrderDateTime)
            };
            ExecuteEditQuery(query, parameters);
        }
        private List<OrderItem> ReadOrdersItems(DataTable dataTable)
        {
            List<OrderItem> orderitems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderitem = new OrderItem()
                {
                    OrderItemID = (int)dr["orderItemID"],
                    OrderID = (int)dr["orderID"],
                    Count = (int)dr["itemID"],
                    State = (State)dr["state"],
                    Comment = dr["comments"].ToString(),
                    OrderDateTime = (DateTime)dr["orderDateTime"]
                };

                orderitems.Add(orderitem);
            }
            return orderitems;
        }
        

        #region Checkout
        public List<OrderItem> GetOrderFood(int orderID)
        {
            string query = "SELECT ORDERITEMS.orderItemID, ORDERITEMS.orderID, ORDERITEMS.[count], ORDERITEMS.itemID, ORDERITEMS.orderDateTime, ITEMS.[name], ITEMS.category, ITEMS.price, ITEMS.VATRate, ORDERITEMS.state, ORDERITEMS.comments " +
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
            string query = "SELECT ORDERITEMS.orderItemID, ORDERITEMS.orderID, ORDERITEMS.[count], ORDERITEMS.itemID, ORDERITEMS.orderDateTime, ITEMS.[name], ITEMS.category, ITEMS.price, ITEMS.VATRate, ORDERITEMS.state, ORDERITEMS.comments " +
                            "FROM ORDERITEMS " +
                            "INNER JOIN ORDERS ON ORDERS.orderID = ORDERITEMS.orderID " +
                            "INNER JOIN ITEMS ON ITEMS.itemID = ORDERITEMS.itemID " +
                            "WHERE ITEMS.category = 'Drink'" +
                            "AND ORDERITEMS.orderID = @orderID " +
                            "ORDER BY ITEMS.[itemID]";
            SqlParameter[] sqlParameters = {
                 new SqlParameter("@orderID", orderID),
            };
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderItem> GetLoadingFoodItems()
        {
            string query = "SELECT ORDERITEMS.orderItemID, ORDERITEMS.orderID, ORDERITEMS.[count], ORDERITEMS.itemID, ORDERITEMS.orderDateTime, ITEMS.[name], ITEMS.category, ITEMS.price, ITEMS.VATRate, ORDERITEMS.state, ORDERITEMS.comments " +
                           "FROM ORDERITEMS " +
                           "INNER JOIN ORDERS ON ORDERS.orderID = ORDERITEMS.orderID " +
                           "INNER JOIN ITEMS ON ITEMS.itemID = ORDERITEMS.itemID " +
                           "WHERE(ITEMS.category = 'Lunch' OR ITEMS.category = 'Dinner') " +
                           "AND ORDERITEMS.[state] = 'loading' " +
                           "ORDER BY ORDERITEMS.orderDateTime";
            SqlParameter[] sqlParameters = {
                 
            };
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderItem> GetLoadingDrinkItems()
        {
            string query = "SELECT ORDERITEMS.orderItemID, ORDERITEMS.orderID, ORDERITEMS.[count], ORDERITEMS.itemID, ORDERITEMS.orderDateTime, ITEMS.[name], ITEMS.category, ITEMS.price, ITEMS.VATRate, ORDERITEMS.state, ORDERITEMS.comments " +
                           "FROM ORDERITEMS " +
                           "INNER JOIN ORDERS ON ORDERS.orderID = ORDERITEMS.orderID " +
                           "INNER JOIN ITEMS ON ITEMS.itemID = ORDERITEMS.itemID " +
                           "WHERE ITEMS.category = 'Drink' " +
                           "AND ORDERITEMS.[state] = 'loading' " +
                           "ORDER BY ORDERITEMS.orderDateTime";
            SqlParameter[] sqlParameters = {
               
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
                    OrderItemID = (int)dr["orderItemID"],
                    OrderID = (int)dr["orderID"],
                    ItemID = (int)dr["itemID"],
                    Count = (int)dr["count"],
                    Name = (string)dr["name"],
                    OrderDateTime = (DateTime)dr["orderDateTime"],
                    Category = (string)dr["category"],
                    Price = (decimal)dr["price"],
                    VATRate = (decimal)dr["VATRate"],
                    State = (State)Enum.Parse(typeof(State), dr["state"].ToString()),
                    Comment = (string)dr["comments"]
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
            SqlCommand cmd = new SqlCommand("INSERT INTO ORDERITEMS (orderID, itemID, [state], [count],comments, orderDateTime)" +
                                            "VALUES (@orderID, @itemID, @state, @count, @comment, @dateTime)", conn);

            OpenConnection();

            cmd.Parameters.AddWithValue("@orderID", orderItem.OrderID);
            cmd.Parameters.AddWithValue("@itemID", orderItem.ItemID);
            cmd.Parameters.AddWithValue("@state", orderItem.State.ToString());
            cmd.Parameters.AddWithValue("@count", orderItem.Count);
            cmd.Parameters.AddWithValue("@comment", orderItem.Comment);
            cmd.Parameters.AddWithValue("@dateTime", orderItem.OrderDateTime);
            SqlDataReader reader = cmd.ExecuteReader();

            CloseConnection();
        }
    }
}
