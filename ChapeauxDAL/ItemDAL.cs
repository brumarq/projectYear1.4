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
            //read users from database
            String query = "select itemID, [name], price, stock, xategory, Course, VATRate from ITEMS";
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
            ExecuteEditQuery(query, parameters);
        }

        public void EditMenuItem(Item lastItem, Item newItem)
        {
            String query = "update ITEMS set [name] = @name, price = @price, stock = @stock, category = @category, Course = @Course, VATRate = @VATRate where [name] = @name";
            
            SqlParameter[] parameters = new SqlParameter[6]
            {
                new SqlParameter("@name", lastItem.Name),
                new SqlParameter("@price", lastItem.Price),
                new SqlParameter("@stock", lastItem.Stock),
                new SqlParameter("@category", lastItem.Category.ToString()),
                new SqlParameter("@Course", lastItem.Course),
                new SqlParameter("@VATRate", lastItem.VATRate)
            };
            ExecuteEditQuery(query, parameters);
        }

        public void DeleteMenuItem(Item menuItem) //remove an item from DB based on name
        {
            String query = "delete from ITEMS where name = @name";

            SqlParameter[] parameters = new SqlParameter[1]
            {
                 new SqlParameter("@name", menuItem.Name)
            };
            ExecuteEditQuery(query, parameters);
        }

        private Item ReadMenuItem(SqlDataReader reader)
        {
            Item menuItem = new Item()
            {   //retrieve data from all fields
                ItemID = (int)reader["itemID"],
                Name = reader["name"].ToString(),
                Price = (double)reader["price"],
                Stock = (int)reader["stock"],
                Category = reader["category"].ToString(),
                Course = reader["Course"].ToString(),
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
                    Price = (double)dr["price"],
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
