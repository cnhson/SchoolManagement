
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
            this.reg_Username = new System.Windows.Forms.TextBox();
            this.reg_Cancel = new System.Windows.Forms.Button();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.reg_Password = new System.Windows.Forms.TextBox();
            this.reg_Create = new System.Windows.Forms.Button();
            this.reg_repassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reg_Username
            // 
            this.reg_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_Username.Location = new System.Drawing.Point(170, 26);
            this.reg_Username.Margin = new System.Windows.Forms.Padding(2);
            this.reg_Username.Name = "reg_Username";
            this.reg_Username.Size = new System.Drawing.Size(125, 21);
            this.reg_Username.TabIndex = 8;
            // 
            // reg_Cancel
            // 
            this.reg_Cancel.BackColor = System.Drawing.Color.Blue;
            this.reg_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reg_Cancel.Location = new System.Drawing.Point(215, 149);
            this.reg_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.reg_Cancel.Name = "reg_Cancel";
            this.reg_Cancel.Size = new System.Drawing.Size(74, 39);
            this.reg_Cancel.TabIndex = 13;
            this.reg_Cancel.Text = "Cancel";
            this.reg_Cancel.UseVisualStyleBackColor = false;
            this.reg_Cancel.Click += new System.EventHandler(this.reg_Cancel_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.Black;
            this.label_Password.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Password.Location = new System.Drawing.Point(44, 62);
            this.label_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(75, 18);
            this.label_Password.TabIndex = 11;
            this.label_Password.Text = "Password";
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.BackColor = System.Drawing.Color.Black;
            this.label_UserName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_UserName.Location = new System.Drawing.Point(44, 31);
            this.label_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(84, 18);
            this.label_UserName.TabIndex = 10;
            this.label_UserName.Text = "User Name";
            // 
            // reg_Password
            // 
            this.reg_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_Password.Location = new System.Drawing.Point(170, 57);
            this.reg_Password.Margin = new System.Windows.Forms.Padding(2);
            this.reg_Password.Name = "reg_Password";
            this.reg_Password.Size = new System.Drawing.Size(125, 21);
            this.reg_Password.TabIndex = 9;
            this.reg_Password.UseSystemPasswordChar = true;
            // 
            // reg_Create
            // 
            this.reg_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reg_Create.BackColor = System.Drawing.Color.Blue;
            this.reg_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_Create.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reg_Create.Location = new System.Drawing.Point(47, 149);
            this.reg_Create.Margin = new System.Windows.Forms.Padding(2);
            this.reg_Create.Name = "reg_Create";
            this.reg_Create.Size = new System.Drawing.Size(74, 39);
            this.reg_Create.TabIndex = 15;
            this.reg_Create.Text = "Create";
            this.reg_Create.UseVisualStyleBackColor = false;
            this.reg_Create.Click += new System.EventHandler(this.reg_Create_Click);
            // 
            // reg_repassword
            // 
            this.reg_repassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_repassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_repassword.Location = new System.Drawing.Point(170, 90);
            this.reg_repassword.Margin = new System.Windows.Forms.Padding(2);
            this.reg_repassword.Name = "reg_repassword";
            this.reg_repassword.Size = new System.Drawing.Size(125, 21);
            this.reg_repassword.TabIndex = 9;
            this.reg_repassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(44, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Re-Password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.reg_Create);
            this.Controls.Add(this.reg_Username);
            this.Controls.Add(this.reg_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.reg_repassword);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.reg_Password);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Register";
            this.ShowIcon = false;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox reg_Username;
        private System.Windows.Forms.Button reg_Cancel;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox reg_Password;
        private System.Windows.Forms.Button reg_Create;
        private System.Windows.Forms.TextBox reg_repassword;
        private System.Windows.Forms.Label label1;
    }
}