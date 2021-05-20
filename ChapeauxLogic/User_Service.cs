﻿using ChapeauxDAL;
using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauxLogic
{
    public class User_Service
    {
        UserDAO userdb;

        public User_Service()
        {
            userdb = new UserDAO();

        }

        public User LoginCheck(string username)
        {
            return userdb.LoginCheck(username);
        }
    }
}