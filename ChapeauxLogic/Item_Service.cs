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

        public void AddMenuItem(Item menuItem)
        {
            itemDAO.AddMenuItem(menuItem);
        }

        public void EditMenuItem(Item menuItem)
        {
            itemDAO.EditMenuItem(menuItem);
        }

        public void DeleteMenuItem(Item menuItem)
        {
            itemDAO.DeleteMenuItem(menuItem);
        }
    }
}
 