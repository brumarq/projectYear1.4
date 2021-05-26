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
            return tabledb.getAllTables();
        }
        public Table getTable(int tableID)
        {
            return tabledb.getTable(tableID);
        }

        public void UpdateStatus(int tableID, Status status)
        {
            tabledb.updateStatus(tableID, status);
        }
    }
}
