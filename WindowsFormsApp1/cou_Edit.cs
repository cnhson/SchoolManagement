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
    public partial class cou_Edit : Form
    {
        Course cou = new Course();

        public cou_Edit()
        {
            InitializeComponent();
        }

        private void cou_Edit_Load(object sender, EventArgs e)
        {
            cid_Box.DataSource = cou.getAllCourse();
            cid_Box.ValueMember = "cid";
            cid_Box.DisplayMember = "cid";
        }

        private void cid_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                int cid = Convert.ToInt32(cid_Box.SelectedValue);
                DataTable dt = new DataTable();
                dt = cou.getCourseById(cid);
                clabel_Box.Text = dt.Rows[0][1].ToString();
                cperiod_Box.Value = Convert.ToInt32(dt.Rows[0][2].ToString());
                description_Box.Text = dt.Rows[0][3].ToString();
            }
            catch { }

        }


        bool verif()
        {
            if ((cid_Box.Text.Trim() == "")
                || (clabel_Box.Text.Trim() == "")
                || (cperiod_Box.Text.Trim() == "")
                || (Convert.ToInt32(cperiod_Box.Text.ToString()) < 10)
                || (description_Box.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void EditCou_btn_Click(object sender, EventArgs e)
        {
            Course cou = new Course();
            int cid = Convert.ToInt32(cid_Box.Text);
            string clabel = clabel_Box.Text;
            int cperiod = Convert.ToInt32(cperiod_Box.Text);
            string description = description_Box.Text;

            if (verif())
            {
                if (cou.updateCourse(cid, clabel, cperiod, description))
                {
                    MessageBox.Show("Update Course Successful", "Update Course", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error", "Update Course", MessageBoxButtons.OK);
                }
            }
        }
    }
}
