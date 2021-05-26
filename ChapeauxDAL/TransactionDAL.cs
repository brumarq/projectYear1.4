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
        private List<Transaction> ReadTables(DataTable dataTable)
        {
            List<Transaction> transactions = new List<Transaction>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int orderID = (int)dr["orderID"];

                Order order = orderDal.GetByID(orderID);

                Transaction transaction = new Transaction
                {
                    TransactionID = (int)dr["paymentID"],
                    TotalPrice = (decimal)dr["totalPrice"],
                    PaymentType = (string)dr["paymentType"],
                    TipAmount = (decimal)dr["tip"],
                    Feedback = (string)dr["feedback"],
                    Order = order
                };
                transactions.Add(transaction);
            }
            return transactions;
        }
        #endregion
    }
}
