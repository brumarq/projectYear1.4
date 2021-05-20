﻿using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauxDAL
{
    public class UserDAO : Base
    {
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
                    //Role = (Role)dr["role"],
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