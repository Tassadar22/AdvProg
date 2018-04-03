namespace AdvProAssig
{
    partial class DatabaseHistory
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddStu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditStu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelStu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataHis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.rchTxtDataBaseHistory = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogout,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(152, 22);
            this.menuLogout.Text = "Log Out";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(152, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddStu,
            this.menuEditStu,
            this.menuDelStu,
            this.menuDataHis,
            this.menuReturn,
            this.menuAdmin});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // menuAddStu
            // 
            this.menuAddStu.Name = "menuAddStu";
            this.menuAddStu.Size = new System.Drawing.Size(217, 22);
            this.menuAddStu.Text = "New Student";
            this.menuAddStu.Click += new System.EventHandler(this.menuAddStu_Click);
            // 
            // menuEditStu
            // 
            this.menuEditStu.Name = "menuEditStu";
            this.menuEditStu.Size = new System.Drawing.Size(217, 22);
            this.menuEditStu.Text = "Edit Student/Export to XML";
            this.menuEditStu.Click += new System.EventHandler(this.menuEditStu_Click);
            // 
            // menuDelStu
            // 
            this.menuDelStu.Name = "menuDelStu";
            this.menuDelStu.Size = new System.Drawing.Size(217, 22);
            this.menuDelStu.Text = "Delete Student";
            this.menuDelStu.Click += new System.EventHandler(this.menuEditStu_Click);
            // 
            // menuDataHis
            // 
            this.menuDataHis.Name = "menuDataHis";
            this.menuDataHis.Size = new System.Drawing.Size(217, 22);
            this.menuDataHis.Text = "View Database History";
            this.menuDataHis.Click += new System.EventHandler(this.menuDataHis_Click);
            // 
            // menuReturn
            // 
            this.menuReturn.Name = "menuReturn";
            this.menuReturn.Size = new System.Drawing.Size(217, 22);
            this.menuReturn.Text = "Return to Main Menu";
            this.menuReturn.Click += new System.EventHandler(this.menuReturn_Click);
            // 
            // menuAdmin
            // 
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(217, 22);
            this.menuAdmin.Text = "Administrator";
            this.menuAdmin.Click += new System.EventHandler(this.menuAdmin_Click);
            // 
            // rchTxtDataBaseHistory
            // 
            this.rchTxtDataBaseHistory.Location = new System.Drawing.Point(12, 64);
            this.rchTxtDataBaseHistory.Name = "rchTxtDataBaseHistory";
            this.rchTxtDataBaseHistory.ReadOnly = true;
            this.rchTxtDataBaseHistory.Size = new System.Drawing.Size(430, 283);
            this.rchTxtDataBaseHistory.TabIndex = 1;
            this.rchTxtDataBaseHistory.Text = "";
            // 
            // DatabaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.rchTxtDataBaseHistory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DatabaseHistory";
            this.Text = "Database History";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddStu;
        private System.Windows.Forms.ToolStripMenuItem menuEditStu;
        private System.Windows.Forms.ToolStripMenuItem menuDelStu;
        private System.Windows.Forms.ToolStripMenuItem menuDataHis;
        private System.Windows.Forms.ToolStripMenuItem menuReturn;
        private System.Windows.Forms.RichTextBox rchTxtDataBaseHistory;
        private System.Windows.Forms.ToolStripMenuItem menuAdmin;
    }
}