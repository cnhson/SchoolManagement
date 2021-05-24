using System;
using System.Data;
using Microsoft.Office.Interop.Word;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class sco_Result : Form
    {
        string CS = @"Data Source=DESKTOP-A1KBTCS;Initial Catalog=student;Integrated Security=True";


        Score sc = new Score();
        public sco_Result()
        {
            InitializeComponent();
        }

        private void sco_Result_Load(object sender, EventArgs e)
        {
            resultgrid.RowTemplate.Height = 50;
            resultgrid.DataSource = sc.ResultTable();
        }

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
                    Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                    Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                    object styleHeading1 = "Heading 1";
                    para1.Range.set_Style(ref styleHeading1);
                    para1.Range.Text = "Results List";
                    para1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    para1.Range.InsertParagraphAfter();
                    para1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                    para1.Range.Text = "\r\n Class: 19110CLA2 \r\n Windows Programming";
                    para1.Range.InsertParagraphAfter();

                    int rows = resultgrid.Rows.Count + 1;
                    int columns = resultgrid.Columns.Count;

                    Table T = document.Tables.Add(para1.Range, rows, columns, ref missing, ref missing);
                    T.Borders.Enable = 1;

                    for (int i = 1; i < T.Rows.Count; i++)
                    {
                        for (int j = 1; j < T.Columns.Count + 1; j++)
                        {
                            //Header 
                            T.Rows[1].Cells[j].Range.Text = resultgrid.Columns[j - 1].HeaderText.ToString();
                            T.Rows[1].Cells[j].Range.Font.Bold = 1;
                            T.Rows[1].Cells[j].Range.Font.Name = "verdana";
                            T.Rows[1].Cells[j].Range.Font.Size = 8;
                            T.Rows[1].Cells[j].Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            T.Rows[1].Cells[j].VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            T.Rows[1].Cells[j].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            //Data
                            T.Rows[i + 1].Cells[j].Range.Text = resultgrid.Rows[i - 1].Cells[j - 1].Value.ToString();

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

        private void save_btn_Click(object sender, EventArgs e)
        {
            CreateDocument();
        }

        private void find_Click(object sender, EventArgs e)
        {
            DataView DV = new DataView(sc.ResultTable());
            DV.RowFilter = string.Format("convert(ID, 'System.String') like '%{0}%' or [First Name] Like '%{0}%' ", search_Box.Text);
            resultgrid.DataSource = DV;
        }

        private void resultgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && resultgrid.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                Student st = new Student();
                int id = Convert.ToInt32(resultgrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = st.getStudentbyId(id);
                id_Box.Text = dt.Rows[0][0].ToString();
                fname_Box.Text = dt.Rows[0][1].ToString();
                lname_Box.Text = dt.Rows[0][2].ToString();
            }
        }
    }
}
