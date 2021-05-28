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
            //read Users values from sql database
            SqlCommand cmd = new SqlCommand
                ("select userID, firstName, lastName, userName, password, role from USERS");

            SqlDataReader reader = cmd.ExecuteReader();
            List<User> users = new List<User>();

            while (reader.Read())
            {
                User user = ReadUser(reader);
                users.Add(user);
            }

            conn.Close();
            return users;
        }

        public User GetUserById_DB(int userId)
        {
            conn.Open();
            SqlCommand command = new SqlCommand
                ("select userID, firstName, lastName, userName, password, role from USERS where userId = @userID", conn);

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

        public void AddUserAccount(User user)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("insert into USERS values (@firstName, @lastName, @userName, @password, @role)", conn);

            SqlDataReader reader = command.ExecuteReader();

            reader.Close();
            conn.Close();
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
