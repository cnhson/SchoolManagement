using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class cont_List : Form
    {
        Group gr = new Group();
        Contact co = new Contact();
        DB db = new DB();

        public cont_List()
        {
            InitializeComponent();
        }

        private void cont_List_Load(object sender, EventArgs e)
        {
            LoadGroupList();
            LoadContactGrid();
        }

        public void LoadGroupList()
        {
            grouplist_Box.DataSource = gr.getAllGroup();
            grouplist_Box.DisplayMember = "groupname";
            grouplist_Box.ValueMember = "groupid";
        }

        public void LoadContactGrid()
        {
            contactGrid.RowTemplate.Height = 80;
            SqlCommand cmd = new SqlCommand("select co.id, co.fname, co.lname, gl.groupname, co.phone, co.email, co.address, co.pic from Contact co inner join GROUP_LIST gl on co.groupid = gl.groupid", db.GetConnection);
            contactGrid.DataSource = co.getContact(cmd);
                DataGridViewImageColumn pic = new DataGridViewImageColumn();
                pic = (DataGridViewImageColumn)contactGrid.Columns["Picture"];
                pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void grouplist_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > -1 && contactGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            //{
            //    int id = Convert.ToInt32(contactGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            //    SqlCommand cmd = new SqlCommand("select * from CONTACT where id = "+id, db.GetConnection);
            //    DataTable dt = new DataTable();
            //    dt = co.getContact(cmd);
            //    ContactMenu CM = new ContactMenu();
            //    CM.ctid_Box.Text = "1".ToString();
            //    //this.Hide();
            //}
        }
    }
}
