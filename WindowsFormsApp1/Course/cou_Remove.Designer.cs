
namespace WindowsFormsApp1
{
    partial class cou_Remove
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
            this.RemoveCou_btn = new System.Windows.Forms.Button();
            this.cid_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoveCou_btn
            // 
            this.RemoveCou_btn.BackColor = System.Drawing.Color.Black;
            this.RemoveCou_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCou_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.RemoveCou_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveCou_btn.Location = new System.Drawing.Point(328, 31);
            this.RemoveCou_btn.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveCou_btn.Name = "RemoveCou_btn";
            this.RemoveCou_btn.Size = new System.Drawing.Size(90, 24);
            this.RemoveCou_btn.TabIndex = 22;
            this.RemoveCou_btn.Text = "Remove";
            this.RemoveCou_btn.UseVisualStyleBackColor = false;
            this.RemoveCou_btn.Click += new System.EventHandler(this.RemoveCou_btn_Click);
            // 
            // cid_Box
            // 
            this.cid_Box.BackColor = System.Drawing.Color.Black;
            this.cid_Box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.cid_Box.ForeColor = System.Drawing.Color.White;
            this.cid_Box.Location = new System.Drawing.Point(115, 31);
            this.cid_Box.Margin = new System.Windows.Forms.Padding(2);
            this.cid_Box.Name = "cid_Box";
            this.cid_Box.Size = new System.Drawing.Size(195, 21);
            this.cid_Box.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Course ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cou_Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(454, 89);
            this.Controls.Add(this.RemoveCou_btn);
            this.Controls.Add(this.cid_Box);
            this.Controls.Add(this.label1);
            this.Name = "cou_Remove";
            this.Text = "cou_Remove";
            this.Load += new System.EventHandler(this.cou_Remove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveCou_btn;
        private System.Windows.Forms.TextBox cid_Box;
        private System.Windows.Forms.Label label1;
    }
}