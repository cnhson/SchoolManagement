using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Contact
    {
        DB db = new DB();

        public bool addContact(int id, string fname, string lname, string username, string password, MemoryStream pic)
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

        public bool upContact(int id, string fname, string lname, string username, string password, MemoryStream pic)
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
    }
}
