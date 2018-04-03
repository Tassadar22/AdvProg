namespace AdvProAssig
{
    partial class AdminLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddStu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditStu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelStu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataHis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(25, 107);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 24);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Log in ";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(132, 66);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPassword.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(157, 107);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassword.Location = new System.Drawing.Point(12, 30);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(263, 16);
            this.lblAdminPassword.TabIndex = 15;
            this.lblAdminPassword.Text = "Please enter Administrator Password";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 16;
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
            this.menuLogout.Size = new System.Drawing.Size(117, 22);
            this.menuLogout.Text = "Log Out";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(117, 22);
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
            this.menuDelStu.Click += new System.EventHandler(this.menuDelStu_Click);
            // 
            // menuDataHis
            // 
            this.menuDataHis.Name = "menuDataHis";
            this.menuDataHis.Size = new System.Drawing.Size(217, 22);
            this.menuDataHis.Text = "View Database History";
            this.menuDataHis.Click += new System.EventHandler(this.menuDataHis_Click);
            // 
            // menuAdmin
            // 
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(217, 22);
            this.menuAdmin.Text = "Administrator";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 169);
            this.Controls.Add(this.lblAdminPassword);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminLogin";
            this.Text = "Admin Password";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddStu;
        private System.Windows.Forms.ToolStripMenuItem menuEditStu;
        private System.Windows.Forms.ToolStripMenuItem menuDelStu;
        private System.Windows.Forms.ToolStripMenuItem menuDataHis;
        private System.Windows.Forms.ToolStripMenuItem menuAdmin;
    }
}