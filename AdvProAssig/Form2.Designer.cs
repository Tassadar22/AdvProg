namespace AdvProAssig
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtboxTest = new System.Windows.Forms.RichTextBox();
            this.btnTestServerCommand = new System.Windows.Forms.Button();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graduateLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courselevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(197, 413);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(310, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(413, 413);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressLine1DataGridViewTextBoxColumn,
            this.addressLine2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countyDataGridViewTextBoxColumn,
            this.graduateLevelDataGridViewTextBoxColumn,
            this.courselevelDataGridViewTextBoxColumn,
            this.studentNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1063, 256);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtboxTest
            // 
            this.txtboxTest.Location = new System.Drawing.Point(704, 332);
            this.txtboxTest.Name = "txtboxTest";
            this.txtboxTest.Size = new System.Drawing.Size(525, 171);
            this.txtboxTest.TabIndex = 5;
            this.txtboxTest.Text = "";
            // 
            // btnTestServerCommand
            // 
            this.btnTestServerCommand.Location = new System.Drawing.Point(573, 357);
            this.btnTestServerCommand.Name = "btnTestServerCommand";
            this.btnTestServerCommand.Size = new System.Drawing.Size(75, 23);
            this.btnTestServerCommand.TabIndex = 6;
            this.btnTestServerCommand.Text = "button1";
            this.btnTestServerCommand.UseVisualStyleBackColor = true;
            this.btnTestServerCommand.Click += new System.EventHandler(this.btnTestServerCommand_Click);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 50;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressLine1DataGridViewTextBoxColumn
            // 
            this.addressLine1DataGridViewTextBoxColumn.DataPropertyName = "AddressLine1";
            this.addressLine1DataGridViewTextBoxColumn.HeaderText = "AddressLine1";
            this.addressLine1DataGridViewTextBoxColumn.Name = "addressLine1DataGridViewTextBoxColumn";
            // 
            // addressLine2DataGridViewTextBoxColumn
            // 
            this.addressLine2DataGridViewTextBoxColumn.DataPropertyName = "AddressLine2";
            this.addressLine2DataGridViewTextBoxColumn.HeaderText = "AddressLine2";
            this.addressLine2DataGridViewTextBoxColumn.Name = "addressLine2DataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // countyDataGridViewTextBoxColumn
            // 
            this.countyDataGridViewTextBoxColumn.DataPropertyName = "County";
            this.countyDataGridViewTextBoxColumn.HeaderText = "County";
            this.countyDataGridViewTextBoxColumn.Name = "countyDataGridViewTextBoxColumn";
            // 
            // graduateLevelDataGridViewTextBoxColumn
            // 
            this.graduateLevelDataGridViewTextBoxColumn.DataPropertyName = "GraduateLevel";
            this.graduateLevelDataGridViewTextBoxColumn.HeaderText = "GraduateLevel";
            this.graduateLevelDataGridViewTextBoxColumn.Name = "graduateLevelDataGridViewTextBoxColumn";
            // 
            // courselevelDataGridViewTextBoxColumn
            // 
            this.courselevelDataGridViewTextBoxColumn.DataPropertyName = "Courselevel";
            this.courselevelDataGridViewTextBoxColumn.HeaderText = "Courselevel";
            this.courselevelDataGridViewTextBoxColumn.Name = "courselevelDataGridViewTextBoxColumn";
            // 
            // studentNumberDataGridViewTextBoxColumn
            // 
            this.studentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.HeaderText = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.Name = "studentNumberDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(AdvProAssig.Student);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 575);
            this.Controls.Add(this.btnTestServerCommand);
            this.Controls.Add(this.txtboxTest);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn graduateLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courselevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.RichTextBox txtboxTest;
        private System.Windows.Forms.Button btnTestServerCommand;
    }
}