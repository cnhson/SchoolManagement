using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        DB db = new DB();
        public MainMenu()
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button_Noti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentlist_item_Click(object sender, EventArgs e)
        {
            st_List dv = new st_List();
            dv.Show();
            dv.BringToFront();
        }

        private void studentadd_item_Click(object sender, EventArgs e)
        {
            st_Add AS = new st_Add();
            AS.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Close();
            DB db = new DB();
            db.closeConnection();
            Login lof = new Login();
            lof.Show();
        }

        private void studentstatistics_Item_Click(object sender, EventArgs e)
        {
            st_Statistics sta = new st_Statistics();
            sta.Show();
        }

        private void studentprint_Item_Click(object sender, EventArgs e)
        {
            st_Print pr = new st_Print();
            pr.Show();
        }

        private void studentmanagement_Item_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            st_Edit sE = new st_Edit();
            sE.Show();
        }

        private void avgresult_item_Click(object sender, EventArgs e)
        {
            sco_Result sR2 = new sco_Result();
            sR2.Show();
        }

        private void MainMenu_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void avgscore_item_Click(object sender, EventArgs e)
        {
            sco_AvgScore sAv = new sco_AvgScore();
            sAv.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void staticsresult_item_Click(object sender, EventArgs e)
        {
            sco_StaticResult sSR = new sco_StaticResult();
            sSR.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString("HH:mm");
            day_label.Text = DateTime.Now.ToString("ddd");
            date_label.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void printscore_item_Click(object sender, EventArgs e)
        {
            sco_Print sPr = new sco_Print();
            sPr.Show();
        }
    }
    public class MyColorTable : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.Black;
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
                return Color.FromArgb(40, 40, 40);
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.FromArgb(40, 40, 40);
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return Color.FromArgb(40, 40, 40);
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Color.FromArgb(40, 40, 40);
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Color.FromArgb(40, 40, 40);
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.FromArgb(40, 40, 40);
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.FromArgb(40, 40, 40);
            }
        }
    }
}
