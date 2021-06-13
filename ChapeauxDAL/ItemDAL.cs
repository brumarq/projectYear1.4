using System;
using ChapeauxModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauxDAL
{
    public class ItemDAL : Base
    {
        public List<Item> Get_All_Items_DB()
        {
            String query = "select itemID, [name], price, stock, category, Course, VATRate from ITEMS";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadItems(ExecuteSelectQuery(query, parameters));
        }

        public void AddMenuItem(Item menuItem)
        {
            conn.Open();
            String query = "insert into ITEMS values (@name, @price, @stock, @category, @Course, @VATRate)";

            SqlParameter[] parameters = new SqlParameter[6]
            {
                new SqlParameter("@name", menuItem.Name),
                new SqlParameter("@price", menuItem.Price),
                new SqlParameter("@stock", menuItem.Stock),
                new SqlParameter("@category", menuItem.Category),
                new SqlParameter("@Course", menuItem.Course),
                new SqlParameter("@VATRate", menuItem.VATRate)
            };
            ExecuteEditQuery(query, parameters);
            conn.Close();
        }

        public void EditMenuItem(Item menuItem)
        {
            conn.Open();
            String query = "update ITEMS set [name] = @name, price = @price, stock = @stock, category = @category, Course = @Course, VATRate = @VATRate where itemID = @itemID";
            
            SqlParameter[] parameters = new SqlParameter[7]
            {
                new SqlParameter("@itemID", menuItem.ItemID),
                new SqlParameter("@name", menuItem.Name),
                new SqlParameter("@price", menuItem.Price),
                new SqlParameter("@stock", menuItem.Stock),
                new SqlParameter("@category", menuItem.Category),
                new SqlParameter("@Course", menuItem.Course),
                new SqlParameter("@VATRate", menuItem.VATRate)
            };
            ExecuteEditQuery(query, parameters);
            conn.Close();
        }

        public void DeleteMenuItem(Item menuItem)
        {
            conn.Open();
            String query = "delete from ITEMS where itemID = @itemID";

            SqlParameter[] parameters = new SqlParameter[1]
            {
                 new SqlParameter("@itemID", menuItem.ItemID)
            };
            ExecuteEditQuery(query, parameters);
            conn.Close();
        }
        
        private List<Item> ReadItems(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item menuItem = new Item()
                {
                    ItemID = (int)dr["itemID"],
                    Name = dr["name"].ToString(),
                    Price = (decimal)dr["price"],
                    Stock = (int)dr["stock"],
                    Category = dr["category"].ToString(),
                    Course = dr["Course"].ToString(),
                    VATRate = (decimal)dr["VATRate"]
                }; 

                items.Add(menuItem);
            }
            return items;
        }
    }
}
