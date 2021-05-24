using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class st_Add : Form
    {
        public st_Add()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            bdate_Box.Format = DateTimePickerFormat.Custom;
            bdate_Box.ForeColor = Color.Green;
            bdate_Box.CalendarForeColor = Color.Blue;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled =! char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                errorProvider1.SetError(label9,"[ Only Number ]");
                label9.Text = "Only Number";
            }
            else
            {
                errorProvider1.SetError(label9, "");
                label9.Text = "";
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void AddSt_Click(object sender, EventArgs e)
        {

            if (verif())
            {
                Student st = new Student();
                int id = Convert.ToInt32(id_Box.Text);
                string fname = fname_Box.Text;
                string lname = lname_Box.Text;
                DateTime bdate = bdate_Box.Value;
                string phone = phone_Box.Text;
                string adrs = address_Box.Text;
                string gender = "Female";
                if (male_box.Checked)
                {
                    gender = "Male";
                }
                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if (st.checkID(id))
                {
                    MessageBox.Show("Student's ID already exists", "Add Student", MessageBoxButtons.OK);
                }
                else
                {
                    if (st.addStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                    {
                        MessageBox.Show("Add Student Successful", "Add Student", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK);
                    }
                }
            }

            bool verif()
            {
                if ((fname_Box.Text.Trim() == "")
                    || (lname_Box.Text.Trim() == "")
                    || (address_Box.Text.Trim() == "")
                    || (phone_Box.Text.Trim() == "")
                    || (pictureBox1.Image == null))
                { 
                    return false; 
                }
                else
                {
                    return true;
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
