using ChapeauxDAL;
using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxLogic
{
    public class Order_Service
    {
        OrderDAL orderdb;

        public Order_Service()
        {
            orderdb = new OrderDAL();

        }

        public bool getOrderForTable(int tableNumber)
        {
            return orderdb.IsThereAnOrder(tableNumber);
        }

        public Order GetByTableID(int tableID)
        {
            if (tableID == 0)
            {
                throw new Exception("The selected table has no running orders");
            }
            return orderdb.GetByTableID(tableID);
        }
    }
}
