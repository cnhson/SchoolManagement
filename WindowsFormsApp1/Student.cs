using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Student
    {
        DB db = new DB();
        public bool addStudent(int id,string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO STD_LIST (id, fname, lname, bdate, gender, phone, address, picture)" +
                "VALUES (@id, @fn, @ln, @bdt, @gdr, @phn, @adrs, @pic )", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = db.GetConnection;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
