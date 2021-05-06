
namespace WindowsFormsApp1
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.username_Box = new System.Windows.Forms.TextBox();
            this.password_Box = new System.Windows.Forms.TextBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.hr_radbtn = new System.Windows.Forms.RadioButton();
            this.student_radbtn = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_Box
            // 
            this.username_Box.BackColor = System.Drawing.Color.Black;
            this.username_Box.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.username_Box.ForeColor = System.Drawing.Color.White;
            this.username_Box.Location = new System.Drawing.Point(129, 47);
            this.username_Box.Margin = new System.Windows.Forms.Padding(2);
            this.username_Box.Name = "username_Box";
            this.username_Box.Size = new System.Drawing.Size(164, 24);
            this.username_Box.TabIndex = 0;
            this.toolTip1.SetToolTip(this.username_Box, "Nhap ten nguoi dung");
            this.username_Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.box_UserName_KeyDown);
            // 
            // password_Box
            // 
            this.password_Box.BackColor = System.Drawing.Color.Black;
            this.password_Box.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.password_Box.ForeColor = System.Drawing.Color.White;
            this.password_Box.Location = new System.Drawing.Point(129, 78);
            this.password_Box.Margin = new System.Windows.Forms.Padding(2);
            this.password_Box.Name = "password_Box";
            this.password_Box.Size = new System.Drawing.Size(164, 24);
            this.password_Box.TabIndex = 2;
            this.toolTip2.SetToolTip(this.password_Box, "Nhap mat khau");
            this.password_Box.UseSystemPasswordChar = true;
            this.password_Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.box_Password_KeyDown);
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_UserName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_UserName.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_UserName.Location = new System.Drawing.Point(41, 52);
            this.label_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(75, 19);
            this.label_UserName.TabIndex = 3;
            this.label_UserName.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Password.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Password.Location = new System.Drawing.Point(41, 80);
            this.label_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(71, 19);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "Password";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Black;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.login_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_btn.Location = new System.Drawing.Point(42, 145);
            this.login_btn.Margin = new System.Windows.Forms.Padding(2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(109, 30);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Log In";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Black;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(184, 145);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(109, 30);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Exit";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // register_btn
            // 
            this.register_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.register_btn.BackColor = System.Drawing.Color.Black;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.register_btn.ForeColor = System.Drawing.Color.Gray;
            this.register_btn.Location = new System.Drawing.Point(-1, 222);
            this.register_btn.Margin = new System.Windows.Forms.Padding(2);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(87, 27);
            this.register_btn.TabIndex = 7;
            this.register_btn.Text = "New user?";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Black;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.HighlightText;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hr_radbtn);
            this.panel1.Controls.Add(this.student_radbtn);
            this.panel1.Location = new System.Drawing.Point(42, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 22);
            this.panel1.TabIndex = 8;
            // 
            // hr_radbtn
            // 
            this.hr_radbtn.AutoSize = true;
            this.hr_radbtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hr_radbtn.ForeColor = System.Drawing.Color.White;
            this.hr_radbtn.Location = new System.Drawing.Point(139, 1);
            this.hr_radbtn.Name = "hr_radbtn";
            this.hr_radbtn.Size = new System.Drawing.Size(112, 18);
            this.hr_radbtn.TabIndex = 1;
            this.hr_radbtn.Text = "Human Resource";
            this.hr_radbtn.UseVisualStyleBackColor = true;
            // 
            // student_radbtn
            // 
            this.student_radbtn.AutoSize = true;
            this.student_radbtn.Checked = true;
            this.student_radbtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_radbtn.ForeColor = System.Drawing.Color.White;
            this.student_radbtn.Location = new System.Drawing.Point(0, 1);
            this.student_radbtn.Name = "student_radbtn";
            this.student_radbtn.Size = new System.Drawing.Size(66, 18);
            this.student_radbtn.TabIndex = 0;
            this.student_radbtn.Text = "Student";
            this.student_radbtn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(334, 248);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.username_Box);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.password_Box);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Login";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username_Box;
        private System.Windows.Forms.TextBox password_Box;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton hr_radbtn;
        private System.Windows.Forms.RadioButton student_radbtn;
    }
}

