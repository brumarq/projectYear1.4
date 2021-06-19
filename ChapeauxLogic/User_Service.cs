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
            return userDAO.Get_Users_DB();
        }

        public void AddUserAccount(User user)
        {
            userDAO.AddUserAccount(user);
        }
        
        public void EditUserAccount(User user)
        {
            userDAO.EditUserAccount(user);
        }

        public void RemoveUserPermissions(User user)
        {
            userDAO.RemoveUserAccount(user);
        }

        public User LoginCheck(string givenUsername, string givenPassword)
        {
            return userDAO.LoginCheck(givenUsername, givenPassword);
        }
    }
}
