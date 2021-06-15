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
        public void AddTransaction(Transaction transaction)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO PAYMENTS (totalPrice, paymentType, tip, feedback, orderID, transactionDate, VAT, state) " +
                                                           "VALUES(@TotalPrice, @paymentType, @TipAmount, @Feedback, @OrderID, @transactionDate, @VAT, @state)", conn);

            OpenConnection();

            cmd.Parameters.AddWithValue("@TotalPrice", transaction.TotalPrice);
            cmd.Parameters.AddWithValue("@paymentType", transaction.PaymentType.ToString());
            cmd.Parameters.AddWithValue("@TipAmount", transaction.TipAmount);
            cmd.Parameters.AddWithValue("@Feedback", transaction.Feedback);
            cmd.Parameters.AddWithValue("@OrderID", transaction.Order.OrderID);
            cmd.Parameters.AddWithValue("@transactionDate", transaction.TransactionDate);
            cmd.Parameters.AddWithValue("@VAT", transaction.VAT);
            cmd.Parameters.AddWithValue("@state", transaction.State.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();

            CloseConnection();

            orderDal.UpdateOrderIsPaid(transaction.Order);
        }
        #endregion
    }
}
