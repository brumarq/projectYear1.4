using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauxDAL
{
    public class UserDAO : Base
    {
        public List<User> GetLoginInfo(string username)
        {
            string query = "SELECT userID, role, firstName, lastName, loginUsername, loginPassword FROM USER WHERE username = @loginUsername";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@loginUsername", username),
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<User> ReadTables(DataTable dataTable)
        {
            List<User> users = new List<User>();

            foreach (DataRow dr in dataTable.Rows)
            {
                User user = new User()
                {
                    UserID = (int)dr["userID"],
                    Role = (Role)dr["role"],
                    FirstName = dr["firstName"].ToString(),
                    LastName = dr["lastName"].ToString(),
                    LoginUsername = dr["loginUsername"].ToString(),
                    LoginPassword = dr["loginPassword"].ToString(),
                };
                users.Add(user);
            }
            return users;
        }
    }
}
