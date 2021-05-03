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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Noti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            st_List dv = new st_List();
            dv.Show();
            dv.BringToFront();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            st_Add AS = new st_Add();
            AS.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            DB db = new DB();
            db.closeConnection();
            LogInForm lof = new LogInForm();
            lof.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            st_Statistics sta = new st_Statistics();
            sta.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            st_Print pr = new st_Print();
            pr.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            st_Management ma = new st_Management();
            ma.Show();
        }

        private void removecourse_item_Click(object sender, EventArgs e)
        {
            cou_Remove cR = new cou_Remove();
            cR.Show();
        }

        private void addcourse_item_Click(object sender, EventArgs e)
        {
            cou_Add cA = new cou_Add();
            cA.Show();
        }

        private void printcourse_item_Click(object sender, EventArgs e)
        {
            cou_Print cP = new cou_Print();
            cP.Show();
        }

        private void editcourse_item_Click(object sender, EventArgs e)
        {
            cou_Edit cE = new cou_Edit();
            cE.Show();
        }

        private void managecourse_item_Click(object sender, EventArgs e)
        {
            cou_Management cM = new cou_Management();
            cM.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            sco_Add sA = new sco_Add();
            sA.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            sco_Remove sR = new sco_Remove();
            sR.Show();
        }

        private void managescore_item_Click(object sender, EventArgs e)
        {
            sco_Management sM = new sco_Management();
            sM.Show();
        }
    }
    public class MyColorTable : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return Color.Navy;
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Color.Navy;
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Color.Navy;
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.Blue;
            }
        }
    }
}
