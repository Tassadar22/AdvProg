using System;
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
    public partial class AddStudent : Form
    {
        
        public AddStudent()
        {
            InitializeComponent();
        }
        private void Clearfields()
        {
            //function to clear all fields and reset values to null 
            txtBoxFirstName.Clear(); txtBoxSurname.Clear(); txtBoxEmail.Clear(); txtBoxPhone.Clear(); txtBoxAdl1.Clear(); txtBoxAdl2.Clear(); txtBoxCity.Clear(); txtBoxStudentNumber.Clear();
            cbCounties.Text = " ";
            cbCourse.Text = " ";
            rbPostGrad.Checked = false;
            rbUnderGrad.Checked = false;
        }
        public string SelectedRadioButton()
        {
            if (rbUnderGrad.Checked)
                return rbUnderGrad.Text;
            else if (rbPostGrad.Checked)
                return rbPostGrad.Text;
            else return string.Format("None selected");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clearfields();
        }
        private bool FullFieldChecker()
        {//Validation function
            bool allFieldsFull = true;
            if (txtBoxFirstName.Text == "")
                allFieldsFull = false;
            if (txtBoxSurname.Text == "")
                allFieldsFull = false;
            if (txtBoxEmail.Text == "")
                allFieldsFull = false;
            if (txtBoxPhone.Text == "")
                allFieldsFull = false;
            if (txtBoxAdl1.Text == "")
                allFieldsFull = false;
            if (txtBoxCity.Text == "")
                allFieldsFull = false;
            return allFieldsFull;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region menubuttons
        private void menuLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm studentpage = new LoginForm();
            studentpage.ShowDialog();
            this.Close();
        }
        private void menuMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainscreenturnon = new MainForm();
            mainscreenturnon.ShowDialog();
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
        private void menuAddStu_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent studentpage = new AddStudent();
            studentpage.ShowDialog();
            this.Close();
        }
        #endregion
        private void btnAddStu_Click(object sender, EventArgs e)
        {
            //Form Checker which checks certain broad fields for null values before entry
            if (FullFieldChecker())
            {
                string result = Student.AddStudentValidator(txtBoxFirstName.Text, txtBoxSurname.Text, txtBoxEmail.Text, txtBoxPhone.Text, txtBoxAdl1.Text, txtBoxAdl2.Text, cbCounties.Text, txtBoxCity.Text, SelectedRadioButton(), cbCourse.Text, txtBoxStudentNumber.Text);
                if (result == "Data Succesfully Added")
                {
                    MessageBox.Show(result);
                    Clearfields();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            else
            {
                MessageBox.Show("Please Complete the following fields:\n" +
                    "First Name, Surname, Email, Phone, Address Line 1\n" +
                    "and City");
            }
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin passwordlogin = new AdminLogin();
            passwordlogin.ShowDialog();
            this.Close();
        }
        private void UndoChanges(object sender, EventArgs e)
        {//Validation function that uses regex to insure only integer value is entered and if non integer value is entered deletes character
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxStudentNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtBoxStudentNumber.Text = txtBoxStudentNumber.Text.Remove(txtBoxStudentNumber.Text.Length - 1);
            }
        }
    }
}
