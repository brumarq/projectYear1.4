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

        /*public List<Order> getOrderForTable(int tableNumber)
        {
            return orderdb.getDrinksStatus(tableNumber);
        }*/
    }
}
