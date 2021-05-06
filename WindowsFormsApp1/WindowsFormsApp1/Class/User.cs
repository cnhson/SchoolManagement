using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class User
    {
        DB db = new DB();
        public bool addUser(int id, string fname, string lname, string username, string password, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LOGIN (id, fname, lname, username, password, pic)" +
                "VALUES (@id, @fname, @lname, @username, @password, @pic)", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }    
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool upUser(int id, string fname, string lname, string username, string password, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("UPDATE LOGIN SET fname = @fname, lname = @lname, username = @username " +
                ", password = @password, pic = @pic where id = @id", db.GetConnection);
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool login(string username, string password)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LOGIN WHERE username = @username and password = @password", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int UserId = Convert.ToInt32(dt.Rows[0][0].ToString());
                Login.GetGlobalUserId(UserId);
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool checkUser(string username)
        {
            SqlCommand command = new SqlCommand("select * from LOGIN where username = @username", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            db.openConnection();

            if ((dt.Rows.Count > 0))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
