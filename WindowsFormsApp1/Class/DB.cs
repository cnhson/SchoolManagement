
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A1KBTCS;Initial Catalog=student;Integrated Security=True");
    
        public SqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if((con.State == System.Data.ConnectionState.Closed))
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if ((con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
