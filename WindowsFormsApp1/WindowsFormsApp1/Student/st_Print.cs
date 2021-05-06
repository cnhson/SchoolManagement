using System;
using System.Data;
using Microsoft.Office.Interop.Word;
using System.Drawing;
using System.IO;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class st_Print : Form
    {
        string CS = @"Data Source=DESKTOP-A1KBTCS;Initial Catalog=student;Integrated Security=True";

        private void CreateDocument()
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.DefaultExt = ".docx";
                saveFileDialog1.Filter = "Documents|*.docx";
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.InitialDirectory = @"C:\Desktop";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    object filename = saveFileDialog1.FileName;       
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
                winword.ShowAnimation = false;
                winword.Visible = false;
                object missing = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                int rows = printGrid.Rows.Count+1;      
                int columns = printGrid.Columns.Count;  

                Table T = document.Tables.Add(para1.Range, rows, columns, ref missing, ref missing);
                T.Borders.Enable = 1;

                for (int i = 1; i < T.Rows.Count; i++)
                {
                    for (int j = 1; j < T.Columns.Count+1; j++)
                    {
                            //Header 
                            T.Rows[1].Cells[j ].Range.Text = printGrid.Columns[j-1].HeaderText.ToString();
                            T.Rows[1].Cells[j ].Range.Font.Bold = 1;
                            T.Rows[1].Cells[j ].Range.Font.Name = "verdana";
                            T.Rows[1].Cells[j ].Range.Font.Size = 10;
                            T.Rows[1].Cells[j ].Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            T.Rows[1].Cells[j ].VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            T.Rows[1].Cells[j ].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            //Data
                            T.Rows[i+1].Cells[j].Range.Text = printGrid.Rows[i-1].Cells[j-1].Value.ToString();
                            if ( j == 8) 
                            {
                                Image sparePicture = ByteArrayToImage((byte[])printGrid.Rows[i-1].Cells[7].Value);
                                Clipboard.SetDataObject(sparePicture);                       
                                T.Rows[i + 1].Cells[j].Range.Paste();             
                            }
                        }
                }
                    Clipboard.Clear();
                    document.SaveAs2(ref filename);
                    document.Close(ref missing, ref missing, ref missing);
                    document = null;
                    winword.Quit(ref missing, ref missing, ref missing);
                    winword = null;
                    MessageBox.Show("Document created successfully !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Image ByteArrayToImage(byte[] byteArrayIn) //Byte to Image function
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }


        public st_Print()
        {
            InitializeComponent();
        }

        private void Print_Load(object sender, EventArgs e)
        {
            printGrid.RowTemplate.Height = 140;     
        }

        private void save_Click(object sender, EventArgs e)
        {
            CreateDocument();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM STD_LIST", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                printGrid.DataSource = dt;
                DataGridViewImageColumn pic = new DataGridViewImageColumn();
                pic = (DataGridViewImageColumn)printGrid.Columns[7];
                pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            Student student = new Student();
            if (radbtn_yes.Checked)
            {
                DateTime start = datetime1.Value;
                DateTime end = datetime2.Value;
                if (start > end)
                {
                    DateTime temp = start;
                    start = end;
                    end = temp;
                }
                if (radbtn_male.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from STD_LIST where bdate between @start and @end and gender = 'Male'");
                    command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
                    printGrid.DataSource = student.getStudent(command);
                }
                else if (radbtn_female.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from STD_LIST where bdate between @start and @end and gender = 'Female'");
                    command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
                    printGrid.DataSource = student.getStudent(command);
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT * from STD_LIST where bdate between @start and @end");
                    command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
                    printGrid.DataSource = student.getStudent(command);
                }
            }
            else
            {
                if (radbtn_all.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from STD_LIST");
                    printGrid.DataSource = student.getStudent(command);
                }
                else if (radbtn_female.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from STD_LIST where gender = 'Female'");
                    printGrid.DataSource = student.getStudent(command);
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT * from STD_LIST where gender = 'Male'");
                    printGrid.DataSource = student.getStudent(command);
                }
            }
        }

    }
}

