using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ChapeauxModel;

namespace ChapeauxDAL
{
    public class UserDAO : Base
    {
        public List<User> Get_Users()
        {
            //read Users values from sql database
            SqlCommand cmd = new SqlCommand
                ("select userID, firstName, lastName, role, username, password from USERS");

            SqlDataReader reader = cmd.ExecuteReader();
            List<User> users = new List<User>();

            while (reader.Read())
            {
                User user = ReadUser(reader);
                users.Add(user);
            }
            return users;
        }

        public User GetUserById(int userId)
        {
            conn.Open();
            SqlCommand command = new SqlCommand
                ("select userID, firstName, lastName, role, username, password from USERS where userId = @userID", conn);

            command.Parameters.AddWithValue("@Id", userId);

            SqlDataReader reader = command.ExecuteReader();

            User user = null;
            if (reader.Read())
            {
                user = ReadUser(reader);
            }

            reader.Close();
            conn.Close();

            return user;
        }

        private User ReadUser(SqlDataReader reader)
        {   
            User user = new User()
            {   //retrieve data from all fields
                UserID = (int)reader["userID"],
                FirstName = reader["firstName"].ToString(),
                LastName = reader["lastName"].ToString(),
                Role = (Role)reader["role"],
                LoginUsername = reader["username"].ToString(),
                LoginPassword = reader["password"].ToString(),
            };
            return user;
        }
    }
}