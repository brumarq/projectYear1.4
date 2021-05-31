using ChapeauxDAL;
using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxLogic
{
    public class Transaction_Service
    {
        //private OrderDAL orderDal = new OrderDAL();
        TransactionDAL transactionDAL = new TransactionDAL();

        public bool AddTransaction(Transaction transaction)
        {
            return transactionDAL.AddTransaction(transaction);
        }

        private Transaction GetByID(int transactionID)
        {
            return transactionDAL.GetByID(transactionID);
        }

        private Order GetByTableID(int tableID)
        {

        }
    }
}
