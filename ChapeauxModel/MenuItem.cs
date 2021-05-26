using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauxModel
{
    public class MenuItem
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public decimal VAT { get; set; }
        public int Stock { get; set; }


    }
}
