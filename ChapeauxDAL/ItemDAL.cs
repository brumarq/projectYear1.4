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

        public Item GetItemByName_DB(string name)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("select itemID, [name], price, stock, category, Course, VATRate from ITEMS where [name] = @name", conn);
            command.Parameters.AddWithValue("@name", name);

            SqlDataReader reader = command.ExecuteReader();

            Item menuItem = null;
            if (reader.Read())
            {
                menuItem = ReadMenuItem(reader);
            }

            reader.Close();
            conn.Close();
            return menuItem;
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
                    new SqlParameter("@category", menuItem.Category.ToString()),
                    new SqlParameter("@Course", menuItem.Course),
                    new SqlParameter("@VATRate", menuItem.VATRate)
            };
            ExecuteEditQuery(query, parameters);conn.Close();
            conn.Close();
        }

        public void EditMenuItem(Item menuItem)
        {
            conn.Open();
            String query = "update ITEMS set [name] = @name, price = @price, stock = @stock, category = @category, Course = @Course, VATRate = @VATRate where itemID = @itemID";
            
            SqlParameter[] parameters = new SqlParameter[6]
            {
                new SqlParameter("@name", menuItem.Name),
                new SqlParameter("@price", menuItem.Price),
                new SqlParameter("@stock", menuItem.Stock),
                new SqlParameter("@category", menuItem.Category.ToString()),
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
                 new SqlParameter("@itemID", menuItem.Name)
            };
            ExecuteEditQuery(query, parameters);
            conn.Close();
        }

        private Item ReadMenuItem(SqlDataReader reader)
        {
            Item menuItem = new Item()
            {   //retrieve data from all fields
                ItemID = (int)reader["itemID"],
                Name = (string)reader["name"],
                Price = (decimal)reader["price"],
                Stock = (int)reader["stock"],
                Category = (string)reader["category"],
                Course = (string)reader["Course"],
                VATRate = (decimal)reader["VATRate"]
            };
            return menuItem;
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
