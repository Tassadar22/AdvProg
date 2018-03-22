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
            this.txtboxTest = new System.Windows.Forms.RichTextBox();
            this.btnTestServerCommand = new System.Windows.Forms.Button();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(93, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(184, 12);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
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
            // dataGridStudents
            // 
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Location = new System.Drawing.Point(242, 59);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.Size = new System.Drawing.Size(731, 267);
            this.dataGridStudents.TabIndex = 7;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(AdvProAssig.Student);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 575);
            this.Controls.Add(this.dataGridStudents);
            this.Controls.Add(this.btnTestServerCommand);
            this.Controls.Add(this.txtboxTest);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.RichTextBox txtboxTest;
        private System.Windows.Forms.Button btnTestServerCommand;
        private System.Windows.Forms.DataGridView dataGridStudents;
    }
}