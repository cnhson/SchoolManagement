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
    public partial class sco_AvgScore : Form
    {

        Score sc = new Score();
        public sco_AvgScore()
        {
            InitializeComponent();
        }

        private void sco_AvgScore_Load(object sender, EventArgs e)
        {
            printGrid.RowTemplate.Height = 50;
            printGrid.DataSource = sc.avgScorebyCourse();
        }
    }
}
