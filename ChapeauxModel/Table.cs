using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauxModel
{
    public enum Status
    {
        Free, Occupied, Late
    }
    public class Table
    {
        public int TableID { get; set; }
        public Status Status { get; set; }
    }
}
