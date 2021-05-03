using System;
using System.IO;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Score
    {
        DB db = new DB();

        public bool checkScore(int id, int cid)
        {
            SqlCommand command = new SqlCommand("select * from SCORE where id = @id and cid = @cid)", db.GetConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
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

        public bool addScore(int id, int cid, string clabel, int score, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SCORE (id, cid, clabel, cperiod, description)" +
                "VALUES (@id, @cid, @clabel, @cperiod, @description)", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            command.Parameters.Add("@clabel", SqlDbType.VarChar).Value = clabel;
            command.Parameters.Add("@score", SqlDbType.Int).Value = score;
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
        public bool delScore(int id, int cid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM SCORE WHERE id = @id and cid = @cid", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public bool updateScore(int id, int cid, string clabel, int score, string description)
        {
            SqlCommand command = new SqlCommand("UPDATE COURSE_LIST SET id = @id, cid = @cid, clabel = @clabel, score = @score, description = @description)" +
                "where id = @id)", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            command.Parameters.Add("@clabel", SqlDbType.VarChar).Value = clabel;
            command.Parameters.Add("@score", SqlDbType.Int).Value = score;
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

        public DataTable getAllScore()
        {
            SqlCommand command = new SqlCommand("select st.id, st.fname, st.lname, sc.cid, sc.clabel, sc.score from SCORE sc inner join STD_LIST st on st.id = sc.id", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getScorebyId(int id)
        {
            SqlCommand command = new SqlCommand("Select id, clabel, score, description from SCORE where id = @id",db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable avgScorebyCourse()
        {
            SqlCommand command = new SqlCommand("Select c.clabel as Course_Label, AVG(sc.score) as Average_Grade from SCORE sc,COURSE_LIST c where c.cid = sc.cid group by c.clabel", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
     
    }
}
