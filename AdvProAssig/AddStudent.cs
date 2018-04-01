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
            Student teststudent = new Student("John", "w", "wad@awd.com", "4545", "45613", "456", "45", "dublin", "Postgraduate", "Psychology", 456464);
        }
        private void Clearfields()
        {
            //function to clear all fields 
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
        {
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
    }
}
