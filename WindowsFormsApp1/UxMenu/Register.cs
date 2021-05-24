using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        Login lo = new Login();
        public Register()
        {
            InitializeComponent();
        }

        private void reg_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            lo.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        bool verif()
        {
            if ((id_Box.Text.Trim() == "")
                || (fname_Box.Text.Trim() == "")
                || (lname_Box.Text.Trim() == "")
                || (username_Box.Text.Trim() == "")
                || (password_Box.Text.Trim() == "")
                || (picture_Box.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picture_Box.Image = new Bitmap(open.FileName);
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {

            if (verif())
            {
                User us = new User();
                int id = Convert.ToInt32(id_Box.Text);
                string fname = fname_Box.Text;
                string lname = lname_Box.Text;
                string username = username_Box.Text;
                string password = password_Box.Text;
                MemoryStream pic = new MemoryStream();
                if (us.checkUser(username))
                {
                    MessageBox.Show("Username already exists", "Create account", MessageBoxButtons.OK);
                }
                else
                {
                    picture_Box.Image.Save(pic, picture_Box.Image.RawFormat);
                    if (us.addUser(id, fname, lname, username, password, pic))
                    {
                        MessageBox.Show("Create account Successful", "Create account", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Create account", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
