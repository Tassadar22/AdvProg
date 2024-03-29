﻿namespace AdvProAssig
{
    partial class AddStudent
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
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxAdl1 = new System.Windows.Forms.TextBox();
            this.txtBoxAdl2 = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.panelCourseLevel = new System.Windows.Forms.Panel();
            this.rbPostGrad = new System.Windows.Forms.RadioButton();
            this.rbUnderGrad = new System.Windows.Forms.RadioButton();
            this.txtBoxStudentNumber = new System.Windows.Forms.TextBox();
            this.cbCounties = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddStu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditStu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelStu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataHis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.panelCourseLevel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(24, 57);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(87, 299);
            this.lblDetails.TabIndex = 0;
            this.lblDetails.Text = "First Name:\r\n\r\nSurname:\r\n\r\nEmail:\r\n\r\nPhone:\r\n\r\nAddress Line 1:\r\n\r\nAddress Line 2:" +
    "\r\n\r\nCounty:\r\n\r\nCity:\r\n\r\nCourse:\r\n\r\nCourseLevel:\r\n\r\n\r\nStudent Number:\r\n\r\n";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(117, 54);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(199, 20);
            this.txtBoxFirstName.TabIndex = 1;
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(117, 80);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(199, 20);
            this.txtBoxSurname.TabIndex = 2;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(117, 106);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(199, 20);
            this.txtBoxEmail.TabIndex = 3;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(117, 132);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(199, 20);
            this.txtBoxPhone.TabIndex = 4;
            // 
            // txtBoxAdl1
            // 
            this.txtBoxAdl1.Location = new System.Drawing.Point(117, 158);
            this.txtBoxAdl1.Name = "txtBoxAdl1";
            this.txtBoxAdl1.Size = new System.Drawing.Size(199, 20);
            this.txtBoxAdl1.TabIndex = 5;
            // 
            // txtBoxAdl2
            // 
            this.txtBoxAdl2.Location = new System.Drawing.Point(117, 184);
            this.txtBoxAdl2.Name = "txtBoxAdl2";
            this.txtBoxAdl2.Size = new System.Drawing.Size(199, 20);
            this.txtBoxAdl2.TabIndex = 6;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(117, 236);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(199, 20);
            this.txtBoxCity.TabIndex = 8;
            // 
            // cbCourse
            // 
            this.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Items.AddRange(new object[] {
            " ",
            "Psychology",
            "Business",
            "Marketing",
            "Software Development",
            "DataAnalytics"});
            this.cbCourse.Location = new System.Drawing.Point(117, 262);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(199, 21);
            this.cbCourse.TabIndex = 9;
            // 
            // panelCourseLevel
            // 
            this.panelCourseLevel.Controls.Add(this.rbPostGrad);
            this.panelCourseLevel.Controls.Add(this.rbUnderGrad);
            this.panelCourseLevel.Location = new System.Drawing.Point(118, 290);
            this.panelCourseLevel.Name = "panelCourseLevel";
            this.panelCourseLevel.Size = new System.Drawing.Size(198, 29);
            this.panelCourseLevel.TabIndex = 10;
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
            // txtBoxStudentNumber
            // 
            this.txtBoxStudentNumber.Location = new System.Drawing.Point(117, 325);
            this.txtBoxStudentNumber.Name = "txtBoxStudentNumber";
            this.txtBoxStudentNumber.Size = new System.Drawing.Size(199, 20);
            this.txtBoxStudentNumber.TabIndex = 11;
            // 
            // cbCounties
            // 
            this.cbCounties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCounties.FormattingEnabled = true;
            this.cbCounties.Items.AddRange(new object[] {
            " ",
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
            this.cbCounties.Location = new System.Drawing.Point(117, 211);
            this.cbCounties.Name = "cbCounties";
            this.cbCounties.Size = new System.Drawing.Size(199, 21);
            this.cbCounties.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 20;
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
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddStu,
            this.menuReturn,
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
            this.menuAddStu.Text = "Add Student";
            this.menuAddStu.Click += new System.EventHandler(this.menuAddStu_Click);
            // 
            // menuReturn
            // 
            this.menuReturn.Name = "menuReturn";
            this.menuReturn.Size = new System.Drawing.Size(217, 22);
            this.menuReturn.Text = "Return To Main Menu";
            this.menuReturn.Click += new System.EventHandler(this.menuMainMenu_Click);
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
            this.menuAdmin.Click += new System.EventHandler(this.administratorToolStripMenuItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(241, 383);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddStu
            // 
            this.btnAddStu.Location = new System.Drawing.Point(117, 383);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(75, 23);
            this.btnAddStu.TabIndex = 22;
            this.btnAddStu.Text = "Add Student";
            this.btnAddStu.UseVisualStyleBackColor = true;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.btnAddStu);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cbCounties);
            this.Controls.Add(this.txtBoxStudentNumber);
            this.Controls.Add(this.panelCourseLevel);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.txtBoxAdl2);
            this.Controls.Add(this.txtBoxAdl1);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxSurname);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblDetails);
            this.Name = "AddStudent";
            this.Text = "Add Student Field";
            this.panelCourseLevel.ResumeLayout(false);
            this.panelCourseLevel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.TextBox txtBoxAdl1;
        private System.Windows.Forms.TextBox txtBoxAdl2;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Panel panelCourseLevel;
        private System.Windows.Forms.RadioButton rbPostGrad;
        private System.Windows.Forms.RadioButton rbUnderGrad;
        private System.Windows.Forms.TextBox txtBoxStudentNumber;
        private System.Windows.Forms.ComboBox cbCounties;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuReturn;
        private System.Windows.Forms.ToolStripMenuItem menuEditStu;
        private System.Windows.Forms.ToolStripMenuItem menuDelStu;
        private System.Windows.Forms.ToolStripMenuItem menuDataHis;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem menuAddStu;
        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.ToolStripMenuItem menuAdmin;
    }
}