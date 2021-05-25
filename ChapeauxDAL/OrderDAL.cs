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
        public List<OrderItem> getDrinksStatus(int tableNumber)
        {
            string query = "SELECT ORDERITEMS.state FROM ORDERITEMS INNER JOIN ORDERS ON ORDERS.orderID = ORDERITEMS.orderID INNER JOIN ITEMS ON ITEMS.itemID = ORDERITEMS.itemID WHERE ITEMS.category = 'Drink' AND ORDERS.tableID = @tableID AND ORDERs.isPaid = 0; ";
            SqlParameter[] sqlParameters = {
                 new SqlParameter("@tableID", tableNumber),
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            List<OrderItem> listOfItems = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    State = dr["ORDERITEMS.state"].ToString(),
                };

                listOfItems.Add(orderItem);
            }

            return listOfItems;
        }
    }
}
