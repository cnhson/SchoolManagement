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
    public partial class cou_Add : Form
    {
        public cou_Add()
        {
            InitializeComponent();
        }

        private void cou_Add_Load(object sender, EventArgs e)
        {
     
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

        private void AddCou_btn_Click(object sender, EventArgs e)
        {

            if (verif())
            {
                Course cou = new Course();
                int cid = Convert.ToInt32(cid_Box.Text);
                string clabel = clabel_Box.Text;
                int cperiod = Convert.ToInt32(cperiod_Box.Text);
                string description = description_Box.Text;
                if(cou.checkCourse(cid,clabel))
                {
                    MessageBox.Show("Course already exist", "Add Course", MessageBoxButtons.OK);
                }
                else
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
            else
            {
                MessageBox.Show("No blank allowed and Period >= 10", "Add course", MessageBoxButtons.OK);
            }
        }
    }
}
