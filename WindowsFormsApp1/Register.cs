using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void reg_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reg_Create_Click(object sender, EventArgs e)
        {
            if (reg_Password.Text == reg_repassword.Text)
            {
                User st = new User();
                string username = reg_Username.Text;
                string password = reg_Password.Text;

                if (verif())
                {
                    if (st.addUser(username, password))
                    {
                        MessageBox.Show("Create User Successful", "Add User", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Passwords don't match", "Add User", MessageBoxButtons.OK);
            }

            bool verif()
            {
                if ((reg_Username.Text.Trim() == "")
                    || (reg_Password.Text.Trim() == ""))
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
}
