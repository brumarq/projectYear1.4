using System.Collections.Generic;
using ChapeauxDAL;
using ChapeauxModel;

namespace ChapeauxLogic
{
    public class Transaction_Service
    {
        //private OrderDAL orderDal = new OrderDAL();
        TransactionDAL transactionDAL = new TransactionDAL();

        public void AddTransaction(Transaction transaction)
        {
            transactionDAL.AddTransaction(transaction);
        }
    }
}
