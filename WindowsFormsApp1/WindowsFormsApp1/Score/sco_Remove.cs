using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class sco_Remove : Form
    {
        Score sc = new Score();
        int getid;
        int getcid;

        public sco_Remove()
        {
            InitializeComponent();
        }

        private void sco_Remove_Load(object sender, EventArgs e)
        {
            printGrid.RowTemplate.Height = 50;
            printGrid.DataSource = sc.getAllScore();
        }

        private void printGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] != null && int.Parse(printGrid.Rows[e.RowIndex].ToString()) > -1)
            {
                int getid = Convert.ToInt32(printGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                int getcid = Convert.ToInt32(printGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
        }

        private void RemoveSco_btn_Click(object sender, EventArgs e)
        {
            int id = getid;
            int cid = getcid;
            if (sc.delScore(id, cid))
            {
                MessageBox.Show("Delete Score Successful", "Delete Score", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Delete Score", MessageBoxButtons.OK);
            }
        }
    }
}
