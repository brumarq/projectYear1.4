using ChapeauxModel;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChapeauxDAL
{
    public class ItemDAL : Base
    {
        public List<Item> GetAllItems_DB()
        {
            conn.Open();
            //read Items values from sql database
            SqlCommand command = new SqlCommand
                ("select itemID, name, price, stock, VAT, menuType from ITEMS");

            SqlDataReader reader = command.ExecuteReader();
            List<Item> menuItems = new List<Item>();

            while (reader.Read())
            {
                Item menuItem = ReadMenuItem(reader);
                menuItems.Add(menuItem);
            }

            conn.Close();
            return menuItems;
        }

        public Item GetItemByID_DB(int itemId)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("select itemID, name, price, stock, VAT, menuType from ITEMS where itemId = @itemID", conn);
            command.Parameters.AddValue("@itemID", itemId);

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
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("insert into ITEMS values (@itemID, @name, @price, @stock, @category, @VAT, @menuType)", conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("Oops! " + e.ToString());
            }

            try
            {
                conn.Close();
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("Oops! " + e.ToString());
            }
        }

        public void EditMenuItem(Item menuItem)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("update ITEMS set it ");
            conn.Close();
        }

        /*public void AddMenuItem(Item menuItem)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("insert into ITEMS values (@itemID, @name, @price, @stock, @category, @VAT, @menuType)", conn);

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
            reader.Close();
            conn.Close();
        }*/
        private Item ReadMenuItem(SqlDataReader reader)
        {
            Item menuItem = new Item()
            {   //retrieve data from all fields
                ItemID = (int)reader["itemID"],
                Name = reader["name"].ToString(),
                Price = (int)reader["price"],
                Stock = (int)reader["stock"],
                Category = reader["category"].ToString(),
                VATRate = (decimal)reader["VAT"].ToString(),
                MenuType = (bool)reader["menuType"].ToString(),
            };
            return menuItem;
        }
    }
}
