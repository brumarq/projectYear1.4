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
            //read users from database
            String query = "select userID, firstName, lastName, userName, [password], role from USERS";
            SqlParameter[] parameters = new SqlParameter[0];
            
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
        
        public void AddUserAccount(User user)
        {
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
        
        public void RemoveUserAccount(User user) //remove an employee from DB based on username
        {
            String query = "delete from USERS where username = @username";

            SqlParameter[] parameters = new SqlParameter[1]
            {
                 new SqlParameter("@username", user.LoginUsername)
            };
            
            ExecuteEditQuery(query, parameters);
        }

        public void EditUserAccount(User previousUser, User newUser)
        {
            String query = "update USER set role = @role, firstName = @firstname, lastName = @lastname, username = @newUsername, [password] = password where userName = @username;";
            
            SqlParameter[] parameters = new SqlParameter[5]
            {
                new SqlParameter("@firstname", newUser.FirstName),
                new SqlParameter("@lastname", newUser.LastName),
                new SqlParameter("@role", newUser.Role),
                new SqlParameter("@username", previousUser.LoginUsername),
                new SqlParameter("@password", newUser.LoginPassword)
            };
            
            ExecuteEditQuery(query, parameters);
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
        
        public User LoginCheck(string username)
        {
            string query = "SELECT userID, role, firstName, lastName, userName, password FROM USERS WHERE userName = @userName";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@userName", username),
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
