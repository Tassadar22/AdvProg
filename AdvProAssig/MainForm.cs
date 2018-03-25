﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdvProAssig
{
    public partial class MainForm : Form
    {
        DataAccess.ModifyStudentRecord teststu = new DataAccess.ModifyStudentRecord();
        Student student = new Student();
        List<Student> updatedlist = new List<Student>();
        public MainForm()
        {
            InitializeComponent();
            updatedlist = student.Exportlist(updatedlist);
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            var list = new BindingList<Student>(updatedlist);
            dataGridStudents.DataSource = list;

            //dataGridStudents.DataSource = updatedlist;
            //Create Columns
            //dataGridStudents.ColumnCount = 11;
            dataGridStudents.Columns[0].Name = "First Name";
            dataGridStudents.Columns[1].Name = "Surname";
            dataGridStudents.Columns[2].Name = "Email";
            dataGridStudents.Columns[3].Name = "Phone";
            dataGridStudents.Columns[4].Name = "Address Line 1";
            dataGridStudents.Columns[5].Name = "Address Line 2";
            dataGridStudents.Columns[6].Name = "City";
            dataGridStudents.Columns[7].Name = "County";
            dataGridStudents.Columns[8].Name = "Graduate Level";
            dataGridStudents.Columns[9].Name = "Course level";
            dataGridStudents.Columns[10].Name = "Student Number";
            dataGridStudents.AutoSize = true;
            dataGridStudents.AutoGenerateColumns = false;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm studentpage = new LoginForm();
            studentpage.ShowDialog();
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent studentpage = new AddStudent();
            studentpage.ShowDialog();
            this.Close();
        }
        private void btnEditStu_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditStudent editpage = new EditStudent();
            editpage.ShowDialog();
            this.Close();
        }
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteStudent deletepage = new DeleteStudent();
            deletepage.ShowDialog();
            this.Close();
        }
        private void btnDbHis_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseHistory databaseHistory = new DatabaseHistory();
            databaseHistory.ShowDialog();
            this.Close();
        }
    }
}