using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        User us = new User();
        MainMenu mm = new MainMenu();
        ContactMenu cm = new ContactMenu();
        public Login()
        {
            InitializeComponent();
        }

        public static int GlobalUserId { get; private set; }
        public static void GetGlobalUserId(int UserId)
        {
            GlobalUserId = UserId;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void box_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_Box.Focus();
            }
        }

        private void box_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn.PerformClick();
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_Box.Text;
            string password = password_Box.Text;
            if(us.login(username,password))
            {
                if(student_radbtn.Checked == true)
                {
                    MessageBox.Show("Login successful","Login", MessageBoxButtons.OK);
                    this.Hide();
                    mm.Show();
                }    
                else
                {
                    MessageBox.Show("Login successful", "Login", MessageBoxButtons.OK);
                    this.Hide();
                    cm.Show();
                }
            }
            else
            {
                MessageBox.Show("Check username or password", "Login", MessageBoxButtons.OK);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
