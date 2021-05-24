
namespace WindowsFormsApp1
{
    partial class sco_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddSco_btn = new System.Windows.Forms.Button();
            this.description_Box = new System.Windows.Forms.TextBox();
            this.clabel_Box = new System.Windows.Forms.TextBox();
            this.id_Box = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.clabel_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printGrid = new System.Windows.Forms.DataGridView();
            this.cid_Box = new System.Windows.Forms.ComboBox();
            this.score_Box = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.printGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSco_btn
            // 
            this.AddSco_btn.BackColor = System.Drawing.Color.Black;
            this.AddSco_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSco_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.AddSco_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddSco_btn.Location = new System.Drawing.Point(140, 244);
            this.AddSco_btn.Margin = new System.Windows.Forms.Padding(2);
            this.AddSco_btn.Name = "AddSco_btn";
            this.AddSco_btn.Size = new System.Drawing.Size(159, 30);
            this.AddSco_btn.TabIndex = 28;
            this.AddSco_btn.Text = "Add";
            this.AddSco_btn.UseVisualStyleBackColor = false;
            this.AddSco_btn.Click += new System.EventHandler(this.AddSco_btn_Click);
            // 
            // description_Box
            // 
            this.description_Box.BackColor = System.Drawing.Color.Black;
            this.description_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.description_Box.ForeColor = System.Drawing.Color.White;
            this.description_Box.Location = new System.Drawing.Point(140, 192);
            this.description_Box.Margin = new System.Windows.Forms.Padding(2);
            this.description_Box.Name = "description_Box";
            this.description_Box.Size = new System.Drawing.Size(159, 21);
            this.description_Box.TabIndex = 26;
            this.description_Box.Text = "Fail or Pass";
            this.description_Box.Enter += new System.EventHandler(this.description_Box_Enter);
            this.description_Box.Leave += new System.EventHandler(this.description_Box_Leave);
            // 
            // clabel_Box
            // 
            this.clabel_Box.BackColor = System.Drawing.Color.Black;
            this.clabel_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.clabel_Box.ForeColor = System.Drawing.Color.White;
            this.clabel_Box.Location = new System.Drawing.Point(140, 105);
            this.clabel_Box.Margin = new System.Windows.Forms.Padding(2);
            this.clabel_Box.Name = "clabel_Box";
            this.clabel_Box.Size = new System.Drawing.Size(159, 21);
            this.clabel_Box.TabIndex = 24;
            // 
            // id_Box
            // 
            this.id_Box.BackColor = System.Drawing.Color.Black;
            this.id_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.id_Box.ForeColor = System.Drawing.Color.White;
            this.id_Box.Location = new System.Drawing.Point(140, 18);
            this.id_Box.Margin = new System.Windows.Forms.Padding(2);
            this.id_Box.Name = "id_Box";
            this.id_Box.Size = new System.Drawing.Size(159, 21);
            this.id_Box.TabIndex = 20;
            // 
            // description_label
            // 
            this.description_label.BackColor = System.Drawing.Color.Black;
            this.description_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.description_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.description_label.ForeColor = System.Drawing.Color.White;
            this.description_label.Location = new System.Drawing.Point(32, 192);
            this.description_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(90, 23);
            this.description_label.TabIndex = 21;
            this.description_label.Text = "Description";
            this.description_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // score_label
            // 
            this.score_label.BackColor = System.Drawing.Color.Black;
            this.score_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.score_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.score_label.ForeColor = System.Drawing.Color.White;
            this.score_label.Location = new System.Drawing.Point(32, 148);
            this.score_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(90, 23);
            this.score_label.TabIndex = 22;
            this.score_label.Text = "Score";
            this.score_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clabel_label
            // 
            this.clabel_label.BackColor = System.Drawing.Color.Black;
            this.clabel_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clabel_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.clabel_label.ForeColor = System.Drawing.Color.White;
            this.clabel_label.Location = new System.Drawing.Point(31, 105);
            this.clabel_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clabel_label.Name = "clabel_label";
            this.clabel_label.Size = new System.Drawing.Size(90, 23);
            this.clabel_label.TabIndex = 23;
            this.clabel_label.Text = "Label";
            this.clabel_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // id_label
            // 
            this.id_label.BackColor = System.Drawing.Color.Black;
            this.id_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.Location = new System.Drawing.Point(32, 17);
            this.id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(90, 23);
            this.id_label.TabIndex = 27;
            this.id_label.Text = "ID";
            this.id_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Course ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printGrid
            // 
            this.printGrid.AllowUserToAddRows = false;
            this.printGrid.AllowUserToDeleteRows = false;
            this.printGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.printGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.printGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.printGrid.BackgroundColor = System.Drawing.Color.Black;
            this.printGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.printGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.printGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.printGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.printGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.printGrid.EnableHeadersVisualStyles = false;
            this.printGrid.GridColor = System.Drawing.Color.White;
            this.printGrid.Location = new System.Drawing.Point(327, 18);
            this.printGrid.Margin = new System.Windows.Forms.Padding(2);
            this.printGrid.Name = "printGrid";
            this.printGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.printGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.printGrid.RowHeadersVisible = false;
            this.printGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            this.printGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.printGrid.RowTemplate.Height = 24;
            this.printGrid.Size = new System.Drawing.Size(376, 256);
            this.printGrid.TabIndex = 31;
            this.printGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.printGrid_CellContentClick);
            // 
            // cid_Box
            // 
            this.cid_Box.BackColor = System.Drawing.Color.Black;
            this.cid_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cid_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.cid_Box.ForeColor = System.Drawing.Color.White;
            this.cid_Box.FormattingEnabled = true;
            this.cid_Box.Location = new System.Drawing.Point(140, 59);
            this.cid_Box.Name = "cid_Box";
            this.cid_Box.Size = new System.Drawing.Size(159, 21);
            this.cid_Box.TabIndex = 32;
            this.cid_Box.SelectedIndexChanged += new System.EventHandler(this.cid_Box_SelectedIndexChanged);
            // 
            // score_Box
            // 
            this.score_Box.BackColor = System.Drawing.Color.Black;
            this.score_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.score_Box.ForeColor = System.Drawing.Color.White;
            this.score_Box.Location = new System.Drawing.Point(140, 150);
            this.score_Box.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.score_Box.Name = "score_Box";
            this.score_Box.Size = new System.Drawing.Size(159, 21);
            this.score_Box.TabIndex = 33;
            this.score_Box.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // sco_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(714, 294);
            this.Controls.Add(this.score_Box);
            this.Controls.Add(this.cid_Box);
            this.Controls.Add(this.printGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddSco_btn);
            this.Controls.Add(this.description_Box);
            this.Controls.Add(this.clabel_Box);
            this.Controls.Add(this.id_Box);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.clabel_label);
            this.Controls.Add(this.id_label);
            this.Name = "sco_Add";
            this.Text = "sco_Add";
            this.Load += new System.EventHandler(this.sco_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSco_btn;
        private System.Windows.Forms.TextBox description_Box;
        private System.Windows.Forms.TextBox clabel_Box;
        private System.Windows.Forms.TextBox id_Box;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label clabel_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView printGrid;
        private System.Windows.Forms.ComboBox cid_Box;
        private System.Windows.Forms.NumericUpDown score_Box;
    }
}