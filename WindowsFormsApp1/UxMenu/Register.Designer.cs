
namespace WindowsFormsApp1
{
    partial class Register
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.lname_Box = new System.Windows.Forms.TextBox();
            this.fname_Box = new System.Windows.Forms.TextBox();
            this.id_Box = new System.Windows.Forms.TextBox();
            this.lname_label = new System.Windows.Forms.Label();
            this.fname_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.password_Box = new System.Windows.Forms.TextBox();
            this.username_Box = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.upload_btn = new System.Windows.Forms.Button();
            this.picture_Box = new System.Windows.Forms.PictureBox();
            this.picture_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Black;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.Gray;
            this.cancel_btn.Location = new System.Drawing.Point(0, 605);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(239, 39);
            this.cancel_btn.TabIndex = 13;
            this.cancel_btn.Text = "Already have account? Click here to log in";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.reg_Cancel_Click);
            // 
            // register_btn
            // 
            this.register_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_btn.BackColor = System.Drawing.Color.Navy;
            this.register_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_btn.Location = new System.Drawing.Point(57, 531);
            this.register_btn.Margin = new System.Windows.Forms.Padding(2);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(299, 39);
            this.register_btn.TabIndex = 15;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // lname_Box
            // 
            this.lname_Box.BackColor = System.Drawing.Color.Black;
            this.lname_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_Box.ForeColor = System.Drawing.Color.White;
            this.lname_Box.Location = new System.Drawing.Point(177, 177);
            this.lname_Box.Margin = new System.Windows.Forms.Padding(2);
            this.lname_Box.Name = "lname_Box";
            this.lname_Box.Size = new System.Drawing.Size(180, 23);
            this.lname_Box.TabIndex = 20;
            // 
            // fname_Box
            // 
            this.fname_Box.BackColor = System.Drawing.Color.Black;
            this.fname_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_Box.ForeColor = System.Drawing.Color.White;
            this.fname_Box.Location = new System.Drawing.Point(177, 134);
            this.fname_Box.Margin = new System.Windows.Forms.Padding(2);
            this.fname_Box.Name = "fname_Box";
            this.fname_Box.Size = new System.Drawing.Size(180, 23);
            this.fname_Box.TabIndex = 19;
            // 
            // id_Box
            // 
            this.id_Box.BackColor = System.Drawing.Color.Black;
            this.id_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_Box.ForeColor = System.Drawing.Color.White;
            this.id_Box.Location = new System.Drawing.Point(177, 93);
            this.id_Box.Margin = new System.Windows.Forms.Padding(2);
            this.id_Box.Name = "id_Box";
            this.id_Box.Size = new System.Drawing.Size(180, 23);
            this.id_Box.TabIndex = 16;
            // 
            // lname_label
            // 
            this.lname_label.BackColor = System.Drawing.Color.Black;
            this.lname_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lname_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_label.ForeColor = System.Drawing.Color.White;
            this.lname_label.Location = new System.Drawing.Point(55, 178);
            this.lname_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(90, 23);
            this.lname_label.TabIndex = 17;
            this.lname_label.Text = "Last Name";
            this.lname_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fname_label
            // 
            this.fname_label.BackColor = System.Drawing.Color.Black;
            this.fname_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fname_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_label.ForeColor = System.Drawing.Color.White;
            this.fname_label.Location = new System.Drawing.Point(55, 134);
            this.fname_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(90, 23);
            this.fname_label.TabIndex = 18;
            this.fname_label.Text = "First Name";
            this.fname_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // id_label
            // 
            this.id_label.BackColor = System.Drawing.Color.Black;
            this.id_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.Location = new System.Drawing.Point(55, 93);
            this.id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(90, 23);
            this.id_label.TabIndex = 21;
            this.id_label.Text = "ID";
            this.id_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // password_Box
            // 
            this.password_Box.BackColor = System.Drawing.Color.Black;
            this.password_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_Box.ForeColor = System.Drawing.Color.White;
            this.password_Box.Location = new System.Drawing.Point(177, 259);
            this.password_Box.Margin = new System.Windows.Forms.Padding(2);
            this.password_Box.Name = "password_Box";
            this.password_Box.Size = new System.Drawing.Size(180, 23);
            this.password_Box.TabIndex = 25;
            // 
            // username_Box
            // 
            this.username_Box.BackColor = System.Drawing.Color.Black;
            this.username_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_Box.ForeColor = System.Drawing.Color.White;
            this.username_Box.Location = new System.Drawing.Point(177, 216);
            this.username_Box.Margin = new System.Windows.Forms.Padding(2);
            this.username_Box.Name = "username_Box";
            this.username_Box.Size = new System.Drawing.Size(180, 23);
            this.username_Box.TabIndex = 24;
            // 
            // password_label
            // 
            this.password_label.BackColor = System.Drawing.Color.Black;
            this.password_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(55, 260);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(90, 23);
            this.password_label.TabIndex = 22;
            this.password_label.Text = "Password";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // username_label
            // 
            this.username_label.BackColor = System.Drawing.Color.Black;
            this.username_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.username_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(55, 217);
            this.username_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(90, 23);
            this.username_label.TabIndex = 23;
            this.username_label.Text = "Username";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // upload_btn
            // 
            this.upload_btn.BackColor = System.Drawing.Color.Black;
            this.upload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.upload_btn.Location = new System.Drawing.Point(177, 476);
            this.upload_btn.Margin = new System.Windows.Forms.Padding(2);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(180, 25);
            this.upload_btn.TabIndex = 28;
            this.upload_btn.Text = "Upload";
            this.upload_btn.UseVisualStyleBackColor = false;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // picture_Box
            // 
            this.picture_Box.BackColor = System.Drawing.Color.Black;
            this.picture_Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_Box.Location = new System.Drawing.Point(177, 308);
            this.picture_Box.Margin = new System.Windows.Forms.Padding(2);
            this.picture_Box.Name = "picture_Box";
            this.picture_Box.Size = new System.Drawing.Size(180, 150);
            this.picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Box.TabIndex = 27;
            this.picture_Box.TabStop = false;
            // 
            // picture_label
            // 
            this.picture_label.BackColor = System.Drawing.Color.Black;
            this.picture_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.picture_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picture_label.ForeColor = System.Drawing.Color.White;
            this.picture_label.Location = new System.Drawing.Point(54, 308);
            this.picture_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.picture_label.Name = "picture_label";
            this.picture_label.Size = new System.Drawing.Size(90, 23);
            this.picture_label.TabIndex = 26;
            this.picture_label.Text = "Picture";
            this.picture_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // title_label
            // 
            this.title_label.BackColor = System.Drawing.Color.Black;
            this.title_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(11, 19);
            this.title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(392, 44);
            this.title_label.TabIndex = 29;
            this.title_label.Text = "Create new account";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(414, 645);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.upload_btn);
            this.Controls.Add(this.picture_Box);
            this.Controls.Add(this.picture_label);
            this.Controls.Add(this.password_Box);
            this.Controls.Add(this.username_Box);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.lname_Box);
            this.Controls.Add(this.fname_Box);
            this.Controls.Add(this.id_Box);
            this.Controls.Add(this.lname_label);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.cancel_btn);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Register";
            this.ShowIcon = false;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox lname_Box;
        private System.Windows.Forms.TextBox fname_Box;
        private System.Windows.Forms.TextBox id_Box;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox password_Box;
        private System.Windows.Forms.TextBox username_Box;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.PictureBox picture_Box;
        private System.Windows.Forms.Label picture_label;
        private System.Windows.Forms.Label title_label;
    }
}