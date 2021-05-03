using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class st_Management : Form
    {
        Student st = new Student();
        public st_Management()
        {
            InitializeComponent();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            manageGrid.RowTemplate.Height = 140;
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A1KBTCS;Initial Catalog=student;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM STD_LIST", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                manageGrid.DataSource = dt;
                DataGridViewImageColumn pic = new DataGridViewImageColumn();
                pic = (DataGridViewImageColumn)manageGrid.Columns[7];
                pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            totalst_label.Text = ("Total student: " + manageGrid.Rows.Count);
        }

        private void idmg_Box_TextChanged(object sender, EventArgs e)
        {
            if (idmg_Box.Text == null)
            {
                MessageBox.Show("Please enter numbers", "Error", MessageBoxButtons.OK);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                errorProvider1.SetError(label9, "[ Only Number ]");
                label9.Text = "Only Number";
            }
            else
            {
                errorProvider1.SetError(label9, "");
                label9.Text = "";
            }

        }

        private void fname_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                errorProvider1.SetError(label10, "[ Only Letters ]");
                label10.Text = "Only Letters";
            }
            else
            {
                errorProvider1.SetError(label10, "");
                label10.Text = "";
            }
        }

        private void lname_Box__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                errorProvider1.SetError(label11, "[ Only Letters ]");
                label11.Text = "Only Letters";
            }
            else
            {
                errorProvider1.SetError(label11, "");
                label11.Text = "";
            }
        }

        private void phone_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                errorProvider1.SetError(label12, "[ Only Number ]");
                label12.Text = "Only Number";
            }
            else
            {
                errorProvider1.SetError(label12, "");
                label12.Text = "";
            }
        }

        private void Uploadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                mgpicture.Image = new Bitmap(open.FileName);
            }
        }

        private void AddSt_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idmg_Box.Text);
            string fname = fnamemg_Box.Text;
            string lname = lnamemg_Box.Text;
            DateTime bdate = bdatemg_Box.Value;
            string phone = phonemg_Box.Text;
            string adrs = addressmg_Box.Text;
            string gender = "Male";
            MemoryStream pic = new MemoryStream();

            if (femalemg_Box.Checked)
            {
                gender = "Female";
            }

            if (verif())
            {
                mgpicture.Image.Save(pic, mgpicture.Image.RawFormat);
                if(st.addStudent(id,fname,lname,bdate,gender,phone,adrs,pic))
                {
                    MessageBox.Show("Add Student Successful","Add Student",MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK);
                }
            }

            bool verif()
            {
                if ((fnamemg_Box.Text.Trim() == "")
                    || (lnamemg_Box.Text.Trim() == "")
                    || (addressmg_Box.Text.Trim() == "")
                    || (phonemg_Box.Text.Trim() == "")
                    || (mgpicture.Image == null))
                { 
                    return false; 
                }
                else
                {
                    return true;
                }
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idmg_Box.Text);
                string fname = fnamemg_Box.Text;
                string lname = lnamemg_Box.Text;
                DateTime bdate = bdatemg_Box.Value;
                string phone = phonemg_Box.Text;
                string adrs = addressmg_Box.Text;
                string gender = "Male";
                MemoryStream pic = new MemoryStream();

                if (femalemg_Box.Checked)
                {
                    gender = "Female";
                }
                if (MessageBox.Show("Confirm to delete this student","Delete Student",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    if (st.delStudent(id))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idmg_Box.Text = "";
                        fnamemg_Box.Text = "";
                        lnamemg_Box.Text = "";
                        addressmg_Box.Text = "";
                        phonemg_Box.Text = "";
                        bdatemg_Box.Value = DateTime.Now;
                        mgpicture.Image = null;                      
                    }
                    else
                    {
                        MessageBox.Show("Student's not deleted, Please enter a valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            int id = Convert.ToInt32(idmg_Box.Text);
            string fname = fnamemg_Box.Text;
            string lname = lnamemg_Box.Text;
            DateTime bdate = bdatemg_Box.Value;
            string phone = phonemg_Box.Text;
            string adrs = addressmg_Box.Text;
            string gender = "Male";
            MemoryStream pic = new MemoryStream();

            if (femalemg_Box.Checked)
            {
                gender = "Female";
            }

            if (verif())
            {
                mgpicture.Image.Save(pic, mgpicture.Image.RawFormat);
                if (st.upStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                {
                    MessageBox.Show("Update Student Successful", "Update Student", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK);
                }
            }

            bool verif()
            {
                if ((fnamemg_Box.Text.Trim() == "")
                    || (lnamemg_Box.Text.Trim() == "")
                    || (addressmg_Box.Text.Trim() == "")
                    || (phonemg_Box.Text.Trim() == "")
                    || (mgpicture.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A1KBTCS;Initial Catalog=student;Integrated Security=True"); con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM STD_LIST WHERE id =" + int.Parse(idmg_Box.Text), con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {

                    fnamemg_Box.Text = (sdr["fname"].ToString());
                    lnamemg_Box.Text = (sdr["lname"].ToString());
                    bdatemg_Box.Value = Convert.ToDateTime(sdr["bdate"].ToString());
                    phonemg_Box.Text = (sdr["phone"].ToString());
                    if ((sdr["gender"].ToString()) == "Male")
                    {
                        malemg_Box.Checked = true;
                    }
                    else
                    {
                        femalemg_Box.Checked = true;
                    }
                    addressmg_Box.Text = (sdr["address"].ToString());
                    MemoryStream ms = new MemoryStream((byte[])sdr["picture"]);
                    mgpicture.Image = new Bitmap(ms);
                }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A1KBTCS;Initial Catalog=student;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM STD_LIST", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                manageGrid.DataSource = dt;
                DataGridViewImageColumn pic = new DataGridViewImageColumn();
                pic = (DataGridViewImageColumn)manageGrid.Columns[7];
                pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A1KBTCS;Initial Catalog=student;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * from STD_LIST where CONCAT(fname, lname, address) Like '%" + search_Box.Text + "%'",con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                manageGrid.DataSource = dt;
                DataGridViewImageColumn pic = new DataGridViewImageColumn();
                pic = (DataGridViewImageColumn)manageGrid.Columns[7];
                pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + idmg_Box.Text);
            if((mgpicture.Image == null))
            {
                MessageBox.Show("No Image in the picturebox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                mgpicture.Image.Save((svf.FileName + "." + ImageFormat.Jpeg.ToString()));
            }
        }
    }
}
