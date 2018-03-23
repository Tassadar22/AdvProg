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
    public partial class EditStudent : Form
    {
        Student searchablestu = new Student();
        public EditStudent()
        {
            InitializeComponent();
            txtBoxFirstName.ReadOnly = true;
            txtBoxSurname.ReadOnly = true;
            txtBoxCourse.ReadOnly = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 mainscreenturnon = new Form2();
            mainscreenturnon.ShowDialog();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clearfields();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Update List from database
            Student.PullInfofromDB();
            bool stuidfound;
            stuidfound = Student.CheckDBforStudentID(int.Parse(txtBoxSearchable.Text));
            if (stuidfound)
            {
                Student foundstudent = Student.StudentFinder(int.Parse(txtBoxSearchable.Text));
                PopulateFieldswithResults(foundstudent);
                MessageBox.Show("Student Found");
            }
            else
                MessageBox.Show("Student Not Found");

        }

        private void PopulateFieldswithResults(Student student)
        {//Function populate fields with results 
            txtBoxFirstName.Text = student.FirstName;
            txtBoxSurname.Text = student.Surname;
            txtBoxEmail.Text = student.Email;
            txtBoxPhone.Text = student.Phone;
            txtBoxAdl1.Text = student.AddressLine1;
            txtBoxAdl2.Text = student.AddressLine2;
            cbCounties.Text = student.County;
            txtBoxCity.Text = student.City;
            txtBoxCourse.Text = student.Course;
            if (student.GraduateLevel == rbUnderGrad.Text)
                rbUnderGrad.Select();
            else
                rbPostGrad.Select();
            txtBoxStudentNumber.Text = student.StudentNumber.ToString();
        }
        private void Clearfields()
        {
            txtBoxFirstName.Clear(); txtBoxSurname.Clear(); txtBoxEmail.Clear(); txtBoxPhone.Clear(); txtBoxAdl1.Clear(); txtBoxAdl2.Clear(); txtBoxCity.Clear(); txtBoxStudentNumber.Clear();
            cbCounties.Text = string.Empty;
            txtBoxCourse.Text = string.Empty;
            rbPostGrad.Checked = false;
            rbUnderGrad.Checked = false;
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {

        }
    }
}