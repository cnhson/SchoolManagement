
namespace WindowsFormsApp1
{
    partial class sco_Result
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
            this.resultgrid = new System.Windows.Forms.DataGridView();
            this.save_btn = new System.Windows.Forms.Button();
            this.lname_Box = new System.Windows.Forms.TextBox();
            this.fname_Box = new System.Windows.Forms.TextBox();
            this.id_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search_Box = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.search_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.resultgrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultgrid
            // 
            this.resultgrid.AllowUserToAddRows = false;
            this.resultgrid.AllowUserToDeleteRows = false;
            this.resultgrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.resultgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.resultgrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultgrid.BackgroundColor = System.Drawing.Color.Black;
            this.resultgrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.resultgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.resultgrid.EnableHeadersVisualStyles = false;
            this.resultgrid.GridColor = System.Drawing.Color.White;
            this.resultgrid.Location = new System.Drawing.Point(277, 21);
            this.resultgrid.Margin = new System.Windows.Forms.Padding(2);
            this.resultgrid.Name = "resultgrid";
            this.resultgrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.resultgrid.RowHeadersVisible = false;
            this.resultgrid.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            this.resultgrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.resultgrid.RowTemplate.Height = 24;
            this.resultgrid.Size = new System.Drawing.Size(618, 343);
            this.resultgrid.TabIndex = 30;
            this.resultgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultgrid_CellContentClick);
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.BackColor = System.Drawing.Color.Black;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.save_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.save_btn.Location = new System.Drawing.Point(86, 332);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(123, 32);
            this.save_btn.TabIndex = 31;
            this.save_btn.Text = "Save to Word";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // lname_Box
            // 
            this.lname_Box.BackColor = System.Drawing.Color.Black;
            this.lname_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.lname_Box.ForeColor = System.Drawing.Color.White;
            this.lname_Box.Location = new System.Drawing.Point(94, 110);
            this.lname_Box.Margin = new System.Windows.Forms.Padding(2);
            this.lname_Box.Name = "lname_Box";
            this.lname_Box.Size = new System.Drawing.Size(128, 21);
            this.lname_Box.TabIndex = 36;
            // 
            // fname_Box
            // 
            this.fname_Box.BackColor = System.Drawing.Color.Black;
            this.fname_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.fname_Box.ForeColor = System.Drawing.Color.White;
            this.fname_Box.Location = new System.Drawing.Point(94, 67);
            this.fname_Box.Margin = new System.Windows.Forms.Padding(2);
            this.fname_Box.Name = "fname_Box";
            this.fname_Box.Size = new System.Drawing.Size(128, 21);
            this.fname_Box.TabIndex = 35;
            // 
            // id_Box
            // 
            this.id_Box.BackColor = System.Drawing.Color.Black;
            this.id_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.id_Box.ForeColor = System.Drawing.Color.White;
            this.id_Box.Location = new System.Drawing.Point(93, 29);
            this.id_Box.Margin = new System.Windows.Forms.Padding(2);
            this.id_Box.Name = "id_Box";
            this.id_Box.Size = new System.Drawing.Size(128, 21);
            this.id_Box.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Last Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "First Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Student ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // search_Box
            // 
            this.search_Box.BackColor = System.Drawing.Color.Black;
            this.search_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.search_Box.ForeColor = System.Drawing.Color.White;
            this.search_Box.Location = new System.Drawing.Point(12, 216);
            this.search_Box.Margin = new System.Windows.Forms.Padding(2);
            this.search_Box.Name = "search_Box";
            this.search_Box.Size = new System.Drawing.Size(126, 21);
            this.search_Box.TabIndex = 39;
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.Black;
            this.find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.find.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.find.Location = new System.Drawing.Point(153, 215);
            this.find.Margin = new System.Windows.Forms.Padding(2);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(69, 21);
            this.find.TabIndex = 38;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // search_label
            // 
            this.search_label.BackColor = System.Drawing.Color.Black;
            this.search_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.search_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search_label.Location = new System.Drawing.Point(9, 172);
            this.search_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(176, 23);
            this.search_label.TabIndex = 40;
            this.search_label.Text = "Search ID or First name:";
            this.search_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.search_Box);
            this.panel1.Controls.Add(this.find);
            this.panel1.Controls.Add(this.id_Box);
            this.panel1.Controls.Add(this.search_label);
            this.panel1.Controls.Add(this.lname_Box);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fname_Box);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 276);
            this.panel1.TabIndex = 42;
            // 
            // sco_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(926, 388);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.resultgrid);
            this.Controls.Add(this.panel1);
            this.Name = "sco_Result";
            this.Text = "sco_Result";
            this.Load += new System.EventHandler(this.sco_Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultgrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView resultgrid;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox lname_Box;
        private System.Windows.Forms.TextBox fname_Box;
        private System.Windows.Forms.TextBox id_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_Box;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Panel panel1;
    }
}