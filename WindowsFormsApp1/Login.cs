﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void box_UserName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void box_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM LOGIN WHERE username = @User and password = @Pass",db.GetConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = box_UserName.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = box_Password.Text;
            sda.SelectCommand = command;
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("  Login Successful");
                this.Hide();
                Main M = new Main();
                M.Show();
            }
            else
            {
                MessageBox.Show("Please check your Username and Password again");
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void box_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                box_Password.Focus();
            }
        }

        private void box_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_LogIn.PerformClick();
            }
        }
    }
}