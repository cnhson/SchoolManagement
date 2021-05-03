using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class User
    {
        DB db2 = new DB();
        public bool addUser(string username, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LOGIN (username, password)" +
                "VALUES (@username, @password)", db2.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            db2.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                db2.closeConnection();
                return true;
            }    
            else
            {
                db2.closeConnection();
                return false;
            }

        }

    }
}
