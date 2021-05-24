using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Contact
    {
        DB db = new DB();

        public bool addContact(int id, string fname, string lname, int groupid, string phone, string email, string address, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("INSERT INTO CONTACT (id, fname, lname, groupid, phone, email, address, pic)" +
                "VALUES (@id, @fname, @lname, @groupid, @phone, @email, @address, @pic)", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@groupid", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
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

        public bool upContact(int id, string fname, string lname, int groupid, string phone, string email, string address, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("UPDATE CONTACT SET fname = @fname, lname = @lname, groupid = @groupid, phone = @phone, email = @email, address = @address, pic = @pic where id = @id", db.GetConnection);
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@groupid", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
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

        public bool delContact(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM CONTACT WHERE id = @id", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public bool checkContact(int id, string fname, string lname)
        {
            SqlCommand command = new SqlCommand("select * from CONTACT where id = @id or (fname = @fname and lname = @lname)", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
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

        public DataTable getAllContact()
        {
            SqlCommand cmd = new SqlCommand("select * from CONTACT",db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getContact(SqlCommand cmd)
        {
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
