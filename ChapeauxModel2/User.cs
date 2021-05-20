using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauxModel
{
    public class User
    {
        public int UserID { get; set; }
        public Role Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LoginUsername { get; set; }
        public string LoginPassword { get; set; }
    }
}
