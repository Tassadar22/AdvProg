namespace AdvProAssig
{
    partial class DeleteStudent
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
            this.txtBoxCourse = new System.Windows.Forms.TextBox();
            this.lblSearchStudentID = new System.Windows.Forms.Label();
            this.txtBoxSearchable = new System.Windows.Forms.TextBox();
            this.txtBoxStudentNumber = new System.Windows.Forms.TextBox();
            this.panelCourseLevel = new System.Windows.Forms.Panel();
            this.rbPostGrad = new System.Windows.Forms.RadioButton();
            this.rbUnderGrad = new System.Windows.Forms.RadioButton();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxAdl2 = new System.Windows.Forms.TextBox();
            this.txtBoxAdl1 = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.txtBoxCounty = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
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
            this.panelCourseLevel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxCourse
            // 
            this.txtBoxCourse.Location = new System.Drawing.Point(106, 260);
            this.txtBoxCourse.Name = "txtBoxCourse";
            this.txtBoxCourse.ReadOnly = true;
            this.txtBoxCourse.Size = new System.Drawing.Size(199, 20);
            this.txtBoxCourse.TabIndex = 56;
            // 
            // lblSearchStudentID
            // 
            this.lblSearchStudentID.AutoSize = true;
            this.lblSearchStudentID.Location = new System.Drawing.Point(46, 401);
            this.lblSearchStudentID.Name = "lblSearchStudentID";
            this.lblSearchStudentID.Size = new System.Drawing.Size(195, 13);
            this.lblSearchStudentID.TabIndex = 55;
            this.lblSearchStudentID.Text = "Enter Student ID of Student to be found";
            // 
            // txtBoxSearchable
            // 
            this.txtBoxSearchable.Location = new System.Drawing.Point(257, 401);
            this.txtBoxSearchable.Name = "txtBoxSearchable";
            this.txtBoxSearchable.Size = new System.Drawing.Size(121, 20);
            this.txtBoxSearchable.TabIndex = 54;
            this.txtBoxSearchable.TextChanged += new System.EventHandler(this.UndoChanges);
            // 
            // txtBoxStudentNumber
            // 
            this.txtBoxStudentNumber.Location = new System.Drawing.Point(106, 326);
            this.txtBoxStudentNumber.Name = "txtBoxStudentNumber";
            this.txtBoxStudentNumber.ReadOnly = true;
            this.txtBoxStudentNumber.Size = new System.Drawing.Size(199, 20);
            this.txtBoxStudentNumber.TabIndex = 51;
            // 
            // panelCourseLevel
            // 
            this.panelCourseLevel.Controls.Add(this.rbPostGrad);
            this.panelCourseLevel.Controls.Add(this.rbUnderGrad);
            this.panelCourseLevel.Location = new System.Drawing.Point(107, 291);
            this.panelCourseLevel.Name = "panelCourseLevel";
            this.panelCourseLevel.Size = new System.Drawing.Size(198, 29);
            this.panelCourseLevel.TabIndex = 50;
            // 
            // rbPostGrad
            // 
            this.rbPostGrad.AutoSize = true;
            this.rbPostGrad.Enabled = false;
            this.rbPostGrad.Location = new System.Drawing.Point(105, 4);
            this.rbPostGrad.Name = "rbPostGrad";
            this.rbPostGrad.Size = new System.Drawing.Size(90, 17);
            this.rbPostGrad.TabIndex = 1;
            this.rbPostGrad.TabStop = true;
            this.rbPostGrad.Text = "PostGraduate";
            this.rbPostGrad.UseVisualStyleBackColor = true;
            // 
            // rbUnderGrad
            // 
            this.rbUnderGrad.AutoSize = true;
            this.rbUnderGrad.Enabled = false;
            this.rbUnderGrad.Location = new System.Drawing.Point(4, 4);
            this.rbUnderGrad.Name = "rbUnderGrad";
            this.rbUnderGrad.Size = new System.Drawing.Size(98, 17);
            this.rbUnderGrad.TabIndex = 0;
            this.rbUnderGrad.TabStop = true;
            this.rbUnderGrad.Text = "UnderGraduate";
            this.rbUnderGrad.UseVisualStyleBackColor = true;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(106, 237);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.ReadOnly = true;
            this.txtBoxCity.Size = new System.Drawing.Size(199, 20);
            this.txtBoxCity.TabIndex = 49;
            // 
            // txtBoxAdl2
            // 
            this.txtBoxAdl2.Location = new System.Drawing.Point(106, 185);
            this.txtBoxAdl2.Name = "txtBoxAdl2";
            this.txtBoxAdl2.ReadOnly = true;
            this.txtBoxAdl2.Size = new System.Drawing.Size(199, 20);
            this.txtBoxAdl2.TabIndex = 48;
            // 
            // txtBoxAdl1
            // 
            this.txtBoxAdl1.Location = new System.Drawing.Point(106, 159);
            this.txtBoxAdl1.Name = "txtBoxAdl1";
            this.txtBoxAdl1.ReadOnly = true;
            this.txtBoxAdl1.Size = new System.Drawing.Size(199, 20);
            this.txtBoxAdl1.TabIndex = 47;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(106, 133);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.ReadOnly = true;
            this.txtBoxPhone.Size = new System.Drawing.Size(199, 20);
            this.txtBoxPhone.TabIndex = 46;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(106, 107);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.ReadOnly = true;
            this.txtBoxEmail.Size = new System.Drawing.Size(199, 20);
            this.txtBoxEmail.TabIndex = 45;
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(106, 81);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.ReadOnly = true;
            this.txtBoxSurname.Size = new System.Drawing.Size(199, 20);
            this.txtBoxSurname.TabIndex = 44;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(106, 55);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.ReadOnly = true;
            this.txtBoxFirstName.Size = new System.Drawing.Size(199, 20);
            this.txtBoxFirstName.TabIndex = 43;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(13, 58);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(87, 299);
            this.lblDetails.TabIndex = 42;
            this.lblDetails.Text = "First Name:\r\n\r\nSurname:\r\n\r\nEmail:\r\n\r\nPhone:\r\n\r\nAddress Line 1:\r\n\r\nAddress Line 2:" +
    "\r\n\r\nCounty:\r\n\r\nCity:\r\n\r\nCourse:\r\n\r\nCourseLevel:\r\n\r\n\r\nStudent Number:\r\n\r\n";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(15, 26);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(118, 23);
            this.btnReturn.TabIndex = 41;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(397, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Location = new System.Drawing.Point(397, 399);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(75, 23);
            this.btnFindStudent.TabIndex = 58;
            this.btnFindStudent.Text = "Find Student";
            this.btnFindStudent.UseVisualStyleBackColor = true;
            this.btnFindStudent.Click += new System.EventHandler(this.btnFindStudent_Click);
            // 
            // txtBoxCounty
            // 
            this.txtBoxCounty.Location = new System.Drawing.Point(106, 211);
            this.txtBoxCounty.Name = "txtBoxCounty";
            this.txtBoxCounty.ReadOnly = true;
            this.txtBoxCounty.Size = new System.Drawing.Size(196, 20);
            this.txtBoxCounty.TabIndex = 59;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(151, 26);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 60;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(233, 26);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 61;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 62;
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
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBoxCounty);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtBoxCourse);
            this.Controls.Add(this.lblSearchStudentID);
            this.Controls.Add(this.txtBoxSearchable);
            this.Controls.Add(this.txtBoxStudentNumber);
            this.Controls.Add(this.panelCourseLevel);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.txtBoxAdl2);
            this.Controls.Add(this.txtBoxAdl1);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxSurname);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DeleteStudent";
            this.Text = "Delete Student";
            this.panelCourseLevel.ResumeLayout(false);
            this.panelCourseLevel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCourse;
        private System.Windows.Forms.Label lblSearchStudentID;
        private System.Windows.Forms.TextBox txtBoxSearchable;
        private System.Windows.Forms.TextBox txtBoxStudentNumber;
        private System.Windows.Forms.Panel panelCourseLevel;
        private System.Windows.Forms.RadioButton rbPostGrad;
        private System.Windows.Forms.RadioButton rbUnderGrad;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxAdl2;
        private System.Windows.Forms.TextBox txtBoxAdl1;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.TextBox txtBoxCounty;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
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
    }
}