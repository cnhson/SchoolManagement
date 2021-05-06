using System;
using System.IO;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    class Course
    {
        string strCon = "Data Source=DESKTOP-A1KBTCS;Initial Catalog=student;Integrated Security=True";
        DB db = new DB();

        public bool checkCourse(int cid, string clabel)
        {
            SqlCommand command = new SqlCommand("select * from COURSE_LIST where clabel = @clabel and cid = @cid)", db.GetConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            command.Parameters.Add("@clabel", SqlDbType.VarChar).Value = clabel;
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

        public bool addCourse(int cid, string clabel, int cperiod , string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO COURSE_LIST (cid, clabel, cperiod, description)" +
                "VALUES (@cid, @clabel, @cperiod, @description)", db.GetConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            command.Parameters.Add("@clabel", SqlDbType.VarChar).Value = clabel;
            command.Parameters.Add("@cperiod", SqlDbType.Int).Value = cperiod;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;

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
        public bool delCourse(int cid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM COURSE_LIST WHERE cid = @cid", db.GetConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
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

        public bool updateCourse(int cid, string clabel, int cperiod, string description)
        {
            SqlCommand command = new SqlCommand("UPDATE COURSE_LIST SET cid = @cid, clabel = @clabel, cperiod = @cperiod, description = @description)" +
                "where cid = @cid)", db.GetConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            command.Parameters.Add("@clabel", SqlDbType.VarChar).Value = clabel;
            command.Parameters.Add("@cperiod", SqlDbType.Int).Value = cperiod;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;

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

        public DataTable getCourseById(int cid)
        {
            SqlCommand command = new SqlCommand("Select * from COURSE_LIST where cid = @cid", db.GetConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getAllCourse()
        {
            SqlCommand command = new SqlCommand("Select * from COURSE_LIST", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public int totalcourse()
        {
            string strSql = @"select count (*) from COURSE_LIST";
            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, conn);
            try
            {
                conn.Open();
                cmd.CommandText = @"select count (*) from COURSE_LIST";
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return n;

            }
            catch
            {
                return 0;
            }
        }
    }
}
