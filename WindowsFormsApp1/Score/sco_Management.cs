using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class sco_Management : Form
    {
        Score sc = new Score();
        Course cou = new Course();
        Student st = new Student();
        DB db = new DB();

        int getid;
        int getcid;


        string datatype;

        public sco_Management()
        {
            InitializeComponent();
        }

        private void sco_Management_Load(object sender, EventArgs e)
        {
            ShowScore();
            clabel_Box.DataSource = cou.getAllCourse();
            clabel_Box.ValueMember = "cid";
            clabel_Box.DisplayMember = "clabel";
        }

        void ShowStudent()
        {
            datatype = "student";
            printGrid.RowTemplate.Height = 50;
            SqlCommand cmd = new SqlCommand("select id, fname, lname,bdate from STD_LIST", db.GetConnection);
            printGrid.DataSource = st.getStudent(cmd);
        }

        void ShowScore()
        {
            datatype = "score";
            printGrid.RowTemplate.Height = 50;
            printGrid.DataSource = sc.getAllScore();
        }

        private void shstudent_btn_Click(object sender, EventArgs e)
        {
            ShowStudent();
        }

        private void shscore_btn_Click(object sender, EventArgs e)
        {
            ShowScore();
        }


        private void description_Box_Enter(object sender, EventArgs e)
        {
            if (description_Box.Text == "Fail or Pass")
            {
                description_Box.Text = null;
            }
        }

        private void description_Box_Leave(object sender, EventArgs e)
        {
            if (description_Box.Text == "")
            {
                description_Box.Text = "Fail or Pass";
            }
        }

        private void printGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && printGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                int id = Convert.ToInt32(printGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (datatype == "student")
                {
                    DataTable dt = new DataTable();
                    dt = st.getStudentbyId(id);
                    id_Box.Text = dt.Rows[0][0].ToString();
                }
                if (datatype == "score")
                {
                    int getid = Convert.ToInt32(printGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int getcid = Convert.ToInt32(printGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                    SqlCommand command = new SqlCommand("select * from SCORE where id = "+getid+" and cid = "+getcid, db.GetConnection);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    sda.Fill(dt);
                    id_Box.Text = dt.Rows[0][0].ToString();
                    clabel_Box.Text = dt.Rows[0][2].ToString();
                    score_Box.Value = int.Parse(dt.Rows[0][3].ToString());
                    description_Box.Text = dt.Rows[0][4].ToString();
                }
            }
        }

        private void Addsco_btn_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int id = Convert.ToInt32(id_Box.Text);
                int cid = Convert.ToInt32(clabel_Box.Text);
                string clabel = clabel_Box.Text;
                int score = Convert.ToInt32(score_Box.Text);
                string description = description_Box.Text;

                if (sc.addScore(id, cid, clabel, score, description))
                {
                    MessageBox.Show("Add Score Successful", "Add Score", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error", "Add Score", MessageBoxButtons.OK);
                }
            }
        }

        private void RemoveScore_btn_Click(object sender, EventArgs e)
        {
            int id = getid;
            int cid = getcid;
            if (sc.delScore(id, cid))
            {
                MessageBox.Show("Delete Score Successful", "Delete Score", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Delete Score", MessageBoxButtons.OK);
            }
        }

        private void AvgScore_btn_Click(object sender, EventArgs e)
        {
            sco_AvgScore sAS = new sco_AvgScore();
            sAS.Show();
        }

        bool verif()
        {
            if ((id_Box.Text.Trim() == "")
                || (clabel_Box.Text.Trim() == "")
                || (clabel_Box.Text.Trim() == "")
                || (score_Box.Text.Trim() == "")
                || (description_Box.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
