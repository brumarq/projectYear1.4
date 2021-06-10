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
            //read users from database
            String query = "select userID, firstName, lastName, userName, [password], role from USERS";
            SqlParameter[] parameters = new SqlParameter[0];
            conn.Close();
            
            return ReadUsers(ExecuteSelectQuery(query, parameters));
        }

        public User GetUserByUsername_DB(string username)
        {
            conn.Open();
            User user = null;
            using (SqlCommand command = new SqlCommand
                ("select userID, firstName, lastName, userName, password, role from USERS where userName = @username", conn))
            {
                command.Parameters.AddWithValue("@username", username);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = ReadUser(reader);
                    }
                }
            }
            conn.Close();

            return user;
        }
        
        public User GetUserAccount(string username, string password) //get an account that matches the parameters
        {
            conn.Open();
            
            User user = null;
            using (SqlCommand cmd = new SqlCommand("select userID, firstName, lastName, userName, [password] from USERS where userName = @username AND [password] = @password;", conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        user = ReadUser(reader);
                }
            }
            conn.Close();
            return user;
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
        
        public void EditUserAccount(User previousUser, User newUser)
        {
            conn.Open();
            String query = "update USERS set firstName = @firstName, lastName = @lastname, userName = @username, [password] = @password, role = @role where userName = @username;";
            
            SqlParameter[] parameters = new SqlParameter[5]
            {
                new SqlParameter("@firstname", newUser.FirstName),
                new SqlParameter("@lastname", newUser.LastName),
                new SqlParameter("@username", previousUser.LoginUsername),
                new SqlParameter("@password", newUser.LoginPassword),
                new SqlParameter("@role", newUser.Role)
            };
            
            ExecuteEditQuery(query, parameters);
            conn.Close();
        }
        
        public void RemoveUserAccount(User user) //remove an employee from DB based on username
        {
            String query = "delete from USERS where userName = @username";

            SqlParameter[] parameters = new SqlParameter[1]
            {
                 new SqlParameter("@username", user.LoginUsername)
            };
            
            ExecuteEditQuery(query, parameters);
        }

        public void DisplayUsersById(User user)
        {
            conn.Open();
            String query = "select userID, firstName, lastName, userName, password, role from USERS where userID = @userID";

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

        private User ReadUser(SqlDataReader reader)
        {
            User user = new User()
            {   //retrieve data from all fields
                UserID = (int)reader["userID"],
                FirstName = reader["firstName"].ToString(),
                LastName = reader["lastName"].ToString(),
                Role = (Role)Enum.Parse(typeof(Role), reader["role"].ToString()),
                LoginUsername = reader["username"].ToString(),
                LoginPassword = reader["password"].ToString(),
            };
            
            return user;
        }

        public User LoginCheck(string username, string givenPassword)
        {
            string query = "SELECT userID, role, firstName, lastName, userName, password FROM USERS WHERE userName = @userName";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@userName", username),
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters), givenPassword);
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

        private User ReadTables(DataTable dataTable, string givenPassword)
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

    }
}
