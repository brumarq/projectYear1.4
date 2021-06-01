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

        public void EditMenuItemLastItem(Item lastItem)
        {
            itemDAO.EditMenuItemLastItem(lastItem);
        }

        public void EditMenuItemNewItem(Item newItem)
        {
            itemDAO.EditMenuItemNewItem(newItem);
        }

        public void DeleteMenuItem(Item menuItem)
        {
            itemDAO.DeleteMenuItem(menuItem);
        }
    }
}
 