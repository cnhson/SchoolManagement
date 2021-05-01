using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class List : Form
    {

        string CS = @"Data Source=FOXNGUYEN;Initial Catalog=data;Integrated Security=True";

        public List()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void List_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM STD_LIST", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
        }
    }
}
