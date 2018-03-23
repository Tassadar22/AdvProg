﻿namespace AdvProAssig
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
            this.btnReturn = new System.Windows.Forms.Button();
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.txtBoxSearchable = new System.Windows.Forms.TextBox();
            this.lblSearchStudentID = new System.Windows.Forms.Label();
            this.txtBoxCourse = new System.Windows.Forms.TextBox();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.btnXMLExport = new System.Windows.Forms.Button();
            this.btnLoadXML = new System.Windows.Forms.Button();
            this.txtboxXMLFileName = new System.Windows.Forms.TextBox();
            this.btnToggleXML = new System.Windows.Forms.Button();
            this.pnlXML = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.panelCourseLevel.SuspendLayout();
            this.pnlXML.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(118, 23);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(136, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            // btnEditDetails
            // 
            this.btnEditDetails.Location = new System.Drawing.Point(217, 12);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(75, 23);
            this.btnEditDetails.TabIndex = 41;
            this.btnEditDetails.Text = "Edit/Update Student Details";
            this.btnEditDetails.UseVisualStyleBackColor = true;
            this.btnEditDetails.Click += new System.EventHandler(this.btnEditDetails_Click);
            // 
            // btnXMLExport
            // 
            this.btnXMLExport.Location = new System.Drawing.Point(3, 32);
            this.btnXMLExport.Name = "btnXMLExport";
            this.btnXMLExport.Size = new System.Drawing.Size(86, 23);
            this.btnXMLExport.TabIndex = 42;
            this.btnXMLExport.Text = "Export to XML";
            this.btnXMLExport.UseVisualStyleBackColor = true;
            this.btnXMLExport.Click += new System.EventHandler(this.btnXMLExport_Click);
            // 
            // btnLoadXML
            // 
            this.btnLoadXML.Location = new System.Drawing.Point(3, 3);
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(75, 23);
            this.btnLoadXML.TabIndex = 43;
            this.btnLoadXML.Text = "Load XML File";
            this.btnLoadXML.UseVisualStyleBackColor = true;
            this.btnLoadXML.Click += new System.EventHandler(this.btnLoadXML_Click);
            // 
            // txtboxXMLFileName
            // 
            this.txtboxXMLFileName.Location = new System.Drawing.Point(3, 79);
            this.txtboxXMLFileName.Name = "txtboxXMLFileName";
            this.txtboxXMLFileName.Size = new System.Drawing.Size(170, 20);
            this.txtboxXMLFileName.TabIndex = 44;
            // 
            // btnToggleXML
            // 
            this.btnToggleXML.Location = new System.Drawing.Point(298, 12);
            this.btnToggleXML.Name = "btnToggleXML";
            this.btnToggleXML.Size = new System.Drawing.Size(109, 23);
            this.btnToggleXML.TabIndex = 45;
            this.btnToggleXML.Text = "Toggle XML View";
            this.btnToggleXML.UseVisualStyleBackColor = true;
            this.btnToggleXML.Click += new System.EventHandler(this.btnToggleXML_Click);
            // 
            // pnlXML
            // 
            this.pnlXML.Controls.Add(this.btnAddStudent);
            this.pnlXML.Controls.Add(this.lblFileName);
            this.pnlXML.Controls.Add(this.btnLoadXML);
            this.pnlXML.Controls.Add(this.txtboxXMLFileName);
            this.pnlXML.Controls.Add(this.btnXMLExport);
            this.pnlXML.Location = new System.Drawing.Point(382, 55);
            this.pnlXML.Name = "pnlXML";
            this.pnlXML.Size = new System.Drawing.Size(190, 202);
            this.pnlXML.TabIndex = 46;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(3, 59);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(52, 13);
            this.lblFileName.TabIndex = 45;
            this.lblFileName.Text = "Filename:";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(98, 3);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 46;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.pnlXML);
            this.Controls.Add(this.btnToggleXML);
            this.Controls.Add(this.btnEditDetails);
            this.Controls.Add(this.txtBoxCourse);
            this.Controls.Add(this.lblSearchStudentID);
            this.Controls.Add(this.txtBoxSearchable);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.btnClear);
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
            this.Controls.Add(this.btnReturn);
            this.Name = "EditStudent";
            this.Text = "Edit Student";
            this.Load += new System.EventHandler(this.EditStudent_Load);
            this.panelCourseLevel.ResumeLayout(false);
            this.panelCourseLevel.PerformLayout();
            this.pnlXML.ResumeLayout(false);
            this.pnlXML.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.TextBox txtBoxSearchable;
        private System.Windows.Forms.Label lblSearchStudentID;
        private System.Windows.Forms.TextBox txtBoxCourse;
        private System.Windows.Forms.Button btnEditDetails;
        private System.Windows.Forms.Button btnXMLExport;
        private System.Windows.Forms.Button btnLoadXML;
        private System.Windows.Forms.TextBox txtboxXMLFileName;
        private System.Windows.Forms.Button btnToggleXML;
        private System.Windows.Forms.Panel pnlXML;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnAddStudent;
    }
}