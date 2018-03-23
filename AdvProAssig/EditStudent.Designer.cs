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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbParameterSearch = new System.Windows.Forms.ComboBox();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.txtBoxSearchable = new System.Windows.Forms.TextBox();
            this.lblSearchString = new System.Windows.Forms.Label();
            this.panelFirstName = new System.Windows.Forms.Panel();
            this.panelSurname = new System.Windows.Forms.Panel();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.panelPhone = new System.Windows.Forms.Panel();
            this.panelAddLin1 = new System.Windows.Forms.Panel();
            this.panelAddLin2 = new System.Windows.Forms.Panel();
            this.panelCounty = new System.Windows.Forms.Panel();
            this.panelCity = new System.Windows.Forms.Panel();
            this.PanelCourse = new System.Windows.Forms.Panel();
            this.PanelCourselvl = new System.Windows.Forms.Panel();
            this.PanelStudentID = new System.Windows.Forms.Panel();
            this.txtBoxCourse = new System.Windows.Forms.TextBox();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.panelCourseLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(17, 12);
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
            this.btnClear.Location = new System.Drawing.Point(145, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Select Parameter to find Student By:";
            // 
            // cmbParameterSearch
            // 
            this.cmbParameterSearch.FormattingEnabled = true;
            this.cmbParameterSearch.Items.AddRange(new object[] {
            "First Name",
            "Surname",
            "Email",
            "Phone",
            "Address Line 1",
            "Address Line 2",
            "County",
            "City",
            "Course",
            "CourseLevel",
            "Student Number"});
            this.cmbParameterSearch.Location = new System.Drawing.Point(285, 362);
            this.cmbParameterSearch.Name = "cmbParameterSearch";
            this.cmbParameterSearch.Size = new System.Drawing.Size(121, 21);
            this.cmbParameterSearch.TabIndex = 31;
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Location = new System.Drawing.Point(303, 427);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(75, 23);
            this.btnFindStudent.TabIndex = 34;
            this.btnFindStudent.Text = "Find Student";
            this.btnFindStudent.UseVisualStyleBackColor = true;
            this.btnFindStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxSearchable
            // 
            this.txtBoxSearchable.Location = new System.Drawing.Point(285, 401);
            this.txtBoxSearchable.Name = "txtBoxSearchable";
            this.txtBoxSearchable.Size = new System.Drawing.Size(121, 20);
            this.txtBoxSearchable.TabIndex = 35;
            // 
            // lblSearchString
            // 
            this.lblSearchString.AutoSize = true;
            this.lblSearchString.Location = new System.Drawing.Point(97, 401);
            this.lblSearchString.Name = "lblSearchString";
            this.lblSearchString.Size = new System.Drawing.Size(123, 13);
            this.lblSearchString.TabIndex = 36;
            this.lblSearchString.Text = "Enter value to search for";
            // 
            // panelFirstName
            // 
            this.panelFirstName.Location = new System.Drawing.Point(329, 55);
            this.panelFirstName.Name = "panelFirstName";
            this.panelFirstName.Size = new System.Drawing.Size(289, 20);
            this.panelFirstName.TabIndex = 37;
            // 
            // panelSurname
            // 
            this.panelSurname.Location = new System.Drawing.Point(329, 81);
            this.panelSurname.Name = "panelSurname";
            this.panelSurname.Size = new System.Drawing.Size(289, 20);
            this.panelSurname.TabIndex = 38;
            // 
            // panelEmail
            // 
            this.panelEmail.Location = new System.Drawing.Point(329, 107);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(289, 20);
            this.panelEmail.TabIndex = 39;
            // 
            // panelPhone
            // 
            this.panelPhone.Location = new System.Drawing.Point(329, 130);
            this.panelPhone.Name = "panelPhone";
            this.panelPhone.Size = new System.Drawing.Size(289, 20);
            this.panelPhone.TabIndex = 38;
            // 
            // panelAddLin1
            // 
            this.panelAddLin1.Location = new System.Drawing.Point(329, 156);
            this.panelAddLin1.Name = "panelAddLin1";
            this.panelAddLin1.Size = new System.Drawing.Size(289, 20);
            this.panelAddLin1.TabIndex = 38;
            // 
            // panelAddLin2
            // 
            this.panelAddLin2.Location = new System.Drawing.Point(329, 182);
            this.panelAddLin2.Name = "panelAddLin2";
            this.panelAddLin2.Size = new System.Drawing.Size(289, 20);
            this.panelAddLin2.TabIndex = 38;
            // 
            // panelCounty
            // 
            this.panelCounty.Location = new System.Drawing.Point(329, 208);
            this.panelCounty.Name = "panelCounty";
            this.panelCounty.Size = new System.Drawing.Size(289, 20);
            this.panelCounty.TabIndex = 38;
            // 
            // panelCity
            // 
            this.panelCity.Location = new System.Drawing.Point(329, 234);
            this.panelCity.Name = "panelCity";
            this.panelCity.Size = new System.Drawing.Size(289, 20);
            this.panelCity.TabIndex = 38;
            // 
            // PanelCourse
            // 
            this.PanelCourse.Location = new System.Drawing.Point(329, 260);
            this.PanelCourse.Name = "PanelCourse";
            this.PanelCourse.Size = new System.Drawing.Size(289, 20);
            this.PanelCourse.TabIndex = 38;
            // 
            // PanelCourselvl
            // 
            this.PanelCourselvl.Location = new System.Drawing.Point(329, 286);
            this.PanelCourselvl.Name = "PanelCourselvl";
            this.PanelCourselvl.Size = new System.Drawing.Size(289, 31);
            this.PanelCourselvl.TabIndex = 38;
            // 
            // PanelStudentID
            // 
            this.PanelStudentID.Location = new System.Drawing.Point(329, 323);
            this.PanelStudentID.Name = "PanelStudentID";
            this.PanelStudentID.Size = new System.Drawing.Size(289, 20);
            this.PanelStudentID.TabIndex = 38;
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
            this.btnEditDetails.Location = new System.Drawing.Point(227, 12);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(75, 23);
            this.btnEditDetails.TabIndex = 41;
            this.btnEditDetails.Text = "Edit/Update Student Details";
            this.btnEditDetails.UseVisualStyleBackColor = true;
            this.btnEditDetails.Click += new System.EventHandler(this.btnEditDetails_Click);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.btnEditDetails);
            this.Controls.Add(this.txtBoxCourse);
            this.Controls.Add(this.PanelStudentID);
            this.Controls.Add(this.PanelCourselvl);
            this.Controls.Add(this.PanelCourse);
            this.Controls.Add(this.panelCity);
            this.Controls.Add(this.panelCounty);
            this.Controls.Add(this.panelAddLin2);
            this.Controls.Add(this.panelAddLin1);
            this.Controls.Add(this.panelPhone);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.panelSurname);
            this.Controls.Add(this.panelFirstName);
            this.Controls.Add(this.lblSearchString);
            this.Controls.Add(this.txtBoxSearchable);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbParameterSearch);
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
            this.panelCourseLevel.ResumeLayout(false);
            this.panelCourseLevel.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbParameterSearch;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.TextBox txtBoxSearchable;
        private System.Windows.Forms.Label lblSearchString;
        private System.Windows.Forms.Panel panelFirstName;
        private System.Windows.Forms.Panel panelSurname;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.Panel panelAddLin1;
        private System.Windows.Forms.Panel panelAddLin2;
        private System.Windows.Forms.Panel panelCounty;
        private System.Windows.Forms.Panel panelCity;
        private System.Windows.Forms.Panel PanelCourse;
        private System.Windows.Forms.Panel PanelCourselvl;
        private System.Windows.Forms.Panel PanelStudentID;
        private System.Windows.Forms.TextBox txtBoxCourse;
        private System.Windows.Forms.Button btnEditDetails;
    }
}