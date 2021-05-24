using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Group
    {
        DB db = new DB();

        public bool checkGroup(int groupid, string groupname)
        {
            SqlCommand command = new SqlCommand("select * from GROUP_LIST where (groupid = @groupid or groupname = @groupname)", db.GetConnection);
            command.Parameters.Add("@groupid", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@groupname", SqlDbType.VarChar).Value = groupname;
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

        public bool addGroup(int groupid, string groupname)
        {
            SqlCommand command = new SqlCommand("INSERT INTO GROUP_LIST (groupid, groupname)" +
                "VALUES (@groupid, @groupname)", db.GetConnection);
            command.Parameters.Add("@groupid", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@groupname", SqlDbType.VarChar).Value = groupname;

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
        public bool delGroup(int groupid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM GROUP_LIST WHERE groupid = @groupid", db.GetConnection);
            command.Parameters.Add("@groupid", SqlDbType.Int).Value = groupid;
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

        public bool upGroup(int groupid, string groupname)
        {
            SqlCommand command = new SqlCommand("UPDATE GROUP_LIST SET groupname = @groupname " +
                "where groupid = @groupid", db.GetConnection);
            command.Parameters.Add("@groupid", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@groupname", SqlDbType.VarChar).Value = groupname;

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

        public DataTable getAllGroup()
        {
            SqlCommand cmd = new SqlCommand("Select * from GROUP_LIST", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
