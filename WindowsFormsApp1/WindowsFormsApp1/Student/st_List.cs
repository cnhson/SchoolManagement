using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class st_List : Form
    {

        string CS = @"Data Source=DESKTOP-A1KBTCS;Initial Catalog=student;Integrated Security=True";

        public st_List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 140;
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM STD_LIST", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                DataGridViewImageColumn pic = new DataGridViewImageColumn();
                pic = (DataGridViewImageColumn)dataGridView1.Columns[7];
                pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            st_Management ma = new st_Management();
            ma.Show();
        }
    }
}
