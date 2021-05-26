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
    public class OrderDAL : Base
    {
        public bool isThereAnOrder(int tableNumber)
        {
            string query = "SELECT tableID FROM ORDERS WHERE tableID=@tableID AND isPaid=0";
            SqlParameter[] sqlParameters = {
                 new SqlParameter("@tableID", tableNumber),
            };
            return readTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private bool readTables(DataTable dataTable)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                return true;
            }

            return false;
        }
    }
}
