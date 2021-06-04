using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxModel
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
        public decimal VATRate { get; set; }
        public bool menuType { get; set; }

        public override string ToString()
        {
            return $"{ItemID} {Name} {Price} {Stock} {Category} {menuType} {VATRate}";
        }
    }
}
