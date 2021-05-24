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
            SqlCommand command = new SqlCommand("select * from SCORE where id = @id and cid = @cid", db.GetConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
            SqlCommand command = new SqlCommand("INSERT INTO SCORE (id, cid, clabel, score, description)" +
                " VALUES (@id, @cid, @clabel, @score, @description)", db.GetConnection);
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
            SqlCommand command = new SqlCommand("UPDATE COURSE_LIST SET id = @id, cid = @cid, clabel = @clabel, score = @score, description = @description " +
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
 
        public DataTable getAllScorebyID()
        {
            SqlCommand command = new SqlCommand(" SELECT id, cid, score, description FROM SCORE order BY id, cid", db.GetConnection);
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
            SqlCommand command = new SqlCommand("Select c.clabel as Course_Label, Round(AVG(sc.score),2) as Average_Grade from SCORE sc,COURSE_LIST c where c.cid = sc.cid group by c.clabel", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable GetAvgbyStudent()
        {
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.GetConnection,
                    CommandText = "SELECT sc.id, AVG(sc.score) FROM STD_LIST st "
                    +"inner join SCORE sc on st.id = sc.id Group by sc.id order by sc.id"
                };
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.closeConnection();

                return table;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }

            public int GetPassNumber()
        {
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.GetConnection,
                    CommandText = "select count(A.id) " +
                        "from (SELECT SCORE.id, AVG(SCORE.score) as AvgScore " +
                        "FROM STD_LIST inner join SCORE on STD_LIST.id = SCORE.id " +
                        "Group by SCORE.id " + "HAVING AVG(SCORE.score) >= 5) as A"
                };
                int result;
                try
                {
                    result = (int)command.ExecuteScalar();
                }
                catch (Exception)
                {
                    return 0;
                }
                db.closeConnection();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public int GetFailNumber()
        {
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.GetConnection,
                    CommandText = "select count(A.id) " +
                        "from (SELECT SCORE.id, AVG(SCORE.score) as AvgScore " +
                        "FROM STD_LIST inner join SCORE on STD_LIST.id = SCORE.id " +
                        "Group by SCORE.id " + "HAVING AVG(SCORE.score) < 5 and AVG(SCORE.score) >= 0) as A"
                };

                int result = 0;
                try
                {
                    result = (int)command.ExecuteScalar();
                }
                catch (Exception)
                {
                    return 0;
                }

                db.closeConnection();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public DataTable ResultTable()
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from SCORE", db.GetConnection);
                Student student = new Student();
                Course course = new Course();
                Score score = new Score();

                //create column
                SqlCommand cmd = new SqlCommand("Select id, fname, lname from STD_LIST",db.GetConnection);
                DataTable result = student.getStudent(cmd);
                result.Columns[0].ColumnName = "ID";
                result.Columns[1].ColumnName = "First Name";
                result.Columns[2].ColumnName = "Last Name";

                DataTable coursesLabel = course.getAllCourse();
                DataTable scores = score.getAllScorebyID();
                DataTable avgScore = score.GetAvgbyStudent();

                for (int i = 0; i < coursesLabel.Rows.Count; i++)
                {
                    result.Columns.Add(coursesLabel.Rows[i][1].ToString().Trim());
                }
                result.Columns.Add("Average");
                result.Columns.Add("Result");
                //test empty
                if (scores.Rows.Count < 1) return result;

                //fill score to table 
                int scoreRow = 0;
                for (int row = 0; row < result.Rows.Count; row++)
                {
                    try
                    {
                        int courseIndex = 0;
                        while (result.Rows[row][0].ToString().Trim() == scores.Rows[scoreRow][0].ToString().Trim())
                        {
                            result.Rows[row][courseIndex + 3] = scores.Rows[scoreRow][2].ToString().Trim();
                            courseIndex++;
                            scoreRow++;
                            if (scoreRow > scores.Rows.Count - 1)
                            {
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                // fill avg score
                for (int row = 0; row < result.Rows.Count; row++)
                {
                    try
                    {
                        result.Rows[row][result.Columns.Count - 2]
                            = avgScore.Rows[row][1].ToString().Trim();
                        int avg = Convert.ToInt32(avgScore.Rows[row][1]);
                        if (avg < 5)
                        {
                            result.Rows[row][result.Columns.Count - 1] = "Fail";
                        }
                        else
                        {
                            {
                                result.Rows[row][result.Columns.Count - 1] = "Pass";
                            }
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                //DataTable table = score.GetScore(command);
                //for (int row = 0; row < result.Rows.Count; row++)
                //{
                //    try
                //    {
                //        result.Rows[row][result.Columns.Count - 1]
                //            = table.Rows[row][3].ToString().Trim();
                //    }
                //    catch (Exception)
                //    {
                //        continue;
                //    }
                //}
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable ScoreTable()
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from SCORE", db.GetConnection);
                Student student = new Student();
                Course course = new Course();
                Score score = new Score();

                //create column
                SqlCommand cmd = new SqlCommand("Select id, fname, lname from STD_LIST", db.GetConnection);
                DataTable result = student.getStudent(cmd);
                result.Columns[0].ColumnName = "ID";
                result.Columns[1].ColumnName = "First Name";
                result.Columns[2].ColumnName = "Last Name";

                DataTable coursesLabel = course.getAllCourse();
                DataTable scores = score.getAllScorebyID();
                DataTable avgScore = score.GetAvgbyStudent();

                for (int i = 0; i < coursesLabel.Rows.Count; i++)
                {
                    result.Columns.Add(coursesLabel.Rows[i][1].ToString().Trim());
                }

                //test empty
                if (scores.Rows.Count < 1) return result;

                //fill score to table 
                int scoreRow = 0;
                for (int row = 0; row < result.Rows.Count; row++)
                {
                    try
                    {
                        int courseIndex = 0;
                        while (result.Rows[row][0].ToString().Trim() == scores.Rows[scoreRow][0].ToString().Trim())
                        {
                            result.Rows[row][courseIndex + 3] = scores.Rows[scoreRow][2].ToString().Trim();
                            courseIndex++;
                            scoreRow++;
                            if (scoreRow > scores.Rows.Count - 1)
                            {
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
