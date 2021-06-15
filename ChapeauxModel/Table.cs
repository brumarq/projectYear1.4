using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauxModel
{
    public enum Status
    {
        Free, Occupied
    }
    public class Table
    {
        public int TableID { get; set; }
        public Status Status { get; set; }
    }
}
