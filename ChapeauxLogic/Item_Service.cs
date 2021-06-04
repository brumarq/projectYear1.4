using ChapeauxDAL;
using ChapeauxModel;
using System.Collections.Generic;

namespace ChapeauxLogic
{
    public class Item_Service
    {
        ItemDAL itemDAO = new ItemDAL();
        
        public List<Item> GetItems()
        {
            return itemDAO.Get_All_Items_DB();
        }

        public Item GetItemByName(string name)
        {
            return itemDAO.GetItemByName_DB(name);
        }

        public void AddMenuItem(Item menuItem)
        {
            itemDAO.AddMenuItem(menuItem);
        }

        public void EditMenuItem(Item lastItem, Item newItem)
        {
            itemDAO.EditMenuItem(lastItem, newItem);
        }

        public void DeleteMenuItem(Item menuItem)
        {
            itemDAO.DeleteMenuItem(menuItem);
        }
    }
}
 