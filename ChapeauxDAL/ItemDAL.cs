using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauxDAL
{
    public class ItemDAL : Base
    {
        public List<Item> GetAllItems_DB()
        {
            //read users from database
            String query = "select itemID, name, price, stock, VAT, menuType from ITEMS";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadItems(ExecuteSelectQuery(query, parameters));
        }

        public Item GetItemByID_DB(int itemId)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("select itemID, name, price, stock, VAT, menuType from ITEMS where itemId = @itemID", conn);
            command.Parameters.AddWithValue("@itemID", itemId);

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
            String query = "insert into ITEMS values (@itemID, @name, @price, @stock, @category, @VAT, @menuType)";

            SqlParameter[] parameters = new SqlParameter[7]
            {
                    new SqlParameter("@itemID", menuItem.ItemID),
                    new SqlParameter("@name", menuItem.Name),
                    new SqlParameter("@price", menuItem.Price),
                    new SqlParameter("@stock", menuItem.Stock),
                    new SqlParameter("@category", menuItem.Category.ToString()),
                    new SqlParameter("@VAT", (int)menuItem.VATRate),
                    new SqlParameter("@menuType", (bool)menuItem.MenuType)
            };
            ExecuteEditQuery(query, parameters);
        }

        //public void EditMenuItem(Item lastItem, Item newItem)
        //{
        //    String query = "update ITEMS set name = @name, price = @price, stock = @stock, category = @category, VAT = @VAT, " +
        //        "mmenuType = @menuType ";
        //    
        //    SqlParameter[] parameters = new SqlParameter[7]
        //    {
        //            new SqlParameter("@name", newItem.Name),
        //            new SqlParameter("@price", menuItem.Price),
        //            new SqlParameter("@stock", menuItem.Stock),
        //            new SqlParameter("@category", menuItem.Category.ToString()),
        //            new SqlParameter("@VAT", (int)menuItem.VATRate),
        //            new SqlParameter("@menuType", (bool)menuItem.MenuType)
        //    };
        //    ExecuteEditQuery(query, parameters);
        //}

        private List<Item> ReadItems(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item menuItem = new Item()
                {
                    ItemID = (int)dr["itemID"],
                    Name = dr["name"].ToString(),
                    Price = (int)dr["price"],
                    Stock = (int)dr["stock"],
                    Category = dr["category"].ToString(),
                    VATRate = (decimal)dr["VAT"],
                    MenuType = (bool)dr["menuType"]
                };

                items.Add(menuItem);
            }
            return items;
        }
        private Item ReadMenuItem(SqlDataReader reader)
        {
            Item menuItem = new Item()
            {   //retrieve data from all fields
                ItemID = (int)reader["itemID"],
                Name = reader["name"].ToString(),
                Price = (int)reader["price"],
                Stock = (int)reader["stock"],
                Category = reader["category"].ToString(),
                VATRate = (decimal)reader["VAT"],
                MenuType = (bool)reader["menuType"]
            };
            return menuItem;
        }
    }
}
