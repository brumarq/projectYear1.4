using System;
using ChapeauxModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ChapeauxDAL
{
    public class ItemDAL : Base
    {
        public List<Item> GetAllItems()
        {
            string query = "SELECT itemID, name, price, stock, category, Course, VATRate FROM [ITEMS]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Item> ReadTables(DataTable dataTable)
        {
            List<Item> items = new List<Item>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item()
                {
                    ItemID = (int)dr["itemID"],
                    Name = (string)dr["name"],
                    Price = (decimal)dr["price"],
                    Stock = (int)dr["stock"],
                    Category = (string)dr["category"],
                    VATRate = (decimal)dr["VATRate"],
                    menuType = (bool)dr["Course"]
                };
                items.Add(item);
            }
            return items;
        }
    }
}
