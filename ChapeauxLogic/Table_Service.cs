using ChapeauxDAL;
using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxLogic
{
    public class Table_Service
    {
        TableDAL tabledb;

        public Table_Service()
        {
            tabledb = new TableDAL();
        }

        public List<Table> getAllTables()
        {
            return tabledb.GetAllTables();
        }
        public Table getTable(int tableID)
        {
            return tabledb.GetTable(tableID);
        }

        public void UpdateStatus(int tableID, Status status)
        {
            tabledb.UpdateStatus(tableID, status);
        }
    }
}
