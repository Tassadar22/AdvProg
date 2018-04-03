namespace AdvProAssig
{
    partial class AdminPage
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
            this.txtBoxStaffList = new System.Windows.Forms.RichTextBox();
            this.lblUserNameList = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.txtBoxSearchable = new System.Windows.Forms.TextBox();
            this.lblDairyleaSearchables = new System.Windows.Forms.Label();
            this.btnDeletThis = new System.Windows.Forms.Button();
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
            this.menuReturn});
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
            // menuReturn
            // 
            this.menuReturn.Name = "menuReturn";
            this.menuReturn.Size = new System.Drawing.Size(217, 22);
            this.menuReturn.Text = "Return to Main Menu";
            this.menuReturn.Click += new System.EventHandler(this.menuReturn_Click);
            // 
            // txtBoxStaffList
            // 
            this.txtBoxStaffList.Location = new System.Drawing.Point(12, 59);
            this.txtBoxStaffList.Name = "txtBoxStaffList";
            this.txtBoxStaffList.Size = new System.Drawing.Size(91, 148);
            this.txtBoxStaffList.TabIndex = 1;
            this.txtBoxStaffList.Text = "";
            // 
            // lblUserNameList
            // 
            this.lblUserNameList.AutoSize = true;
            this.lblUserNameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameList.Location = new System.Drawing.Point(12, 33);
            this.lblUserNameList.Name = "lblUserNameList";
            this.lblUserNameList.Size = new System.Drawing.Size(85, 13);
            this.lblUserNameList.TabIndex = 2;
            this.lblUserNameList.Text = "UserNameList";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(201, 59);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUserName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName:";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(201, 98);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(138, 150);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStaff.TabIndex = 7;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // txtBoxSearchable
            // 
            this.txtBoxSearchable.Location = new System.Drawing.Point(185, 243);
            this.txtBoxSearchable.Name = "txtBoxSearchable";
            this.txtBoxSearchable.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSearchable.TabIndex = 8;
            // 
            // lblDairyleaSearchables
            // 
            this.lblDairyleaSearchables.AutoSize = true;
            this.lblDairyleaSearchables.Location = new System.Drawing.Point(26, 243);
            this.lblDairyleaSearchables.Name = "lblDairyleaSearchables";
            this.lblDairyleaSearchables.Size = new System.Drawing.Size(137, 13);
            this.lblDairyleaSearchables.TabIndex = 9;
            this.lblDairyleaSearchables.Text = "Find Staff Member to delete";
            // 
            // btnDeletThis
            // 
            this.btnDeletThis.Location = new System.Drawing.Point(304, 241);
            this.btnDeletThis.Name = "btnDeletThis";
            this.btnDeletThis.Size = new System.Drawing.Size(75, 23);
            this.btnDeletThis.TabIndex = 10;
            this.btnDeletThis.Text = "Delete Staff Member";
            this.btnDeletThis.UseVisualStyleBackColor = true;
            this.btnDeletThis.Click += new System.EventHandler(this.btnDeletThis_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.btnDeletThis);
            this.Controls.Add(this.lblDairyleaSearchables);
            this.Controls.Add(this.txtBoxSearchable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.lblUserNameList);
            this.Controls.Add(this.txtBoxUserName);
            this.Controls.Add(this.txtBoxStaffList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPage";
            this.Text = "Admininistrator Page";
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
        private System.Windows.Forms.RichTextBox txtBoxStaffList;
        private System.Windows.Forms.Label lblUserNameList;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.TextBox txtBoxSearchable;
        private System.Windows.Forms.Label lblDairyleaSearchables;
        private System.Windows.Forms.Button btnDeletThis;
        private System.Windows.Forms.ToolStripMenuItem menuReturn;
    }
}