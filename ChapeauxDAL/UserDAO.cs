using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

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
                    new SqlParameter("@role", user.Role.ToString())
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
                new SqlParameter("@role", user.Role.ToString())
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

        #region Login
        public User LoginCheck(string username, string givenPassword)
        {
            string query = "SELECT userID, role, firstName, lastName, userName, password FROM USERS WHERE userName = @userName";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@userName", username),
            };
            return ReadLoginInformation(ExecuteSelectQuery(query, sqlParameters), givenPassword);
        }

        private User ReadLoginInformation(DataTable dataTable, string givenPassword)
        {
            User foundUser = null;
            if (dataTable == null)
            {
                return foundUser;
            }

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

                /* ---- Comparing password in data base with given password ---- */
                byte[] hashBytes = Convert.FromBase64String(user.LoginPassword);
                // Take the salt out of hashBytes and save it into the salt array
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);

                // Hash the given password with the salt that was saved in the database, and save the result in the hash array
                Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(givenPassword, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);

                // Compare the hash from the given password with the hash from the database
                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 16] == hash[i])
                    {
                        foundUser = user;
                    }
                }
            }

            return foundUser;
        }
        #endregion
    }
}
