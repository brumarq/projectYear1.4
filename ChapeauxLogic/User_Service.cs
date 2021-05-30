using ChapeauxDAL;
using ChapeauxModel;
using System.Collections.Generic;

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
            return userDAO.Get_Users_DB();
        }

        public User GetUserById(int userId)
        {
            return userDAO.GetUserById_DB(userId);
        }
    }
}
