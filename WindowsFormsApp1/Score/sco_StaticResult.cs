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
    public partial class sco_StaticResult : Form
    {
        Score sc = new Score();

        public sco_StaticResult()
        {
            InitializeComponent();
        }

        private void sco_StaticResult_Load(object sender, EventArgs e)
        {
            LoadCourseGrid();
            LoadResultGrid();
        }

        public void LoadCourseGrid()
        {
            coursestaticgrid.RowTemplate.Height = 50;
            coursestaticgrid.DataSource = sc.avgScorebyCourse();
        }

        public void LoadResultGrid()
        {
            Student st = new Student();
            double total = Convert.ToDouble(st.totalStudent());
            double totalP = (sc.GetPassNumber());
            double totalF = (sc.GetFailNumber());
            double Pass = (totalP / total);
            double Fail = (totalF / total);
            label1.Text = "Pass " + totalP.ToString();
            label2.Text = "Fail:   " + totalF.ToString();
            resultchart.Series["Result"].Points[0].YValues[0] = Fail;
            resultchart.Series["Result"].Points[1].YValues[0] = Pass;
        }
    }
}
