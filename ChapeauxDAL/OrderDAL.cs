﻿using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxDAL
{
    public class OrderDAL : Base
    {
        #region Reading
        
        private bool ReadTables(DataTable dataTable)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                return true;
            }

            return false;
        }
        public bool IsThereAnOrder(int tableNumber)
        {
            string query = "SELECT tableID FROM ORDERS WHERE tableID=@tableID AND isPaid=0";
            SqlParameter[] sqlParameters = {
                 new SqlParameter("@tableID", tableNumber),
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private Order ReadOrder(SqlDataReader reader)
        {
            Order order = new Order()
            {
                OrderID = (int)reader["orderID"],
                startDateTime = (DateTime)reader["startDateTime"],
                endDateTime = (DateTime)reader["endDateTime"],
                IsPaid = (bool)reader["isPaid"],
                TableID = (int)reader["tableID"],
                UserID = (int)reader["userID"]
            };
            return order;
        }
        #endregion

        #region Updating
        public void UpdateOrderIsPaid(Order order)
        {
            SqlCommand cmd = new SqlCommand("UPDATE ORDERS " +
                                            "SET isPaid = @isPaid, endDateTime = @endDateTime " +
                                            "WHERE orderID = @orderID", conn);

            OpenConnection();
            cmd.Parameters.AddWithValue("@isPaid", order.IsPaid);
            cmd.Parameters.AddWithValue("@endDateTime", order.endDateTime);
            cmd.Parameters.AddWithValue("@orderID", order.OrderID);
            SqlDataReader reader = cmd.ExecuteReader();
        }

        public void DeleteOrder(Order order)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM ORDERS WHERE orderID=@orderID;", conn);

            OpenConnection();

            cmd.Parameters.AddWithValue("@orderID", order.OrderID.ToString());
            cmd.ExecuteReader();

            CloseConnection();
        }

        public void AddNewOrder(Order order)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ORDERS (startDateTime, endDateTime, isPaid, tableID, userID) " +
                                            "VALUES(@startDateTime, @endDateTime, @isPaid, @tableID, @userID)", conn);

            OpenConnection();
            cmd.Parameters.AddWithValue("@startDateTime", DateTime.Now);
            cmd.Parameters.AddWithValue("@endDateTime", (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue);
            cmd.Parameters.AddWithValue("@isPaid", false);
            cmd.Parameters.AddWithValue("@tableID", order.TableID);
            cmd.Parameters.AddWithValue("@userID", order.UserID);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            CloseConnection();
        }
        #endregion

        #region Retrieving
        public Order GetByID(int orderID)
        {
            SqlCommand cmd = new SqlCommand("SELECT orderID, isPaid, tableID, userID, startDateTime, endDateTime " +
                                            "FROM ORDERS " +
                                            "WHERE orderID = @orderID", conn);

            OpenConnection();
            cmd.Parameters.AddWithValue("@orderID", orderID);
            SqlDataReader reader = cmd.ExecuteReader();
            Order order = null;

            if (reader.Read())
            {
                order = ReadOrder(reader);
            }
            reader.Close();
            conn.Close();

            return order;
        }

        public Order GetByTableID(int tableID)
        {
            SqlCommand cmd = new SqlCommand("SELECT orderID, startDateTime, endDateTime, isPaid, tableID, userID " +
                                            "FROM ORDERS " +
                                            "WHERE tableID = @tableID AND isPaid = 0", conn);
            OpenConnection();
            cmd.Parameters.AddWithValue("@tableID", tableID);
            SqlDataReader reader = cmd.ExecuteReader();

            Order order = null;
            if (reader.Read())
            {
                order = ReadOrder(reader);
            }
            reader.Close();
            conn.Close();

            return order;
        }
        #endregion

     
        public List<Order> GetAllOrders()
        {
            string query = "SELECT orderID, startDateTime, endDateTime, isPaid, tableID, userID FROM ORDERS";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }
#region GetFoodAndDrinks
        public List<Order> GetFoodOrders()
        {
            string query = "SELECT orderID, startDateTime, endDateTime, isPaid, tableID, userID FROM ORDERS WHERE isPaid=0 ORDER BY startDateTime";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> GetDrinkOrders()
        {
            string query = "SELECT orderID, startDateTime, endDateTime, isPaid, tableID, userID FROM ORDERS WHERE ispaid=0 ORDER BY startDateTIme";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> ReadTable(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderID = (int)dr["orderID"],
                    startDateTime = (DateTime)dr["startDateTime"],
                    endDateTime = (DateTime)dr["endDateTime"],
                    IsPaid = (bool)dr["isPaid"],
                    TableID = (int)dr["tableID"],
                    UserID = (int)dr["userID"]
                };
                orders.Add(order);
            }
            return orders;
        }
#endregion
    }
}
