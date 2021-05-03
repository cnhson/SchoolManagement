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
    public partial class cou_Remove : Form
    {
        public cou_Remove()
        {
            InitializeComponent();
        }

        private void cou_Remove_Load(object sender, EventArgs e)
        {

        }

        bool verif()
        {
            if ((cid_Box.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void RemoveCou_btn_Click(object sender, EventArgs e)
        {
            Course cou = new Course();
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
    }
}
