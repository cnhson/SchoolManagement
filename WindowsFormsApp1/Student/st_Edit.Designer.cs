
namespace WindowsFormsApp1
{
    partial class st_Edit
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
            this.bdatemg_Box = new System.Windows.Forms.DateTimePicker();
            this.femalemg_Box = new System.Windows.Forms.RadioButton();
            this.remove_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.Uploadbtn = new System.Windows.Forms.Button();
            this.mgpicture = new System.Windows.Forms.PictureBox();
            this.malemg_Box = new System.Windows.Forms.RadioButton();
            this.addressmg_Box = new System.Windows.Forms.TextBox();
            this.phonemg_Box = new System.Windows.Forms.TextBox();
            this.lnamemg_Box = new System.Windows.Forms.TextBox();
            this.fnamemg_Box = new System.Windows.Forms.TextBox();
            this.idmg_Box = new System.Windows.Forms.TextBox();
            this.picture_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.bdate_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.gender_label = new System.Windows.Forms.Label();
            this.fname_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mgpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bdatemg_Box
            // 
            this.bdatemg_Box.CalendarFont = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdatemg_Box.CalendarForeColor = System.Drawing.Color.Black;
            this.bdatemg_Box.CalendarMonthBackground = System.Drawing.Color.Black;
            this.bdatemg_Box.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bdatemg_Box.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.bdatemg_Box.CustomFormat = "           dd / MM / yyyy";
            this.bdatemg_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.bdatemg_Box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bdatemg_Box.Location = new System.Drawing.Point(130, 144);
            this.bdatemg_Box.Margin = new System.Windows.Forms.Padding(2);
            this.bdatemg_Box.MaxDate = new System.DateTime(2005, 12, 12, 0, 0, 0, 0);
            this.bdatemg_Box.Name = "bdatemg_Box";
            this.bdatemg_Box.RightToLeftLayout = true;
            this.bdatemg_Box.Size = new System.Drawing.Size(151, 21);
            this.bdatemg_Box.TabIndex = 52;
            this.bdatemg_Box.Value = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            // 
            // femalemg_Box
            // 
            this.femalemg_Box.AutoSize = true;
            this.femalemg_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.femalemg_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.femalemg_Box.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.femalemg_Box.Location = new System.Drawing.Point(294, 182);
            this.femalemg_Box.Margin = new System.Windows.Forms.Padding(2);
            this.femalemg_Box.Name = "femalemg_Box";
            this.femalemg_Box.Size = new System.Drawing.Size(61, 17);
            this.femalemg_Box.TabIndex = 40;
            this.femalemg_Box.TabStop = true;
            this.femalemg_Box.Text = "Female";
            this.femalemg_Box.UseVisualStyleBackColor = true;
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.Black;
            this.remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.remove_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.remove_btn.Location = new System.Drawing.Point(280, 598);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(2);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(108, 30);
            this.remove_btn.TabIndex = 45;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Black;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.edit_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edit_btn.Location = new System.Drawing.Point(131, 598);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(107, 30);
            this.edit_btn.TabIndex = 44;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // Uploadbtn
            // 
            this.Uploadbtn.BackColor = System.Drawing.Color.Black;
            this.Uploadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uploadbtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Uploadbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Uploadbtn.Location = new System.Drawing.Point(130, 560);
            this.Uploadbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Uploadbtn.Name = "Uploadbtn";
            this.Uploadbtn.Size = new System.Drawing.Size(258, 25);
            this.Uploadbtn.TabIndex = 43;
            this.Uploadbtn.Text = "Upload";
            this.Uploadbtn.UseVisualStyleBackColor = false;
            this.Uploadbtn.Click += new System.EventHandler(this.Uploadbtn_Click);
            // 
            // mgpicture
            // 
            this.mgpicture.BackColor = System.Drawing.Color.Black;
            this.mgpicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mgpicture.Location = new System.Drawing.Point(130, 344);
            this.mgpicture.Margin = new System.Windows.Forms.Padding(2);
            this.mgpicture.Name = "mgpicture";
            this.mgpicture.Size = new System.Drawing.Size(258, 200);
            this.mgpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mgpicture.TabIndex = 38;
            this.mgpicture.TabStop = false;
            // 
            // malemg_Box
            // 
            this.malemg_Box.AutoSize = true;
            this.malemg_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.malemg_Box.Checked = true;
            this.malemg_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.malemg_Box.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.malemg_Box.Location = new System.Drawing.Point(172, 182);
            this.malemg_Box.Margin = new System.Windows.Forms.Padding(2);
            this.malemg_Box.Name = "malemg_Box";
            this.malemg_Box.Size = new System.Drawing.Size(49, 17);
            this.malemg_Box.TabIndex = 39;
            this.malemg_Box.TabStop = true;
            this.malemg_Box.Text = "Male";
            this.malemg_Box.UseVisualStyleBackColor = true;
            // 
            // addressmg_Box
            // 
            this.addressmg_Box.BackColor = System.Drawing.Color.Black;
            this.addressmg_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.addressmg_Box.ForeColor = System.Drawing.Color.White;
            this.addressmg_Box.Location = new System.Drawing.Point(130, 256);
            this.addressmg_Box.Margin = new System.Windows.Forms.Padding(2);
            this.addressmg_Box.Multiline = true;
            this.addressmg_Box.Name = "addressmg_Box";
            this.addressmg_Box.Size = new System.Drawing.Size(258, 74);
            this.addressmg_Box.TabIndex = 42;
            // 
            // phonemg_Box
            // 
            this.phonemg_Box.BackColor = System.Drawing.Color.Black;
            this.phonemg_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.phonemg_Box.ForeColor = System.Drawing.Color.White;
            this.phonemg_Box.Location = new System.Drawing.Point(130, 218);
            this.phonemg_Box.Margin = new System.Windows.Forms.Padding(2);
            this.phonemg_Box.Name = "phonemg_Box";
            this.phonemg_Box.Size = new System.Drawing.Size(258, 21);
            this.phonemg_Box.TabIndex = 41;
            // 
            // lnamemg_Box
            // 
            this.lnamemg_Box.BackColor = System.Drawing.Color.Black;
            this.lnamemg_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.lnamemg_Box.ForeColor = System.Drawing.Color.White;
            this.lnamemg_Box.Location = new System.Drawing.Point(130, 102);
            this.lnamemg_Box.Margin = new System.Windows.Forms.Padding(2);
            this.lnamemg_Box.Name = "lnamemg_Box";
            this.lnamemg_Box.Size = new System.Drawing.Size(258, 21);
            this.lnamemg_Box.TabIndex = 37;
            // 
            // fnamemg_Box
            // 
            this.fnamemg_Box.BackColor = System.Drawing.Color.Black;
            this.fnamemg_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.fnamemg_Box.ForeColor = System.Drawing.Color.White;
            this.fnamemg_Box.Location = new System.Drawing.Point(130, 59);
            this.fnamemg_Box.Margin = new System.Windows.Forms.Padding(2);
            this.fnamemg_Box.Name = "fnamemg_Box";
            this.fnamemg_Box.Size = new System.Drawing.Size(258, 21);
            this.fnamemg_Box.TabIndex = 36;
            // 
            // idmg_Box
            // 
            this.idmg_Box.BackColor = System.Drawing.Color.Black;
            this.idmg_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.idmg_Box.ForeColor = System.Drawing.Color.White;
            this.idmg_Box.Location = new System.Drawing.Point(130, 18);
            this.idmg_Box.Margin = new System.Windows.Forms.Padding(2);
            this.idmg_Box.Name = "idmg_Box";
            this.idmg_Box.Size = new System.Drawing.Size(151, 21);
            this.idmg_Box.TabIndex = 34;
            // 
            // picture_label
            // 
            this.picture_label.BackColor = System.Drawing.Color.Black;
            this.picture_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.picture_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picture_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.picture_label.Location = new System.Drawing.Point(23, 344);
            this.picture_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.picture_label.Name = "picture_label";
            this.picture_label.Size = new System.Drawing.Size(90, 23);
            this.picture_label.TabIndex = 35;
            this.picture_label.Text = "Picture";
            this.picture_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // address_label
            // 
            this.address_label.BackColor = System.Drawing.Color.Black;
            this.address_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.address_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.address_label.Location = new System.Drawing.Point(24, 256);
            this.address_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(90, 23);
            this.address_label.TabIndex = 33;
            this.address_label.Text = "Address";
            this.address_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bdate_label
            // 
            this.bdate_label.BackColor = System.Drawing.Color.Black;
            this.bdate_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bdate_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bdate_label.Location = new System.Drawing.Point(24, 142);
            this.bdate_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bdate_label.Name = "bdate_label";
            this.bdate_label.Size = new System.Drawing.Size(90, 23);
            this.bdate_label.TabIndex = 49;
            this.bdate_label.Text = "Birthday";
            this.bdate_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phone_label
            // 
            this.phone_label.BackColor = System.Drawing.Color.Black;
            this.phone_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phone_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.phone_label.Location = new System.Drawing.Point(24, 218);
            this.phone_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(90, 23);
            this.phone_label.TabIndex = 51;
            this.phone_label.Text = "Phone";
            this.phone_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lname_label
            // 
            this.lname_label.BackColor = System.Drawing.Color.Black;
            this.lname_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lname_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lname_label.Location = new System.Drawing.Point(24, 102);
            this.lname_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(90, 23);
            this.lname_label.TabIndex = 48;
            this.lname_label.Text = "Last Name";
            this.lname_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gender_label
            // 
            this.gender_label.BackColor = System.Drawing.Color.Black;
            this.gender_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gender_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gender_label.Location = new System.Drawing.Point(24, 181);
            this.gender_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(90, 23);
            this.gender_label.TabIndex = 50;
            this.gender_label.Text = "Gender";
            this.gender_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fname_label
            // 
            this.fname_label.BackColor = System.Drawing.Color.Black;
            this.fname_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fname_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fname_label.Location = new System.Drawing.Point(23, 59);
            this.fname_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(90, 23);
            this.fname_label.TabIndex = 47;
            this.fname_label.Text = "First Name";
            this.fname_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // id_label
            // 
            this.id_label.BackColor = System.Drawing.Color.Black;
            this.id_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.id_label.Location = new System.Drawing.Point(24, 18);
            this.id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(90, 23);
            this.id_label.TabIndex = 46;
            this.id_label.Text = "Student ID";
            this.id_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.Black;
            this.find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.find.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.find.Location = new System.Drawing.Point(294, 18);
            this.find.Margin = new System.Windows.Forms.Padding(2);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(96, 21);
            this.find.TabIndex = 53;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // st_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(509, 693);
            this.Controls.Add(this.find);
            this.Controls.Add(this.bdatemg_Box);
            this.Controls.Add(this.femalemg_Box);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.Uploadbtn);
            this.Controls.Add(this.mgpicture);
            this.Controls.Add(this.malemg_Box);
            this.Controls.Add(this.addressmg_Box);
            this.Controls.Add(this.phonemg_Box);
            this.Controls.Add(this.lnamemg_Box);
            this.Controls.Add(this.fnamemg_Box);
            this.Controls.Add(this.idmg_Box);
            this.Controls.Add(this.picture_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.bdate_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.lname_label);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.id_label);
            this.Name = "st_Edit";
            this.Text = "st_Edit";
            this.Load += new System.EventHandler(this.st_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker bdatemg_Box;
        private System.Windows.Forms.RadioButton femalemg_Box;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button Uploadbtn;
        private System.Windows.Forms.PictureBox mgpicture;
        private System.Windows.Forms.RadioButton malemg_Box;
        private System.Windows.Forms.TextBox addressmg_Box;
        private System.Windows.Forms.TextBox phonemg_Box;
        private System.Windows.Forms.TextBox lnamemg_Box;
        private System.Windows.Forms.TextBox fnamemg_Box;
        private System.Windows.Forms.TextBox idmg_Box;
        private System.Windows.Forms.Label picture_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label bdate_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Button find;
    }
}