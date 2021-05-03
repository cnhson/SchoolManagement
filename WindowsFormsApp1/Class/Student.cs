using System;
using System.IO;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Student
    {
        string strCon = "Data Source=DESKTOP-A1KBTCS;Initial Catalog=student;Integrated Security=True";

        DB db = new DB();
        public bool addStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
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
        public bool delStudent(int id)    
        {
            SqlCommand command = new SqlCommand("DELETE FROM STD_LIST WHERE id = @id", db.GetConnection);
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

        public bool upStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE STD_LIST SET fname = @fn, lname = @ln, bdate = @bdt, gender = @gdr, phone = @phn, address = @adrs, picture = @pic" +
                " WHERE id = @id", db.GetConnection);
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

        public int totalStudent()
        {
            string strSql = @"select count (*) from STD_LIST";
            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, conn);
            try
            {
                conn.Open();
                cmd.CommandText = @"select count (*) from STD_LIST";
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return n;

            }
            catch 
            {
                return 0;
            }
        }

        public int totalMaleStudent()
        {
            string strSql = @"select count (*) from STD_LIST where gender = 'Male'";
            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, conn);
            try
            {
                conn.Open();
                cmd.CommandText = @"select count (*) from STD_LIST where gender = 'Male'";
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return n;

            }
            catch
            {
                return 0;
            }
        }

        public int totalFemaleStudent()
        {
            string strSql = @"select count (*) from STD_LIST where gender = 'Female'";
            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, conn);
            try
            {
                conn.Open();
                cmd.CommandText = @"select count (*) from STD_LIST where gender = 'Female'";
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return n;

            }
            catch
            {
                return 0;
            }
        }

        public DataTable getStudent(SqlCommand command)
        {
            command.Connection = db.GetConnection;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
