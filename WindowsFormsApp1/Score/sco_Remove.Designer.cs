
namespace WindowsFormsApp1
{
    partial class sco_Remove
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
            this.printGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveSco_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.printGrid)).BeginInit();
            this.SuspendLayout();
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
            this.printGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.printGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.CID,
            this.Clabel,
            this.Score});
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
            this.printGrid.Location = new System.Drawing.Point(11, 11);
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
            this.printGrid.Size = new System.Drawing.Size(778, 374);
            this.printGrid.TabIndex = 32;
            this.printGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.printGrid_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "cid";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "fname";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "lname";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // CID
            // 
            this.CID.DataPropertyName = "cid";
            this.CID.HeaderText = "Course ID";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            // 
            // Clabel
            // 
            this.Clabel.DataPropertyName = "clabel";
            this.Clabel.HeaderText = "Course Label";
            this.Clabel.Name = "Clabel";
            this.Clabel.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.DataPropertyName = "score";
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // RemoveSco_btn
            // 
            this.RemoveSco_btn.BackColor = System.Drawing.Color.Black;
            this.RemoveSco_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSco_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.RemoveSco_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveSco_btn.Location = new System.Drawing.Point(320, 409);
            this.RemoveSco_btn.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveSco_btn.Name = "RemoveSco_btn";
            this.RemoveSco_btn.Size = new System.Drawing.Size(159, 30);
            this.RemoveSco_btn.TabIndex = 33;
            this.RemoveSco_btn.Text = "Remove";
            this.RemoveSco_btn.UseVisualStyleBackColor = false;
            this.RemoveSco_btn.Click += new System.EventHandler(this.RemoveSco_btn_Click);
            // 
            // sco_Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveSco_btn);
            this.Controls.Add(this.printGrid);
            this.Name = "sco_Remove";
            this.Text = "sco_Remove";
            this.Load += new System.EventHandler(this.sco_Remove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView printGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.Button RemoveSco_btn;
    }
}