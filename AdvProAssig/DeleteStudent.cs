using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvProAssig.DataAccess;

namespace AdvProAssig
{
    public partial class DeleteStudent : Form
    {
        Student searchablestu = new Student();
        public DeleteStudent()
        {
            InitializeComponent();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturntoMainScreen();
        }


        private void btnFindStudent_Click(object sender, EventArgs e)
        {
           //Update List from database
           Student.PullInfofromDB();
           bool stuidfound, notnull;
            int validintnumber;
           notnull = int.TryParse(txtBoxSearchable.Text, out validintnumber);
           
           stuidfound = Student.CheckDBforStudentID(validintnumber);
           
           if (stuidfound&&notnull)
           {
                Student foundstudent = Student.StudentFinder(int.Parse(txtBoxSearchable.Text));
                PopulateFieldswithResults(foundstudent);
                MessageBox.Show("Student Found");
           }
            else
                MessageBox.Show("Student Not Found");
        }
        private void PopulateFieldswithResults(Student foundstudent)
        {
            txtBoxFirstName.Text = foundstudent.FirstName;
            txtBoxSurname.Text = foundstudent.Surname;
            txtBoxEmail.Text = foundstudent.Email;
            txtBoxPhone.Text = foundstudent.Phone;
            txtBoxAdl1.Text = foundstudent.AddressLine1;
            txtBoxAdl2.Text = foundstudent.AddressLine2;
            txtBoxCounty.Text = foundstudent.County;
            txtBoxCity.Text = foundstudent.City;
            txtBoxCourse.Text = foundstudent.Course;
            if (foundstudent.GraduateLevel == rbUnderGrad.Text)
                rbUnderGrad.Select();
            else
                rbPostGrad.Select();
            txtBoxStudentNumber.Text = foundstudent.StudentNumber.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string result;
            result = Student.RemoveStudent(int.Parse(txtBoxSearchable.Text));
            if (result == "This record has been deleted succesfully")
            {
                MessageBox.Show(result);
                ReturntoMainScreen();
            }
            else
            {
                MessageBox.Show(result);
            }
        }
        
        private void ClearFields()
        {
            txtBoxFirstName.Text = null;
            txtBoxSurname.Text = null;
            txtBoxEmail.Text = null;
            txtBoxPhone.Text = null;
            txtBoxAdl1.Text = null; ;
            txtBoxAdl2.Text = null;
            txtBoxCounty.Text = null;
            txtBoxCity.Text = null;
            txtBoxCourse.Text = null;
            rbUnderGrad.Checked = false;
            rbPostGrad.Checked = false;
            txtBoxStudentNumber.Text = null;
        }
        private void ReturntoMainScreen()
        {
            this.Hide();
            MainForm mainscreenturnon = new MainForm();
            mainscreenturnon.ShowDialog();
            this.Close();
        }
        private void UndoChanges(object sender, EventArgs e)
        {//Validation function that uses regex to insure only integer value is entered
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxSearchable.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtBoxSearchable.Text = txtBoxSearchable.Text.Remove(txtBoxSearchable.Text.Length - 1);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuAddStu_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent studentpage = new AddStudent();
            studentpage.ShowDialog();
            this.Close();
        }

        private void menuEditStu_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditStudent editpage = new EditStudent();
            editpage.ShowDialog();
            this.Close();
        }

        private void menuDelStu_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteStudent deletepage = new DeleteStudent();
            deletepage.ShowDialog();
            this.Close();
        }

        private void menuDataHis_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseHistory databaseHistory = new DatabaseHistory();
            databaseHistory.ShowDialog();
            this.Close();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm studentpage = new LoginForm();
            studentpage.ShowDialog();
            this.Close();
        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
