using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauxDAL
{
    public class UserDAO : Base
    {
        public List<User> Get_Users_DB()
        {
            conn.Open();
            String query = "select userID, firstName, lastName, userName, [password], role from USERS";
            SqlParameter[] parameters = new SqlParameter[0];
            conn.Close();
            
            return ReadUsers(ExecuteSelectQuery(query, parameters));
        }

        public void AddUserAccount(User user)
        {
            conn.Open();
            String query = "insert into USERS values (@firstName, @lastName, @userName, @password, @role)";
            
            SqlParameter[] parameters = new SqlParameter[5]
            {
                    new SqlParameter("@firstName", user.FirstName),
                    new SqlParameter("@lastName", user.LastName),
                    new SqlParameter("@userName", user.LoginUsername),
                    new SqlParameter("@password", user.LoginPassword),
                    new SqlParameter("@role", user.Role)
            };
            
            ExecuteEditQuery(query, parameters);
            conn.Close();
        }
        
        public void EditUserAccount(User user)
        {
            conn.Open();
            String query = "update USERS set firstName = @firstName, lastName = @lastname, userName = @username, [password] = @password, role = @role where userID = @userID;";
            
            SqlParameter[] parameters = new SqlParameter[6]
            {
                new SqlParameter("@userID", user.UserID),
                new SqlParameter("@firstname", user.FirstName),
                new SqlParameter("@lastname", user.LastName),
                new SqlParameter("@username", user.LoginUsername),
                new SqlParameter("@password", user.LoginPassword),
                new SqlParameter("@role", user.Role)
            };
            
            ExecuteEditQuery(query, parameters);
            conn.Close();
        }
        
        public void RemoveUserAccount(User user) 
        {
            conn.Open();
            String query = "delete from USERS where userID = @userID";

            SqlParameter[] parameters = new SqlParameter[1]
            {
                 new SqlParameter("@userID", user.UserID)
            };
            
            ExecuteEditQuery(query, parameters);
            conn.Close();
        }

        public User LoginCheck(string username)
        {
            string query = "SELECT userID, role, firstName, lastName, userName, password FROM USERS WHERE userName = @userName";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@userName", username),
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        
        private List<User> ReadUsers(DataTable dataTable)
        {
            List<User> users = new List<User>();

            foreach (DataRow dr in dataTable.Rows)
            {
                User user = new User()
                {
                    UserID = (int)dr["userID"],
                    Role = (Role)Enum.Parse(typeof(Role), dr["role"].ToString()),
                    FirstName = dr["firstName"].ToString(),
                    LastName = dr["lastName"].ToString(),
                    LoginUsername = dr["userName"].ToString(),
                    LoginPassword = dr["password"].ToString(),
                };

                users.Add(user);
            }
            return users;
        }

        private User ReadTables(DataTable dataTable)
        {
            User foundUser = null;
            foreach (DataRow dr in dataTable.Rows)
            {
                User user = new User()
                {
                    UserID = (int)dr["userID"],
                    Role = (Role)Enum.Parse(typeof(Role), dr["role"].ToString()),
                    FirstName = dr["firstName"].ToString(),
                    LastName = dr["lastName"].ToString(),
                    LoginUsername = dr["userName"].ToString(),
                    LoginPassword = dr["password"].ToString(),
                };

                foundUser = user;
            }

            return foundUser;
        }

    }
}
