using ChapeauxDAL;
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
        private UserDAO userDAO = new UserDAO();

       

        public User LoginCheck(string username)
        {
            return userDAO.LoginCheck(username);
        }
        

        public List<User> GetUsers()
        {
            return userDAO.Get_Users();
        }

        public User GetUserById(int userId)
        {
            return userDAO.GetUserById(userId);
        }
    }
}
