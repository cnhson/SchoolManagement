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
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled =! char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                errorProvider1.SetError(label9,"Only Number");
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
                errorProvider1.SetError(label10, "Only Letters");
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
                errorProvider1.SetError(label11, "Only Letters");
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
                errorProvider1.SetError(label12, "Only Number");
                label12.Text = "Only Number";
            }
            else
            {
                errorProvider1.SetError(label12, "");
                label12.Text = "";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Uploadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddSt_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            int id = Convert.ToInt32(id_Box.Text);
            string fname = fname_Box.Text;
            string lname = lname_Box.Text;
            DateTime bdate = bdate_Box.Value;
            string phone = phone_Box.Text;
            string adrs = address_Box.Text;
            string gender = "Male";
            MemoryStream pic = new MemoryStream();

            if (female_Box.Checked)
            {
                gender = "Female";
            }

            if (verif())
            {
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
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

        private void id_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
