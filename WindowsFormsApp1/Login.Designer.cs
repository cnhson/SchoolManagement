
namespace WindowsFormsApp1
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.box_UserName = new System.Windows.Forms.TextBox();
            this.box_Password = new System.Windows.Forms.TextBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box_UserName
            // 
            this.box_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_UserName.Location = new System.Drawing.Point(211, 61);
            this.box_UserName.Name = "box_UserName";
            this.box_UserName.Size = new System.Drawing.Size(166, 24);
            this.box_UserName.TabIndex = 0;
            this.box_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.box_UserName_KeyDown);
            // 
            // box_Password
            // 
            this.box_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Password.Location = new System.Drawing.Point(211, 96);
            this.box_Password.Name = "box_Password";
            this.box_Password.Size = new System.Drawing.Size(166, 24);
            this.box_Password.TabIndex = 2;
            this.box_Password.UseSystemPasswordChar = true;
            this.box_Password.TextChanged += new System.EventHandler(this.box_Password_TextChanged);
            this.box_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.box_Password_KeyDown);
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_UserName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_UserName.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_UserName.Location = new System.Drawing.Point(56, 64);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(100, 21);
            this.label_UserName.TabIndex = 3;
            this.label_UserName.Text = "User Name";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Password.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_Password.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Password.Location = new System.Drawing.Point(56, 99);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(90, 21);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "Password";
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogIn.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_LogIn.Location = new System.Drawing.Point(60, 164);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(99, 48);
            this.btn_LogIn.TabIndex = 5;
            this.btn_LogIn.Text = "Log In";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(278, 164);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(99, 48);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.box_UserName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.box_Password);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Login";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox box_UserName;
        private System.Windows.Forms.TextBox box_Password;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Button btn_Cancel;
    }
}

