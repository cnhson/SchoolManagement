using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class cont_Add : Form
    {
        Group gr = new Group();
        Contact co = new Contact();

        public cont_Add()
        {
            InitializeComponent();
        }

        private void cont_Add_Load(object sender, EventArgs e)
        {
            LoadAllGroups();
        }

        public void LoadAllGroups()
        {
            group_Box.DataSource = gr.getAllGroup();
            group_Box.DisplayMember = "groupname";
            group_Box.ValueMember = "groupid";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int id = Convert.ToInt32(id_Box.Text);
                string fname = fname_Box.Text;
                string lname = lname_Box.Text;
                int groupid = Convert.ToInt32(group_Box.SelectedValue.ToString());
                string phone = phone_Box.Text;
                string email = email_Box.Text;
                string address = address_Box.Text;
                MemoryStream pic = new MemoryStream();

                if (co.checkContact(id,fname,lname))
                {
                    MessageBox.Show("Contact already exists", "Add Contact", MessageBoxButtons.OK);
                }
                else
                {
                    picture_Box.Image.Save(pic, picture_Box.Image.RawFormat);
                    if (co.addContact(id, fname, lname, groupid, phone, email, address, pic))
                    {
                        MessageBox.Show("Add contact Successful", "Add Contact", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK);
                    }
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
