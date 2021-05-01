using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=FOXNGUYEN;Initial Catalog=data;Integrated Security=True");
    
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
