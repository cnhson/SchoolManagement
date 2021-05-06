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
    public partial class cou_Management : Form
    {
        Course cou = new Course();
        int pos;

        public cou_Management()
        {
            InitializeComponent();
        }

        private void cou_Management_Load(object sender, EventArgs e)
        {
            ReloadListBox();
        }

        void ReloadListBox()
        {
            courselist_Box.DataSource = cou.getAllCourse();
            courselist_Box.ValueMember = "cid";
            courselist_Box.DisplayMember = "clabel";
            totalstudent_label.Text = ("Total courses = " + cou.totalcourse());
        }

        void ShowData(int index)
        {
            DataRow dr = cou.getAllCourse().Rows[index];
            courselist_Box.SelectedValue = index;
            cid_Box.Text = dr.ItemArray[0].ToString();
            clabel_Box.Text = dr.ItemArray[1].ToString();
            cperiod_Box.Value = int.Parse(dr.ItemArray[2].ToString());
            description_Box.Text = dr.ItemArray[3].ToString();
        }

        private void courselist_Box_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)courselist_Box.SelectedItem;
            pos = courselist_Box.SelectedIndex;
            ShowData(pos);
        }

        private void AddCou_btn_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cid_Box.Text);
            string clabel = clabel_Box.Text;
            int cperiod = Convert.ToInt32(cperiod_Box.Text);
            string description = description_Box.Text;

            if (verif())
            {
                if (cou.addCourse(cid, clabel, cperiod, description))
                {
                    MessageBox.Show("Add Course Successful", "Add Course", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error", "Add Course", MessageBoxButtons.OK);
                }
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
    

        private void RemoveCou_btn_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cid_Box.Text.ToString());

            if (verif())
            {
                if (cou.delCourse(cid))
                {
                    MessageBox.Show("Delete Course Successful", "Add Course", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error", "Delete Course", MessageBoxButtons.OK);
                }
            }
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

        private void First_btn_Click(object sender, EventArgs e)
        {
            pos = 0;
            ShowData(pos);
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            if(pos < (cou.getAllCourse().Rows.Count -1))
            {
                pos += 1;
                ShowData(pos);
            }
        }

        private void Previous_btn_Click(object sender, EventArgs e)
        {
            if ( pos > 0 )
            {
                pos -= 1;
                ShowData(pos);
            }
        }

        private void Last_btn_Click(object sender, EventArgs e)
        {
            pos = cou.getAllCourse().Rows.Count - 1;
            ShowData(pos);
        }
    }
}
