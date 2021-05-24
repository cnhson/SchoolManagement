
namespace WindowsFormsApp1
{
    partial class sco_Management
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
            this.score_Box = new System.Windows.Forms.NumericUpDown();
            this.clabel_Box = new System.Windows.Forms.ComboBox();
            this.printGrid = new System.Windows.Forms.DataGridView();
            this.course_label = new System.Windows.Forms.Label();
            this.Addsco_btn = new System.Windows.Forms.Button();
            this.description_Box = new System.Windows.Forms.TextBox();
            this.id_Box = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.shstudent_btn = new System.Windows.Forms.Button();
            this.shscore_btn = new System.Windows.Forms.Button();
            this.RemoveScore_btn = new System.Windows.Forms.Button();
            this.AvgScore_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.score_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // score_Box
            // 
            this.score_Box.BackColor = System.Drawing.Color.Black;
            this.score_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.score_Box.ForeColor = System.Drawing.Color.White;
            this.score_Box.Location = new System.Drawing.Point(143, 103);
            this.score_Box.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.score_Box.Name = "score_Box";
            this.score_Box.Size = new System.Drawing.Size(159, 21);
            this.score_Box.TabIndex = 45;
            this.score_Box.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // clabel_Box
            // 
            this.clabel_Box.BackColor = System.Drawing.Color.Black;
            this.clabel_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clabel_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.clabel_Box.ForeColor = System.Drawing.Color.White;
            this.clabel_Box.FormattingEnabled = true;
            this.clabel_Box.Location = new System.Drawing.Point(143, 63);
            this.clabel_Box.Name = "clabel_Box";
            this.clabel_Box.Size = new System.Drawing.Size(159, 21);
            this.clabel_Box.TabIndex = 44;
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
            this.printGrid.Location = new System.Drawing.Point(330, 63);
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
            this.printGrid.Size = new System.Drawing.Size(459, 239);
            this.printGrid.TabIndex = 43;
            this.printGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.printGrid_CellClick);
            // 
            // course_label
            // 
            this.course_label.BackColor = System.Drawing.Color.Black;
            this.course_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.course_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_label.ForeColor = System.Drawing.Color.White;
            this.course_label.Location = new System.Drawing.Point(21, 63);
            this.course_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.course_label.Name = "course_label";
            this.course_label.Size = new System.Drawing.Size(90, 23);
            this.course_label.TabIndex = 42;
            this.course_label.Text = "Course Label";
            this.course_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Addsco_btn
            // 
            this.Addsco_btn.BackColor = System.Drawing.Color.Black;
            this.Addsco_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addsco_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Addsco_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Addsco_btn.Location = new System.Drawing.Point(24, 214);
            this.Addsco_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Addsco_btn.Name = "Addsco_btn";
            this.Addsco_btn.Size = new System.Drawing.Size(117, 30);
            this.Addsco_btn.TabIndex = 41;
            this.Addsco_btn.Text = "Add";
            this.Addsco_btn.UseVisualStyleBackColor = false;
            this.Addsco_btn.Click += new System.EventHandler(this.Addsco_btn_Click);
            // 
            // description_Box
            // 
            this.description_Box.BackColor = System.Drawing.Color.Black;
            this.description_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.description_Box.ForeColor = System.Drawing.Color.White;
            this.description_Box.Location = new System.Drawing.Point(143, 145);
            this.description_Box.Margin = new System.Windows.Forms.Padding(2);
            this.description_Box.Name = "description_Box";
            this.description_Box.Size = new System.Drawing.Size(159, 21);
            this.description_Box.TabIndex = 39;
            this.description_Box.Text = "Fail or Pass";
            this.description_Box.Enter += new System.EventHandler(this.description_Box_Enter);
            this.description_Box.Leave += new System.EventHandler(this.description_Box_Leave);
            // 
            // id_Box
            // 
            this.id_Box.BackColor = System.Drawing.Color.Black;
            this.id_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.id_Box.ForeColor = System.Drawing.Color.White;
            this.id_Box.Location = new System.Drawing.Point(143, 22);
            this.id_Box.Margin = new System.Windows.Forms.Padding(2);
            this.id_Box.Name = "id_Box";
            this.id_Box.Size = new System.Drawing.Size(159, 21);
            this.id_Box.TabIndex = 34;
            // 
            // description_label
            // 
            this.description_label.BackColor = System.Drawing.Color.Black;
            this.description_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.description_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.ForeColor = System.Drawing.Color.White;
            this.description_label.Location = new System.Drawing.Point(21, 146);
            this.description_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(90, 23);
            this.description_label.TabIndex = 35;
            this.description_label.Text = "Description";
            this.description_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // score_label
            // 
            this.score_label.BackColor = System.Drawing.Color.Black;
            this.score_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.score_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.ForeColor = System.Drawing.Color.White;
            this.score_label.Location = new System.Drawing.Point(21, 102);
            this.score_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(90, 23);
            this.score_label.TabIndex = 36;
            this.score_label.Text = "Score";
            this.score_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // id_label
            // 
            this.id_label.BackColor = System.Drawing.Color.Black;
            this.id_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.Location = new System.Drawing.Point(21, 22);
            this.id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(90, 23);
            this.id_label.TabIndex = 40;
            this.id_label.Text = "ID";
            this.id_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shstudent_btn
            // 
            this.shstudent_btn.BackColor = System.Drawing.Color.Black;
            this.shstudent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shstudent_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.shstudent_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.shstudent_btn.Location = new System.Drawing.Point(330, 22);
            this.shstudent_btn.Margin = new System.Windows.Forms.Padding(2);
            this.shstudent_btn.Name = "shstudent_btn";
            this.shstudent_btn.Size = new System.Drawing.Size(210, 23);
            this.shstudent_btn.TabIndex = 46;
            this.shstudent_btn.Text = "Show Student";
            this.shstudent_btn.UseVisualStyleBackColor = false;
            this.shstudent_btn.Click += new System.EventHandler(this.shstudent_btn_Click);
            // 
            // shscore_btn
            // 
            this.shscore_btn.BackColor = System.Drawing.Color.Black;
            this.shscore_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shscore_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.shscore_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.shscore_btn.Location = new System.Drawing.Point(579, 23);
            this.shscore_btn.Margin = new System.Windows.Forms.Padding(2);
            this.shscore_btn.Name = "shscore_btn";
            this.shscore_btn.Size = new System.Drawing.Size(210, 23);
            this.shscore_btn.TabIndex = 47;
            this.shscore_btn.Text = "Show Score";
            this.shscore_btn.UseVisualStyleBackColor = false;
            this.shscore_btn.Click += new System.EventHandler(this.shscore_btn_Click);
            // 
            // RemoveScore_btn
            // 
            this.RemoveScore_btn.BackColor = System.Drawing.Color.Black;
            this.RemoveScore_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveScore_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.RemoveScore_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveScore_btn.Location = new System.Drawing.Point(185, 214);
            this.RemoveScore_btn.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveScore_btn.Name = "RemoveScore_btn";
            this.RemoveScore_btn.Size = new System.Drawing.Size(117, 30);
            this.RemoveScore_btn.TabIndex = 48;
            this.RemoveScore_btn.Text = "Remove";
            this.RemoveScore_btn.UseVisualStyleBackColor = false;
            this.RemoveScore_btn.Click += new System.EventHandler(this.RemoveScore_btn_Click);
            // 
            // AvgScore_btn
            // 
            this.AvgScore_btn.BackColor = System.Drawing.Color.Black;
            this.AvgScore_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvgScore_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.AvgScore_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AvgScore_btn.Location = new System.Drawing.Point(24, 272);
            this.AvgScore_btn.Margin = new System.Windows.Forms.Padding(2);
            this.AvgScore_btn.Name = "AvgScore_btn";
            this.AvgScore_btn.Size = new System.Drawing.Size(278, 30);
            this.AvgScore_btn.TabIndex = 49;
            this.AvgScore_btn.Text = "Average Score by Course";
            this.AvgScore_btn.UseVisualStyleBackColor = false;
            this.AvgScore_btn.Click += new System.EventHandler(this.AvgScore_btn_Click);
            // 
            // sco_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.AvgScore_btn);
            this.Controls.Add(this.RemoveScore_btn);
            this.Controls.Add(this.shscore_btn);
            this.Controls.Add(this.shstudent_btn);
            this.Controls.Add(this.score_Box);
            this.Controls.Add(this.clabel_Box);
            this.Controls.Add(this.printGrid);
            this.Controls.Add(this.course_label);
            this.Controls.Add(this.Addsco_btn);
            this.Controls.Add(this.description_Box);
            this.Controls.Add(this.id_Box);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.id_label);
            this.Name = "sco_Management";
            this.Text = "sco_Management";
            this.Load += new System.EventHandler(this.sco_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.score_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown score_Box;
        private System.Windows.Forms.ComboBox clabel_Box;
        private System.Windows.Forms.DataGridView printGrid;
        private System.Windows.Forms.Label course_label;
        private System.Windows.Forms.Button Addsco_btn;
        private System.Windows.Forms.TextBox description_Box;
        private System.Windows.Forms.TextBox id_Box;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Button shstudent_btn;
        private System.Windows.Forms.Button shscore_btn;
        private System.Windows.Forms.Button RemoveScore_btn;
        private System.Windows.Forms.Button AvgScore_btn;
    }
}