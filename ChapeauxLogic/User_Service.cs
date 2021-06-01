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

        public User GetUserAccount(string username, string password)
        {
            return userDAO.GetUserAccount(username, password);
        }

        public User GetUserByUsername(string username)
        {
            return userDAO.GetUserByUsername_DB(username);
        }
        public void AddUserAccount(User user)
        {
            userDAO.AddUserAccount(user);
        }
        
        public void EditUserAccount(User previousUser, User newUser)
        {
            userDAO.EditUserAccount(previousUser, newUser);
        }

        public void DisplayUsers(User user)
        {
            userDAO.DisplayUsers(user);
        }

        public void RemoveUserAccount(User user)
        {
            userDAO.RemoveUserAccount(user);
        }

        public User LoginCheck(string givenUsername)
        {
            return userDAO.LoginCheck(givenUsername);
        }
    }
}
