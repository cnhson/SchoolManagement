
namespace WindowsFormsApp1
{
    partial class cou_Management
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
            this.courselist_Box = new System.Windows.Forms.ListBox();
            this.description_Box = new System.Windows.Forms.TextBox();
            this.clabel_Box = new System.Windows.Forms.TextBox();
            this.cid_Box = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.period_label = new System.Windows.Forms.Label();
            this.clabel_label = new System.Windows.Forms.Label();
            this.cid_label = new System.Windows.Forms.Label();
            this.cperiod_Box = new System.Windows.Forms.NumericUpDown();
            this.AddCou_btn = new System.Windows.Forms.Button();
            this.EditCou_btn = new System.Windows.Forms.Button();
            this.RemoveCou_btn = new System.Windows.Forms.Button();
            this.Next_btn = new System.Windows.Forms.Button();
            this.Previous_btn = new System.Windows.Forms.Button();
            this.First_btn = new System.Windows.Forms.Button();
            this.Last_btn = new System.Windows.Forms.Button();
            this.totalstudent_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cperiod_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // courselist_Box
            // 
            this.courselist_Box.BackColor = System.Drawing.Color.Black;
            this.courselist_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.courselist_Box.ForeColor = System.Drawing.Color.White;
            this.courselist_Box.FormattingEnabled = true;
            this.courselist_Box.Location = new System.Drawing.Point(461, 17);
            this.courselist_Box.Name = "courselist_Box";
            this.courselist_Box.Size = new System.Drawing.Size(242, 290);
            this.courselist_Box.TabIndex = 0;
            this.courselist_Box.Click += new System.EventHandler(this.courselist_Box_Click);
            // 
            // description_Box
            // 
            this.description_Box.BackColor = System.Drawing.Color.Black;
            this.description_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.description_Box.ForeColor = System.Drawing.Color.White;
            this.description_Box.Location = new System.Drawing.Point(140, 145);
            this.description_Box.Margin = new System.Windows.Forms.Padding(2);
            this.description_Box.Multiline = true;
            this.description_Box.Name = "description_Box";
            this.description_Box.Size = new System.Drawing.Size(300, 93);
            this.description_Box.TabIndex = 24;
            // 
            // clabel_Box
            // 
            this.clabel_Box.BackColor = System.Drawing.Color.Black;
            this.clabel_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.clabel_Box.ForeColor = System.Drawing.Color.White;
            this.clabel_Box.Location = new System.Drawing.Point(140, 58);
            this.clabel_Box.Margin = new System.Windows.Forms.Padding(2);
            this.clabel_Box.Name = "clabel_Box";
            this.clabel_Box.Size = new System.Drawing.Size(300, 21);
            this.clabel_Box.TabIndex = 23;
            // 
            // cid_Box
            // 
            this.cid_Box.BackColor = System.Drawing.Color.Black;
            this.cid_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.cid_Box.ForeColor = System.Drawing.Color.White;
            this.cid_Box.Location = new System.Drawing.Point(140, 17);
            this.cid_Box.Margin = new System.Windows.Forms.Padding(2);
            this.cid_Box.Name = "cid_Box";
            this.cid_Box.Size = new System.Drawing.Size(159, 21);
            this.cid_Box.TabIndex = 19;
            // 
            // description_label
            // 
            this.description_label.BackColor = System.Drawing.Color.Black;
            this.description_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.description_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.ForeColor = System.Drawing.Color.White;
            this.description_label.Location = new System.Drawing.Point(34, 145);
            this.description_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(90, 23);
            this.description_label.TabIndex = 20;
            this.description_label.Text = "Description";
            this.description_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // period_label
            // 
            this.period_label.BackColor = System.Drawing.Color.Black;
            this.period_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.period_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_label.ForeColor = System.Drawing.Color.White;
            this.period_label.Location = new System.Drawing.Point(34, 101);
            this.period_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.period_label.Name = "period_label";
            this.period_label.Size = new System.Drawing.Size(90, 23);
            this.period_label.TabIndex = 21;
            this.period_label.Text = "Period";
            this.period_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clabel_label
            // 
            this.clabel_label.BackColor = System.Drawing.Color.Black;
            this.clabel_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clabel_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clabel_label.ForeColor = System.Drawing.Color.White;
            this.clabel_label.Location = new System.Drawing.Point(33, 58);
            this.clabel_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clabel_label.Name = "clabel_label";
            this.clabel_label.Size = new System.Drawing.Size(90, 23);
            this.clabel_label.TabIndex = 22;
            this.clabel_label.Text = "Label";
            this.clabel_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cid_label
            // 
            this.cid_label.BackColor = System.Drawing.Color.Black;
            this.cid_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cid_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid_label.ForeColor = System.Drawing.Color.White;
            this.cid_label.Location = new System.Drawing.Point(34, 17);
            this.cid_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cid_label.Name = "cid_label";
            this.cid_label.Size = new System.Drawing.Size(90, 23);
            this.cid_label.TabIndex = 25;
            this.cid_label.Text = "Course ID";
            this.cid_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cperiod_Box
            // 
            this.cperiod_Box.BackColor = System.Drawing.Color.Black;
            this.cperiod_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.cperiod_Box.ForeColor = System.Drawing.Color.White;
            this.cperiod_Box.Location = new System.Drawing.Point(140, 102);
            this.cperiod_Box.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.cperiod_Box.Name = "cperiod_Box";
            this.cperiod_Box.Size = new System.Drawing.Size(159, 21);
            this.cperiod_Box.TabIndex = 31;
            this.cperiod_Box.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // AddCou_btn
            // 
            this.AddCou_btn.BackColor = System.Drawing.Color.Black;
            this.AddCou_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCou_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.AddCou_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddCou_btn.Location = new System.Drawing.Point(37, 308);
            this.AddCou_btn.Margin = new System.Windows.Forms.Padding(2);
            this.AddCou_btn.Name = "AddCou_btn";
            this.AddCou_btn.Size = new System.Drawing.Size(117, 30);
            this.AddCou_btn.TabIndex = 32;
            this.AddCou_btn.Text = "Add";
            this.AddCou_btn.UseVisualStyleBackColor = false;
            this.AddCou_btn.Click += new System.EventHandler(this.AddCou_btn_Click);
            // 
            // EditCou_btn
            // 
            this.EditCou_btn.BackColor = System.Drawing.Color.Black;
            this.EditCou_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCou_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.EditCou_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditCou_btn.Location = new System.Drawing.Point(182, 308);
            this.EditCou_btn.Margin = new System.Windows.Forms.Padding(2);
            this.EditCou_btn.Name = "EditCou_btn";
            this.EditCou_btn.Size = new System.Drawing.Size(117, 30);
            this.EditCou_btn.TabIndex = 33;
            this.EditCou_btn.Text = "Edit";
            this.EditCou_btn.UseVisualStyleBackColor = false;
            this.EditCou_btn.Click += new System.EventHandler(this.EditCou_btn_Click);
            // 
            // RemoveCou_btn
            // 
            this.RemoveCou_btn.BackColor = System.Drawing.Color.Black;
            this.RemoveCou_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCou_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.RemoveCou_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveCou_btn.Location = new System.Drawing.Point(324, 308);
            this.RemoveCou_btn.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveCou_btn.Name = "RemoveCou_btn";
            this.RemoveCou_btn.Size = new System.Drawing.Size(117, 30);
            this.RemoveCou_btn.TabIndex = 34;
            this.RemoveCou_btn.Text = "Remove";
            this.RemoveCou_btn.UseVisualStyleBackColor = false;
            this.RemoveCou_btn.Click += new System.EventHandler(this.RemoveCou_btn_Click);
            // 
            // Next_btn
            // 
            this.Next_btn.BackColor = System.Drawing.Color.Black;
            this.Next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Next_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Next_btn.Location = new System.Drawing.Point(140, 252);
            this.Next_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(96, 30);
            this.Next_btn.TabIndex = 37;
            this.Next_btn.Text = "Next";
            this.Next_btn.UseVisualStyleBackColor = false;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // Previous_btn
            // 
            this.Previous_btn.BackColor = System.Drawing.Color.Black;
            this.Previous_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Previous_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Previous_btn.Location = new System.Drawing.Point(243, 252);
            this.Previous_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Previous_btn.Name = "Previous_btn";
            this.Previous_btn.Size = new System.Drawing.Size(96, 30);
            this.Previous_btn.TabIndex = 36;
            this.Previous_btn.Text = "Previous";
            this.Previous_btn.UseVisualStyleBackColor = false;
            this.Previous_btn.Click += new System.EventHandler(this.Previous_btn_Click);
            // 
            // First_btn
            // 
            this.First_btn.BackColor = System.Drawing.Color.Black;
            this.First_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.First_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.First_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.First_btn.Location = new System.Drawing.Point(37, 252);
            this.First_btn.Margin = new System.Windows.Forms.Padding(2);
            this.First_btn.Name = "First_btn";
            this.First_btn.Size = new System.Drawing.Size(95, 30);
            this.First_btn.TabIndex = 35;
            this.First_btn.Text = "First";
            this.First_btn.UseVisualStyleBackColor = false;
            this.First_btn.Click += new System.EventHandler(this.First_btn_Click);
            // 
            // Last_btn
            // 
            this.Last_btn.BackColor = System.Drawing.Color.Black;
            this.Last_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Last_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Last_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Last_btn.Location = new System.Drawing.Point(346, 252);
            this.Last_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Last_btn.Name = "Last_btn";
            this.Last_btn.Size = new System.Drawing.Size(95, 30);
            this.Last_btn.TabIndex = 38;
            this.Last_btn.Text = "Last";
            this.Last_btn.UseVisualStyleBackColor = false;
            this.Last_btn.Click += new System.EventHandler(this.Last_btn_Click);
            // 
            // totalstudent_label
            // 
            this.totalstudent_label.BackColor = System.Drawing.Color.Black;
            this.totalstudent_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalstudent_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.totalstudent_label.ForeColor = System.Drawing.Color.White;
            this.totalstudent_label.Location = new System.Drawing.Point(543, 315);
            this.totalstudent_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalstudent_label.Name = "totalstudent_label";
            this.totalstudent_label.Size = new System.Drawing.Size(160, 37);
            this.totalstudent_label.TabIndex = 39;
            this.totalstudent_label.Text = "Total";
            this.totalstudent_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cou_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(727, 392);
            this.Controls.Add(this.totalstudent_label);
            this.Controls.Add(this.Last_btn);
            this.Controls.Add(this.Next_btn);
            this.Controls.Add(this.Previous_btn);
            this.Controls.Add(this.First_btn);
            this.Controls.Add(this.RemoveCou_btn);
            this.Controls.Add(this.EditCou_btn);
            this.Controls.Add(this.AddCou_btn);
            this.Controls.Add(this.cperiod_Box);
            this.Controls.Add(this.description_Box);
            this.Controls.Add(this.clabel_Box);
            this.Controls.Add(this.cid_Box);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.period_label);
            this.Controls.Add(this.clabel_label);
            this.Controls.Add(this.cid_label);
            this.Controls.Add(this.courselist_Box);
            this.Name = "cou_Management";
            this.Text = "cou_Manage";
            this.Load += new System.EventHandler(this.cou_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cperiod_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox courselist_Box;
        private System.Windows.Forms.TextBox description_Box;
        private System.Windows.Forms.TextBox clabel_Box;
        private System.Windows.Forms.TextBox cid_Box;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label period_label;
        private System.Windows.Forms.Label clabel_label;
        private System.Windows.Forms.Label cid_label;
        private System.Windows.Forms.NumericUpDown cperiod_Box;
        private System.Windows.Forms.Button AddCou_btn;
        private System.Windows.Forms.Button EditCou_btn;
        private System.Windows.Forms.Button RemoveCou_btn;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.Button Previous_btn;
        private System.Windows.Forms.Button First_btn;
        private System.Windows.Forms.Button Last_btn;
        private System.Windows.Forms.Label totalstudent_label;
    }
}