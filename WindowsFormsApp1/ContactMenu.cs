using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ContactMenu : Form
    {
        DB db = new DB();

        public ContactMenu()
        {
            InitializeComponent();
        }

        private void ContactMenu_Load(object sender, EventArgs e)
        {
            LoadContactInfo();
        }

        public void LoadContactInfo()
        {
            SqlCommand cmd = new SqlCommand("select * from LOGIN where id = @id", db.GetConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Login.GlobalUserId;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                byte[] pic = (byte[])dt.Rows[0]["pic"];
                MemoryStream image = new MemoryStream(pic);
                pic_Box.Image = Image.FromStream(image);
                welcome_label.Text = "Welcome back ( " + dt.Rows[0]["username"].ToString() + " )";

            }
        }

        private void gr_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
