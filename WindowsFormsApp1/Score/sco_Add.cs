using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class sco_Add : Form
    {
        Course cou = new Course();
        Student st = new Student();
        Score sc = new Score();
        DB db = new DB();
        public sco_Add()
        {
            InitializeComponent();
        }

        private void sco_Add_Load(object sender, EventArgs e)
        {
            cid_Box.DataSource = cou.getAllCourse();
            cid_Box.ValueMember = "cid";
            cid_Box.DisplayMember = "cid";
            SqlCommand cmd = new SqlCommand("select id, fname, lname from STD_LIST", db.GetConnection);
            printGrid.DataSource = st.getStudent(cmd);
        }

        private void printGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 && printGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                int id = Convert.ToInt32(printGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                DataTable dt = new DataTable();
                dt = st.getStudentbyId(id);
                id_Box.Text = dt.Rows[0][0].ToString();
            }
        }

        private void description_Box_Enter(object sender, EventArgs e)
        {
            if(description_Box.Text == "Fail or Pass")
            {
                description_Box.Text = null;
            }
        }

        private void description_Box_Leave(object sender, EventArgs e)
        {
            if(description_Box.Text == "")
            {
                description_Box.Text = "Fail or Pass";
            }
        }


        bool verif()
        {
            if ((id_Box.Text.Trim() == "")
                || (cid_Box.Text.Trim() == "")
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

        private void AddSco_btn_Click(object sender, EventArgs e)
        {

            if (verif())
            {
                int id = Convert.ToInt32(id_Box.Text);
                int cid = Convert.ToInt32(cid_Box.Text);
                string clabel = clabel_Box.Text;
                int score = Convert.ToInt32(score_Box.Text);
                string description = description_Box.Text;
                if (sc.checkScore(id,cid))
                {
                    MessageBox.Show("Score already exists", "Add Score", MessageBoxButtons.OK);
                }
                else
                {
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
        }

        private void cid_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(cid_Box.SelectedValue);
                DataTable dt = new DataTable();
                dt = cou.getCourseById(cid);
                clabel_Box.Text = dt.Rows[0][1].ToString();
            }
            catch { }
        }
    }
}
