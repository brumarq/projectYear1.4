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
    public class TableDAL : Base
    {
        // Get all the available tables
        public List<Table> GetAllTables()
        {
            string query = "SELECT tableID, status FROM TABLES";
            SqlParameter[] sqlParameters = {
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        // Only get one specific table using a tableID
        public Table GetTable(int tableID)
        {
            string query = "SELECT tableID, status FROM TABLES WHERE tableID=@tableID";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@tableID", tableID),
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        // Update table status
        public void UpdateStatus(int tableID, Status status)
        {
            string query = "UPDATE TABLES SET status = @status WHERE tableID=@tableID";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@status", status.ToString()),
                new SqlParameter("@tableID", tableID),
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        private Table ReadTable(DataTable dataTable)
        {
            Table table = null;

            foreach (DataRow dr in dataTable.Rows)
            {
                table = new Table()
                {
                    TableID = (int)dr["tableID"],
                    Status = (Status)Enum.Parse(typeof(Status), dr["status"].ToString()),
                };
            }
            return table;
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> listOfTables = new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    TableID = (int)dr["tableID"],
                    Status = (Status)Enum.Parse(typeof(Status), dr["status"].ToString()),
                };

                listOfTables.Add(table);
            }

            return listOfTables;
        }
    }
}
