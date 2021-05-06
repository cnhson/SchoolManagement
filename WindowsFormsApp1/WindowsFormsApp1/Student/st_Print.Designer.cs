
namespace WindowsFormsApp1
{
    partial class st_Print
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radbtn_no = new System.Windows.Forms.RadioButton();
            this.radbtn_yes = new System.Windows.Forms.RadioButton();
            this.btn_check = new System.Windows.Forms.Button();
            this.and = new System.Windows.Forms.Label();
            this.datetime2 = new System.Windows.Forms.DateTimePicker();
            this.datetime1 = new System.Windows.Forms.DateTimePicker();
            this.datebetween = new System.Windows.Forms.Label();
            this.usedaterange = new System.Windows.Forms.Label();
            this.radbtn_female = new System.Windows.Forms.RadioButton();
            this.radbtn_male = new System.Windows.Forms.RadioButton();
            this.radbtn_all = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.refresh = new System.Windows.Forms.Button();
            this.printGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.printGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radbtn_no
            // 
            this.radbtn_no.AutoSize = true;
            this.radbtn_no.Checked = true;
            this.radbtn_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_no.ForeColor = System.Drawing.Color.White;
            this.radbtn_no.Location = new System.Drawing.Point(191, 19);
            this.radbtn_no.Name = "radbtn_no";
            this.radbtn_no.Size = new System.Drawing.Size(46, 20);
            this.radbtn_no.TabIndex = 19;
            this.radbtn_no.TabStop = true;
            this.radbtn_no.Text = "No";
            this.radbtn_no.UseVisualStyleBackColor = true;
            // 
            // radbtn_yes
            // 
            this.radbtn_yes.AutoSize = true;
            this.radbtn_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_yes.ForeColor = System.Drawing.Color.White;
            this.radbtn_yes.Location = new System.Drawing.Point(132, 19);
            this.radbtn_yes.Name = "radbtn_yes";
            this.radbtn_yes.Size = new System.Drawing.Size(53, 20);
            this.radbtn_yes.TabIndex = 20;
            this.radbtn_yes.Text = "Yes";
            this.radbtn_yes.UseVisualStyleBackColor = true;
            // 
            // btn_check
            // 
            this.btn_check.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check.BackColor = System.Drawing.Color.Black;
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_check.Location = new System.Drawing.Point(757, 33);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(100, 46);
            this.btn_check.TabIndex = 18;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // and
            // 
            this.and.AutoSize = true;
            this.and.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.and.ForeColor = System.Drawing.Color.White;
            this.and.Location = new System.Drawing.Point(250, 56);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(34, 16);
            this.and.TabIndex = 17;
            this.and.Text = "and";
            // 
            // datetime2
            // 
            this.datetime2.CustomFormat = " dd  / MM /  yyyy";
            this.datetime2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime2.Location = new System.Drawing.Point(289, 51);
            this.datetime2.Margin = new System.Windows.Forms.Padding(2);
            this.datetime2.MaxDate = new System.DateTime(2005, 12, 12, 0, 0, 0, 0);
            this.datetime2.Name = "datetime2";
            this.datetime2.RightToLeftLayout = true;
            this.datetime2.Size = new System.Drawing.Size(134, 25);
            this.datetime2.TabIndex = 16;
            this.datetime2.Value = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            // 
            // datetime1
            // 
            this.datetime1.CustomFormat = " dd  / MM /  yyyy";
            this.datetime1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime1.Location = new System.Drawing.Point(111, 51);
            this.datetime1.Margin = new System.Windows.Forms.Padding(2);
            this.datetime1.MaxDate = new System.DateTime(2005, 12, 12, 0, 0, 0, 0);
            this.datetime1.Name = "datetime1";
            this.datetime1.RightToLeftLayout = true;
            this.datetime1.Size = new System.Drawing.Size(134, 25);
            this.datetime1.TabIndex = 15;
            this.datetime1.Value = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            // 
            // datebetween
            // 
            this.datebetween.AutoSize = true;
            this.datebetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebetween.ForeColor = System.Drawing.Color.White;
            this.datebetween.Location = new System.Drawing.Point(3, 56);
            this.datebetween.Name = "datebetween";
            this.datebetween.Size = new System.Drawing.Size(103, 16);
            this.datebetween.TabIndex = 13;
            this.datebetween.Text = "Date between";
            // 
            // usedaterange
            // 
            this.usedaterange.AutoSize = true;
            this.usedaterange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usedaterange.ForeColor = System.Drawing.Color.White;
            this.usedaterange.Location = new System.Drawing.Point(3, 21);
            this.usedaterange.Name = "usedaterange";
            this.usedaterange.Size = new System.Drawing.Size(123, 16);
            this.usedaterange.TabIndex = 14;
            this.usedaterange.Text = "Use Date Range";
            // 
            // radbtn_female
            // 
            this.radbtn_female.AutoSize = true;
            this.radbtn_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_female.ForeColor = System.Drawing.Color.White;
            this.radbtn_female.Location = new System.Drawing.Point(141, 41);
            this.radbtn_female.Name = "radbtn_female";
            this.radbtn_female.Size = new System.Drawing.Size(78, 20);
            this.radbtn_female.TabIndex = 10;
            this.radbtn_female.Text = "Female";
            this.radbtn_female.UseVisualStyleBackColor = true;
            // 
            // radbtn_male
            // 
            this.radbtn_male.AutoSize = true;
            this.radbtn_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_male.ForeColor = System.Drawing.Color.White;
            this.radbtn_male.Location = new System.Drawing.Point(70, 41);
            this.radbtn_male.Name = "radbtn_male";
            this.radbtn_male.Size = new System.Drawing.Size(60, 20);
            this.radbtn_male.TabIndex = 11;
            this.radbtn_male.Text = "Male";
            this.radbtn_male.UseVisualStyleBackColor = true;
            // 
            // radbtn_all
            // 
            this.radbtn_all.AutoSize = true;
            this.radbtn_all.Checked = true;
            this.radbtn_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_all.ForeColor = System.Drawing.Color.White;
            this.radbtn_all.Location = new System.Drawing.Point(20, 41);
            this.radbtn_all.Name = "radbtn_all";
            this.radbtn_all.Size = new System.Drawing.Size(44, 20);
            this.radbtn_all.TabIndex = 12;
            this.radbtn_all.TabStop = true;
            this.radbtn_all.Text = "All";
            this.radbtn_all.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save.BackColor = System.Drawing.Color.Black;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.save.Location = new System.Drawing.Point(528, 665);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(112, 34);
            this.save.TabIndex = 21;
            this.save.Text = "Save to Word";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh.BackColor = System.Drawing.Color.Black;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refresh.Location = new System.Drawing.Point(297, 665);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(109, 34);
            this.refresh.TabIndex = 24;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // printGrid
            // 
            this.printGrid.AllowUserToAddRows = false;
            this.printGrid.AllowUserToDeleteRows = false;
            this.printGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            this.printGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.printGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.printGrid.BackgroundColor = System.Drawing.Color.Black;
            this.printGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.printGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.printGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.printGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fname,
            this.lname,
            this.bdate,
            this.gender,
            this.phone,
            this.address,
            this.picture});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.printGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.printGrid.EnableHeadersVisualStyles = false;
            this.printGrid.GridColor = System.Drawing.Color.White;
            this.printGrid.Location = new System.Drawing.Point(11, 112);
            this.printGrid.Margin = new System.Windows.Forms.Padding(2);
            this.printGrid.Name = "printGrid";
            this.printGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.printGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.printGrid.RowHeadersVisible = false;
            this.printGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            this.printGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.printGrid.RowTemplate.Height = 24;
            this.printGrid.Size = new System.Drawing.Size(880, 548);
            this.printGrid.TabIndex = 25;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 53.37201F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "fname";
            this.fname.FillWeight = 53.37201F;
            this.fname.HeaderText = "First Name";
            this.fname.MinimumWidth = 6;
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            // 
            // lname
            // 
            this.lname.DataPropertyName = "lname";
            this.lname.FillWeight = 53.37201F;
            this.lname.HeaderText = "Last Name";
            this.lname.MinimumWidth = 6;
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            // 
            // bdate
            // 
            this.bdate.DataPropertyName = "bdate";
            this.bdate.FillWeight = 53.37201F;
            this.bdate.HeaderText = "Birthday";
            this.bdate.MinimumWidth = 6;
            this.bdate.Name = "bdate";
            this.bdate.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.FillWeight = 53.37201F;
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.FillWeight = 53.37201F;
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.FillWeight = 53.37201F;
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // picture
            // 
            this.picture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.picture.DataPropertyName = "picture";
            this.picture.HeaderText = "Image";
            this.picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.picture.MinimumWidth = 6;
            this.picture.Name = "picture";
            this.picture.ReadOnly = true;
            this.picture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.picture.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radbtn_all);
            this.panel1.Controls.Add(this.radbtn_male);
            this.panel1.Controls.Add(this.radbtn_female);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 100);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datebetween);
            this.panel2.Controls.Add(this.usedaterange);
            this.panel2.Controls.Add(this.datetime1);
            this.panel2.Controls.Add(this.datetime2);
            this.panel2.Controls.Add(this.and);
            this.panel2.Controls.Add(this.radbtn_no);
            this.panel2.Controls.Add(this.radbtn_yes);
            this.panel2.Location = new System.Drawing.Point(275, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 100);
            this.panel2.TabIndex = 27;
            // 
            // st_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(904, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.printGrid);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.save);
            this.Controls.Add(this.btn_check);
            this.Name = "st_Print";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radbtn_no;
        private System.Windows.Forms.RadioButton radbtn_yes;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label and;
        private System.Windows.Forms.DateTimePicker datetime2;
        private System.Windows.Forms.DateTimePicker datetime1;
        private System.Windows.Forms.Label datebetween;
        private System.Windows.Forms.Label usedaterange;
        private System.Windows.Forms.RadioButton radbtn_female;
        private System.Windows.Forms.RadioButton radbtn_male;
        private System.Windows.Forms.RadioButton radbtn_all;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridView printGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewImageColumn picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}