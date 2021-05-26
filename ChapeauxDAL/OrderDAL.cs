using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauxModel;

namespace ChapeauxDAL
{
    public class OrderDAL : Base
    {
        #region Reading
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

        #region Storing

        #endregion

        #region Retrieving
        //(needed for transactions) please leave this method as it is
        public Order GetByID(int orderID)
        {
            SqlCommand cmd = new SqlCommand("SELECT orderID, isPaid, tableID, userID " +
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
        #endregion
    }
}
