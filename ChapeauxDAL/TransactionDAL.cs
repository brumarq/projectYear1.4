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
        public Transaction GetByID(int transactionID)
        {
            Transaction transaction = null; //remove null

            //some code

            return transaction;
        }
        #endregion

        public List<Transaction> GetIncomeList()
        {
            conn.Open();
            
            List<Transaction> incomes = new List<Transaction>();
            
            String query = "sum(totalPrice) as Revenue, convert(DATE, transactionDate) as [date] From payments GROUP BY CAST(transactionDate as DATE)";

            foreach (Transaction t in incomes)
            {
                SqlParameter[] parameters = new SqlParameter[1]
                {
                    new SqlParameter("@totalPrice", t.TotalPrice)
                };
                ExecuteEditQuery(query, parameters);
            }
            conn.Close();

            return incomes;
        }

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
