using ChapeauxDAL;
using ChapeauxModel;
using System.Collections.Generic;

namespace ChapeauxLogic
{
    public class User_Service
    {
        UserDAO userdb;

        public User_Service()
        {
            userdb = new UserDAO();
        }

        public List<User> GetLoginInfo(string username)
        {
            List<User> users = userdb.GetLoginInfo(username);
            return users;
        }
    }
}
