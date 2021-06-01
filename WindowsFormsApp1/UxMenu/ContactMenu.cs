using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ContactMenu : Form
    {
        DB db = new DB();
        Group gr = new Group();
        Contact co = new Contact();

        public ContactMenu()
        {
            InitializeComponent();
        }

        private void ContactMenu_Load(object sender, EventArgs e)
        {
            LoadContactInfo();
            LoadGroupInfo();
            cont_List cL = new cont_List();
        }

        public void LoadContactInfo()
        {
            SqlCommand cmd = new SqlCommand("select * from LOGIN where id = @id", db.GetConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Login.GlobalUserId;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                byte[] pic = (byte[])dt.Rows[0]["pic"];
                MemoryStream image = new MemoryStream(pic);
                pic_Box.Image = Image.FromStream(image);
                welcome_label.Text = "Welcome back ( " + dt.Rows[0]["username"].ToString() + " )";

            }
        }

        public void LoadGroupInfo()
        {
            select_grname_Box.DataSource = gr.getAllGroup();
            select_grname_Box.ValueMember = "groupid";
            select_grname_Box.DisplayMember = "groupname";
            select_grname_Box.SelectedIndex = -1;
            select_grname_Box2.DataSource = gr.getAllGroup();
            select_grname_Box2.ValueMember = "groupid";
            select_grname_Box2.DisplayMember = "groupname";
            select_grname_Box2.SelectedIndex = -1;
        }

        private void gradd_btn_Click(object sender, EventArgs e)
        {
            if (verif1()) 
            {
                int groupid = Convert.ToInt32(enter_grip_Box.Text);
                string groupname = enter_grname_Box.Text;
                if ((gr.checkGroup(groupid, groupname)))
                {

                    MessageBox.Show("Group's Id or name already exists", "Add Group", MessageBoxButtons.OK);
                }
                else
                {
                    if(gr.addGroup(groupid,groupname))
                    {
                        MessageBox.Show("Group added", "Add Group", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("No blank allowed", "Add Group", MessageBoxButtons.OK);
            }
        }

        private void gredit_btn_Click(object sender, EventArgs e)
        {
            if (verif2())
            {
                int groupid = Convert.ToInt32(select_grname_Box.SelectedValue.ToString());
                string groupname = new_grname_Box.Text;
                    if (gr.upGroup(groupid, groupname))
                    {
                        MessageBox.Show("Group edited", "Edit Group", MessageBoxButtons.OK);
                    }
            }
            else
            {
                MessageBox.Show("No blank allowed", "Add Group", MessageBoxButtons.OK);
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            LoadGroupInfo();
            ClearTextBoxes();

        }

        bool verif0()
        {
            if ((ctid_Box.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool verif1()
        {
            if ((enter_grip_Box.Text.Trim() == "")
                || (enter_grname_Box.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool verif2()
        {
            if ((select_grname_Box.SelectedIndex == -1)
              ||(new_grname_Box.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool verif3()
        {
            if ((select_grname_Box.SelectedIndex == -1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void grremove_btn_Click(object sender, EventArgs e)
        {
            if (verif3())
            {
                int groupid = Convert.ToInt32(select_grname_Box2.SelectedValue.ToString());
                if (gr.delGroup(groupid))
                {
                    MessageBox.Show("Group deleted", "Delete Group", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No blank allowed", "Delete Group", MessageBoxButtons.OK);
            }
        }

        private void ctadd_btn_Click(object sender, EventArgs e)
        {
            cont_Add cA = new cont_Add();
            cA.Show();
        }

        private void ctedit_btn_Click(object sender, EventArgs e)
        {
            cont_Edit cE = new cont_Edit();
            cE.Show();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            cont_List cL = new cont_List();
            cL.Show();
        }

        private void ctremove_btn_Click(object sender, EventArgs e)
        {
            if (verif0())
            {
                int id = Convert.ToInt32(ctid_Box.Text);
                if (co.delContact(id))
                {
                    MessageBox.Show("Contact deleted", "Delete contact", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No blank allowed", "Delete contact", MessageBoxButtons.OK);
            }
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            cont_List cL = new cont_List();
            cL.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Close();
            DB db = new DB();
            db.closeConnection();
            Login lof = new Login();
            lof.Show();
        }
    }
}
