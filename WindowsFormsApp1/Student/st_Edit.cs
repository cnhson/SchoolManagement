using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class st_Edit : Form
    {
        Student st = new Student();
        public st_Edit()
        {
            InitializeComponent();
        }

        private void st_Edit_Load(object sender, EventArgs e)
        {

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (verif())
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
                mgpicture.Image.Save(pic, mgpicture.Image.RawFormat);
                if (st.upStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                {
                    MessageBox.Show("Update Student Successful", "Update Student", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error", "Update Student", MessageBoxButtons.OK);
                }
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (verif())
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
                if (MessageBox.Show("Confirm to delete this student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (st.delStudent(id))
                    {
                        idmg_Box.Text = "";
                        fnamemg_Box.Text = "";
                        lnamemg_Box.Text = "";
                        addressmg_Box.Text = "";
                        phonemg_Box.Text = "";
                        bdatemg_Box.Value = new DateTime(2005, 12, 12);
                        mgpicture.Image = null;
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Student's not deleted, Please enter a valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Uploadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                mgpicture.Image = new Bitmap(open.FileName);
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            if(idmg_Box.Text.Trim() != "")
            {
                int id = Convert.ToInt32(idmg_Box.Text);
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A1KBTCS;Initial Catalog=student;Integrated Security=True"); con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM STD_LIST WHERE id =" + id, con);
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
        }
    }
}
