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
    public class TransactionDAL : Base
    {
        private OrderDAL orderDal = new OrderDAL();
        #region Storing
        public bool AddTransaction(Transaction transaction)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO PAYMENTS (totalPrice, paymentType, tip, feedback, orderID) " +
                                                           "VALUES(@TotalPrice, @paymentType, @TipAmount, @Feedback, @OrderID)", conn);

            OpenConnection();

            cmd.Parameters.AddWithValue("@TotalPrice", transaction.TransactionDate);
            cmd.Parameters.AddWithValue("@paymentType", transaction.PaymentType);
            cmd.Parameters.AddWithValue("@TipAmount", transaction.TipAmount);
            cmd.Parameters.AddWithValue("@Feedback", transaction.Feedback);
            cmd.Parameters.AddWithValue("@OrderID", transaction.Order.OrderID);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();

            CloseConnection();
            return true;
        }
        #endregion

        #region Retrieving

        #endregion

        #region Reading
        private Transaction ReadTransaction(SqlDataReader reader)
        {
            Transaction transaction = new Transaction()
            {
                TransactionID = (int)reader["paymentID"],
                TotalPrice = (decimal)reader["totalPrice"],
                PaymentType = (string)reader["paymentType"],
                TipAmount = (decimal)reader["tip"],
                Feedback = (string)reader["feedback"],
                OrderID = (int)reader["orderID"]
            };
            return transaction;
        }

        private List<Transaction> ReadTables(DataTable dataTable)
        {
            List<Transaction> transactions = new List<Transaction>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Transaction transaction = new Transaction
                {
                    TransactionID = (int)dr["paymentID"],
                    TotalPrice = (decimal)dr["totalPrice"],
                    PaymentType = (string)dr["paymentType"],
                    TipAmount = (decimal)dr["tip"],
                    Feedback = (string)dr["feedback"],
                    OrderID = (int)dr["orderID"]
                };
                transactions.Add(transaction);
            }
            return transactions;
        }
        #endregion
    }
}
