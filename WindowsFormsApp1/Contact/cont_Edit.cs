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
    public partial class cont_Edit : Form
    {
        Contact co = new Contact();

        public cont_Edit()
        {
            InitializeComponent();
        }

        private void cont_Edit_Load(object sender, EventArgs e)
        {

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_Box.Text);
            string fname = fname_Box.Text;
            string lname = lname_Box.Text;
            int groupid = Convert.ToInt32(group_Box.SelectedValue.ToString());
            string phone = phone_Box.Text;
            string email = email_Box.Text;
            string address = address_Box.Text;
            MemoryStream pic = new MemoryStream();

            if (verif())
            {
                    picture_Box.Image.Save(pic, picture_Box.Image.RawFormat);
                    if (co.addContact(id, fname, lname, groupid, phone, email, address, pic))
                    {
                        MessageBox.Show("Edit contact Successful", "Edit Contact", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Contact", MessageBoxButtons.OK);
                    }
            }
            else
            {
                MessageBox.Show("No blank allowed", "Edit Contact", MessageBoxButtons.OK);
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

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        bool verif()
        {
            if ((id_Box.Text.Trim() == "")
                || (fname_Box.Text.Trim() == "")
                || (lname_Box.Text.Trim() == "")
                || (group_Box.SelectedIndex == -1)
                || (phone_Box.Text.Trim() == "")
                || (email_Box.Text.Trim() == "")
                || (address_Box.Text.Trim() == "")
                || (picture_Box.Image == null))
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
