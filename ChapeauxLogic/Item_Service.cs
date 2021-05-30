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
            return itemDAO.GetAllItems_DB();
        }

        public Item GetItemById(int itemId)
        {
            return itemDAO.GetItemByID_DB(itemId);
        }
    }
}
 