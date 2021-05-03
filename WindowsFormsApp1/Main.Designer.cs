
namespace WindowsFormsApp1
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.addcourse_item = new System.Windows.Forms.ToolStripMenuItem();
            this.removecourse_item = new System.Windows.Forms.ToolStripMenuItem();
            this.editcourse_item = new System.Windows.Forms.ToolStripMenuItem();
            this.managecourse_item = new System.Windows.Forms.ToolStripMenuItem();
            this.printcourse_item = new System.Windows.Forms.ToolStripMenuItem();
            this.addscore_item = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.managescore_item = new System.Windows.Forms.ToolStripMenuItem();
            this.printscore_item = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.avgscore_item = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTToolStripMenuItem,
            this.toolStripMenuItem7,
            this.addscore_item});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(484, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.AutoSize = false;
            this.sTUDENTToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.sTUDENTToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sTUDENTToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.exitToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTUDENTToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sTUDENTToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(122, 50);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem1.Text = "Add Student";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem2.Text = "Students List";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem4.Text = "Statics";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem3.Text = "Edit / Remove";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem5.Text = "Manage Student Form";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem6.Text = "Print";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.AutoSize = false;
            this.toolStripMenuItem7.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addcourse_item,
            this.removecourse_item,
            this.editcourse_item,
            this.managecourse_item,
            this.printcourse_item});
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem7.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem7.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(122, 50);
            this.toolStripMenuItem7.Text = "COURSE";
            // 
            // addcourse_item
            // 
            this.addcourse_item.BackColor = System.Drawing.Color.Black;
            this.addcourse_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addcourse_item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addcourse_item.ForeColor = System.Drawing.Color.White;
            this.addcourse_item.Name = "addcourse_item";
            this.addcourse_item.Size = new System.Drawing.Size(156, 22);
            this.addcourse_item.Text = "Add Course";
            this.addcourse_item.Click += new System.EventHandler(this.addcourse_item_Click);
            // 
            // removecourse_item
            // 
            this.removecourse_item.BackColor = System.Drawing.Color.Black;
            this.removecourse_item.ForeColor = System.Drawing.Color.White;
            this.removecourse_item.Name = "removecourse_item";
            this.removecourse_item.Size = new System.Drawing.Size(156, 22);
            this.removecourse_item.Text = "Remove Course";
            this.removecourse_item.Click += new System.EventHandler(this.removecourse_item_Click);
            // 
            // editcourse_item
            // 
            this.editcourse_item.BackColor = System.Drawing.Color.Black;
            this.editcourse_item.ForeColor = System.Drawing.Color.White;
            this.editcourse_item.Name = "editcourse_item";
            this.editcourse_item.Size = new System.Drawing.Size(156, 22);
            this.editcourse_item.Text = "Edit Course";
            this.editcourse_item.Click += new System.EventHandler(this.editcourse_item_Click);
            // 
            // managecourse_item
            // 
            this.managecourse_item.BackColor = System.Drawing.Color.Black;
            this.managecourse_item.ForeColor = System.Drawing.Color.White;
            this.managecourse_item.Name = "managecourse_item";
            this.managecourse_item.Size = new System.Drawing.Size(156, 22);
            this.managecourse_item.Text = "Manage Course";
            this.managecourse_item.Click += new System.EventHandler(this.managecourse_item_Click);
            // 
            // printcourse_item
            // 
            this.printcourse_item.BackColor = System.Drawing.Color.Black;
            this.printcourse_item.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.printcourse_item.Name = "printcourse_item";
            this.printcourse_item.Size = new System.Drawing.Size(156, 22);
            this.printcourse_item.Text = "Print";
            this.printcourse_item.Click += new System.EventHandler(this.printcourse_item_Click);
            // 
            // addscore_item
            // 
            this.addscore_item.AutoSize = false;
            this.addscore_item.BackColor = System.Drawing.Color.Black;
            this.addscore_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addscore_item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addscore_item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.managescore_item,
            this.avgscore_item,
            this.printscore_item});
            this.addscore_item.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addscore_item.ForeColor = System.Drawing.Color.White;
            this.addscore_item.ImageTransparentColor = System.Drawing.Color.White;
            this.addscore_item.Name = "addscore_item";
            this.addscore_item.Size = new System.Drawing.Size(122, 50);
            this.addscore_item.Text = "SCORE";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem9.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem9.Text = "Add Score";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem10.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem10.Text = "Remove Score";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // managescore_item
            // 
            this.managescore_item.BackColor = System.Drawing.Color.Black;
            this.managescore_item.ForeColor = System.Drawing.Color.White;
            this.managescore_item.Name = "managescore_item";
            this.managescore_item.Size = new System.Drawing.Size(203, 22);
            this.managescore_item.Text = "Manage Score";
            this.managescore_item.Click += new System.EventHandler(this.managescore_item_Click);
            // 
            // printscore_item
            // 
            this.printscore_item.BackColor = System.Drawing.Color.Black;
            this.printscore_item.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.printscore_item.Name = "printscore_item";
            this.printscore_item.Size = new System.Drawing.Size(203, 22);
            this.printscore_item.Text = "Print";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.button1.Location = new System.Drawing.Point(392, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // avgscore_item
            // 
            this.avgscore_item.BackColor = System.Drawing.Color.Black;
            this.avgscore_item.ForeColor = System.Drawing.Color.White;
            this.avgscore_item.Name = "avgscore_item";
            this.avgscore_item.Size = new System.Drawing.Size(203, 22);
            this.avgscore_item.Text = "Average score by course";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem addcourse_item;
        private System.Windows.Forms.ToolStripMenuItem removecourse_item;
        private System.Windows.Forms.ToolStripMenuItem editcourse_item;
        private System.Windows.Forms.ToolStripMenuItem managecourse_item;
        private System.Windows.Forms.ToolStripMenuItem printcourse_item;
        private System.Windows.Forms.ToolStripMenuItem addscore_item;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem managescore_item;
        private System.Windows.Forms.ToolStripMenuItem printscore_item;
        private System.Windows.Forms.ToolStripMenuItem avgscore_item;
    }
}