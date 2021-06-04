using ChapeauxDAL;
using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxLogic
{
    public class Item_Service
    {
        ItemDAL itemdal;
        public Item_Service()
        {
            itemdal = new ItemDAL();
        }
        public List<Item> GetItems()
        {
            List<Item> items = itemdal.GetAllItems();
            return items;
        }
    }
}
