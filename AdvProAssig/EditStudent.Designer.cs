namespace AdvProAssig
{
    partial class EditStudent
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
            this.cbCounties = new System.Windows.Forms.ComboBox();
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
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.txtBoxSearchable = new System.Windows.Forms.TextBox();
            this.lblSearchStudentID = new System.Windows.Forms.Label();
            this.txtBoxCourse = new System.Windows.Forms.TextBox();
            this.btnXMLExport = new System.Windows.Forms.Button();
            this.txtboxXMLFileName = new System.Windows.Forms.TextBox();
            this.pnlXML = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.pnlEditStudent = new System.Windows.Forms.Panel();
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
            this.btnEditStu = new System.Windows.Forms.Button();
            this.panelCourseLevel.SuspendLayout();
            this.pnlXML.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCounties
            // 
            this.cbCounties.FormattingEnabled = true;
            this.cbCounties.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cbCounties.Location = new System.Drawing.Point(111, 212);
            this.cbCounties.Name = "cbCounties";
            this.cbCounties.Size = new System.Drawing.Size(199, 21);
            this.cbCounties.TabIndex = 30;
            // 
            // txtBoxStudentNumber
            // 
            this.txtBoxStudentNumber.Location = new System.Drawing.Point(111, 326);
            this.txtBoxStudentNumber.Name = "txtBoxStudentNumber";
            this.txtBoxStudentNumber.Size = new System.Drawing.Size(199, 20);
            this.txtBoxStudentNumber.TabIndex = 29;
            // 
            // panelCourseLevel
            // 
            this.panelCourseLevel.Controls.Add(this.rbPostGrad);
            this.panelCourseLevel.Controls.Add(this.rbUnderGrad);
            this.panelCourseLevel.Location = new System.Drawing.Point(112, 291);
            this.panelCourseLevel.Name = "panelCourseLevel";
            this.panelCourseLevel.Size = new System.Drawing.Size(198, 29);
            this.panelCourseLevel.TabIndex = 28;
            // 
            // rbPostGrad
            // 
            this.rbPostGrad.AutoSize = true;
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
            this.txtBoxCity.Location = new System.Drawing.Point(111, 237);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(199, 20);
            this.txtBoxCity.TabIndex = 26;
            // 
            // txtBoxAdl2
            // 
            this.txtBoxAdl2.Location = new System.Drawing.Point(111, 185);
            this.txtBoxAdl2.Name = "txtBoxAdl2";
            this.txtBoxAdl2.Size = new System.Drawing.Size(199, 20);
            this.txtBoxAdl2.TabIndex = 25;
            // 
            // txtBoxAdl1
            // 
            this.txtBoxAdl1.Location = new System.Drawing.Point(111, 159);
            this.txtBoxAdl1.Name = "txtBoxAdl1";
            this.txtBoxAdl1.Size = new System.Drawing.Size(199, 20);
            this.txtBoxAdl1.TabIndex = 24;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(111, 133);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(199, 20);
            this.txtBoxPhone.TabIndex = 23;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(111, 107);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(199, 20);
            this.txtBoxEmail.TabIndex = 22;
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(111, 81);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(199, 20);
            this.txtBoxSurname.TabIndex = 21;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(111, 55);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(199, 20);
            this.txtBoxFirstName.TabIndex = 20;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(18, 58);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(87, 299);
            this.lblDetails.TabIndex = 19;
            this.lblDetails.Text = "First Name:\r\n\r\nSurname:\r\n\r\nEmail:\r\n\r\nPhone:\r\n\r\nAddress Line 1:\r\n\r\nAddress Line 2:" +
    "\r\n\r\nCounty:\r\n\r\nCity:\r\n\r\nCourse:\r\n\r\nCourseLevel:\r\n\r\n\r\nStudent Number:\r\n\r\n";
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Location = new System.Drawing.Point(385, 376);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(75, 23);
            this.btnFindStudent.TabIndex = 34;
            this.btnFindStudent.Text = "Find Student";
            this.btnFindStudent.UseVisualStyleBackColor = true;
            this.btnFindStudent.Click += new System.EventHandler(this.butFindStu_Click);
            // 
            // txtBoxSearchable
            // 
            this.txtBoxSearchable.Location = new System.Drawing.Point(250, 376);
            this.txtBoxSearchable.Name = "txtBoxSearchable";
            this.txtBoxSearchable.Size = new System.Drawing.Size(121, 20);
            this.txtBoxSearchable.TabIndex = 35;
            this.txtBoxSearchable.TextChanged += new System.EventHandler(this.txtBoxSearchable_TextChanged);
            // 
            // lblSearchStudentID
            // 
            this.lblSearchStudentID.AutoSize = true;
            this.lblSearchStudentID.Location = new System.Drawing.Point(39, 376);
            this.lblSearchStudentID.Name = "lblSearchStudentID";
            this.lblSearchStudentID.Size = new System.Drawing.Size(195, 13);
            this.lblSearchStudentID.TabIndex = 36;
            this.lblSearchStudentID.Text = "Enter Student ID of Student to be found";
            // 
            // txtBoxCourse
            // 
            this.txtBoxCourse.Location = new System.Drawing.Point(111, 260);
            this.txtBoxCourse.Name = "txtBoxCourse";
            this.txtBoxCourse.Size = new System.Drawing.Size(199, 20);
            this.txtBoxCourse.TabIndex = 40;
            // 
            // btnXMLExport
            // 
            this.btnXMLExport.Location = new System.Drawing.Point(3, 66);
            this.btnXMLExport.Name = "btnXMLExport";
            this.btnXMLExport.Size = new System.Drawing.Size(86, 23);
            this.btnXMLExport.TabIndex = 42;
            this.btnXMLExport.Text = "Export to XML";
            this.btnXMLExport.UseVisualStyleBackColor = true;
            this.btnXMLExport.Click += new System.EventHandler(this.btnXMLExport_Click);
            // 
            // txtboxXMLFileName
            // 
            this.txtboxXMLFileName.Location = new System.Drawing.Point(3, 124);
            this.txtboxXMLFileName.Name = "txtboxXMLFileName";
            this.txtboxXMLFileName.Size = new System.Drawing.Size(170, 20);
            this.txtboxXMLFileName.TabIndex = 44;
            // 
            // pnlXML
            // 
            this.pnlXML.Controls.Add(this.label1);
            this.pnlXML.Controls.Add(this.btnBrowse);
            this.pnlXML.Controls.Add(this.lblFileName);
            this.pnlXML.Controls.Add(this.txtboxXMLFileName);
            this.pnlXML.Controls.Add(this.btnXMLExport);
            this.pnlXML.Location = new System.Drawing.Point(351, 41);
            this.pnlXML.Name = "pnlXML";
            this.pnlXML.Size = new System.Drawing.Size(190, 164);
            this.pnlXML.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 48;
            this.label1.Text = "Click Browse to find an existing \r\nXML file or Export to generate \r\none based off" +
    " of the Student Name";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(58, 95);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 23);
            this.btnBrowse.TabIndex = 47;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(0, 105);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(52, 13);
            this.lblFileName.TabIndex = 45;
            this.lblFileName.Text = "Filename:";
            // 
            // pnlEditStudent
            // 
            this.pnlEditStudent.Location = new System.Drawing.Point(14, 41);
            this.pnlEditStudent.Name = "pnlEditStudent";
            this.pnlEditStudent.Size = new System.Drawing.Size(321, 316);
            this.pnlEditStudent.TabIndex = 47;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 49;
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
            this.menuAddStu.Size = new System.Drawing.Size(191, 22);
            this.menuAddStu.Text = "New Student";
            this.menuAddStu.Click += new System.EventHandler(this.menuAddStu_Click);
            // 
            // menuEditStu
            // 
            this.menuEditStu.Name = "menuEditStu";
            this.menuEditStu.Size = new System.Drawing.Size(191, 22);
            this.menuEditStu.Text = "Edit Student";
            this.menuEditStu.Click += new System.EventHandler(this.menuEditStu_Click);
            // 
            // menuDelStu
            // 
            this.menuDelStu.Name = "menuDelStu";
            this.menuDelStu.Size = new System.Drawing.Size(191, 22);
            this.menuDelStu.Text = "Delete Student";
            this.menuDelStu.Click += new System.EventHandler(this.menuDelStu_Click);
            // 
            // menuDataHis
            // 
            this.menuDataHis.Name = "menuDataHis";
            this.menuDataHis.Size = new System.Drawing.Size(191, 22);
            this.menuDataHis.Text = "View Database History";
            this.menuDataHis.Click += new System.EventHandler(this.menuDataHis_Click);
            // 
            // menuReturn
            // 
            this.menuReturn.Name = "menuReturn";
            this.menuReturn.Size = new System.Drawing.Size(191, 22);
            this.menuReturn.Text = "Return to Main Menu";
            this.menuReturn.Click += new System.EventHandler(this.menuReturn_Click);
            // 
            // btnEditStu
            // 
            this.btnEditStu.Location = new System.Drawing.Point(357, 334);
            this.btnEditStu.Name = "btnEditStu";
            this.btnEditStu.Size = new System.Drawing.Size(110, 23);
            this.btnEditStu.TabIndex = 50;
            this.btnEditStu.Text = "Edit/Update student";
            this.btnEditStu.UseVisualStyleBackColor = true;
            this.btnEditStu.Click += new System.EventHandler(this.btnEditStu_Click);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.btnEditStu);
            this.Controls.Add(this.pnlEditStudent);
            this.Controls.Add(this.pnlXML);
            this.Controls.Add(this.txtBoxCourse);
            this.Controls.Add(this.lblSearchStudentID);
            this.Controls.Add(this.txtBoxSearchable);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.cbCounties);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditStudent";
            this.Text = "Edit Student";
            this.panelCourseLevel.ResumeLayout(false);
            this.panelCourseLevel.PerformLayout();
            this.pnlXML.ResumeLayout(false);
            this.pnlXML.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCounties;
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
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.TextBox txtBoxSearchable;
        private System.Windows.Forms.Label lblSearchStudentID;
        private System.Windows.Forms.TextBox txtBoxCourse;
        private System.Windows.Forms.Button btnXMLExport;
        private System.Windows.Forms.TextBox txtboxXMLFileName;
        private System.Windows.Forms.Panel pnlXML;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Panel pnlEditStudent;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddStu;
        private System.Windows.Forms.ToolStripMenuItem menuReturn;
        private System.Windows.Forms.ToolStripMenuItem menuDelStu;
        private System.Windows.Forms.ToolStripMenuItem menuDataHis;
        private System.Windows.Forms.ToolStripMenuItem menuEditStu;
        private System.Windows.Forms.Button btnEditStu;
    }
}