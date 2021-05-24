
namespace WindowsFormsApp1
{
    partial class cont_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contactGrid = new System.Windows.Forms.DataGridView();
            this.grouplist_Box = new System.Windows.Forms.ListBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contactGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contactGrid
            // 
            this.contactGrid.AllowUserToAddRows = false;
            this.contactGrid.AllowUserToDeleteRows = false;
            this.contactGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black;
            this.contactGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.contactGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactGrid.BackgroundColor = System.Drawing.Color.Black;
            this.contactGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contactGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.contactGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Group,
            this.Phone,
            this.Email,
            this.Address,
            this.Picture});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contactGrid.DefaultCellStyle = dataGridViewCellStyle13;
            this.contactGrid.EnableHeadersVisualStyles = false;
            this.contactGrid.GridColor = System.Drawing.Color.White;
            this.contactGrid.Location = new System.Drawing.Point(207, 19);
            this.contactGrid.Margin = new System.Windows.Forms.Padding(2);
            this.contactGrid.Name = "contactGrid";
            this.contactGrid.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Format = "d";
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contactGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.contactGrid.RowHeadersVisible = false;
            this.contactGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Black;
            this.contactGrid.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.contactGrid.RowTemplate.Height = 24;
            this.contactGrid.Size = new System.Drawing.Size(966, 308);
            this.contactGrid.TabIndex = 29;
            this.contactGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.printGrid_CellContentClick);
            // 
            // grouplist_Box
            // 
            this.grouplist_Box.BackColor = System.Drawing.Color.Black;
            this.grouplist_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouplist_Box.ForeColor = System.Drawing.Color.White;
            this.grouplist_Box.FormattingEnabled = true;
            this.grouplist_Box.ItemHeight = 16;
            this.grouplist_Box.Location = new System.Drawing.Point(12, 19);
            this.grouplist_Box.Name = "grouplist_Box";
            this.grouplist_Box.Size = new System.Drawing.Size(179, 308);
            this.grouplist_Box.TabIndex = 30;
            this.grouplist_Box.SelectedIndexChanged += new System.EventHandler(this.grouplist_Box_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "fname";
            this.FirstName.FillWeight = 90F;
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "lname";
            this.LastName.FillWeight = 90F;
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "groupname";
            this.Group.FillWeight = 80F;
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "phone";
            this.Phone.FillWeight = 90F;
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "address";
            this.Address.FillWeight = 120F;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "pic";
            this.Picture.FillWeight = 80F;
            this.Picture.HeaderText = "Picture";
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cont_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 341);
            this.Controls.Add(this.grouplist_Box);
            this.Controls.Add(this.contactGrid);
            this.Name = "cont_List";
            this.Text = "cont_List";
            this.Load += new System.EventHandler(this.cont_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView contactGrid;
        private System.Windows.Forms.ListBox grouplist_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
    }
}