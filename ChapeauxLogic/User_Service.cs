using ChapeauxDAL;
using ChapeauxModel;
using System.Collections.Generic;

namespace ChapeauxLogic
{
    public class User_Service
    {
        private UserDAO userDAO = new UserDAO();

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
