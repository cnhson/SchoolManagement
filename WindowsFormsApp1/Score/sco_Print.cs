using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Word;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class sco_Print : Form
    {
        Score sc = new Score();
        public sco_Print()
        {
            InitializeComponent();
        }

        private void sco_Print_Load(object sender, EventArgs e)
        {
            scoregrid.RowTemplate.Height = 50;
            scoregrid.DataSource = sc.ScoreTable();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            CreateDocument();
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
                    para1.Range.Text = "Scores List";
                    para1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    para1.Range.InsertParagraphAfter();
                    para1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                    para1.Range.Text = "\r\n Class: 19110CLA2 \r\n Windows Programming";
                    para1.Range.InsertParagraphAfter();

                    int rows = scoregrid.Rows.Count + 1;
                    int columns = scoregrid.Columns.Count;

                    Table T = document.Tables.Add(para1.Range, rows, columns, ref missing, ref missing);
                    T.Borders.Enable = 1;

                    for (int i = 1; i < T.Rows.Count; i++)
                    {
                        for (int j = 1; j < T.Columns.Count + 1; j++)
                        {
                            //Header 
                            T.Rows[1].Cells[j].Range.Text = scoregrid.Columns[j - 1].HeaderText.ToString();
                            T.Rows[1].Cells[j].Range.Font.Bold = 1;
                            T.Rows[1].Cells[j].Range.Font.Name = "verdana";
                            T.Rows[1].Cells[j].Range.Font.Size = 8;
                            T.Rows[1].Cells[j].Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            T.Rows[1].Cells[j].VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            T.Rows[1].Cells[j].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            //Data
                            T.Rows[i + 1].Cells[j].Range.Text = scoregrid.Rows[i - 1].Cells[j - 1].Value.ToString();

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
    }
}
