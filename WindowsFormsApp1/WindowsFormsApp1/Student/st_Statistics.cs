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
    public partial class st_Statistics : Form
    {
        public st_Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            Student st = new Student();
            double total = Convert.ToDouble(st.totalStudent());
            double totalM = Convert.ToDouble(st.totalMaleStudent());
            double totalF = Convert.ToDouble(st.totalFemaleStudent());
            double MSP = (totalM  / total);
            double FSP = (totalF  / total);
            label1.Text = "Total students: " + total.ToString();
            label2.Text = "Male:   " + totalM.ToString();
            label3.Text = "Female: " + totalF.ToString();       
            chart1.Series["Students"].Points[0].YValues[0] = MSP;
            chart1.Series["Students"].Points[1].YValues[0] = FSP;
        }


    }
}
