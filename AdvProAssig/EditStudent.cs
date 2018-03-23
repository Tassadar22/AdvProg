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
    public partial class EditStudent : Form
    {
        Student searchablestu = new Student();
        Student Displaystudent;
        public EditStudent()
        {
            InitializeComponent();
            txtBoxFirstName.ReadOnly = true;
            txtBoxSurname.ReadOnly = true;
            txtBoxCourse.ReadOnly = true;
            pnlXML.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturntoMainScreen();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clearfields();
        }
        private void butFindStu_Click(object sender, EventArgs e)
        {
            //Update List from database
            Student.PullInfofromDB();
            bool stuidfound;
            stuidfound = Student.CheckDBforStudentID(int.Parse(txtBoxSearchable.Text));
            if (stuidfound)
            {
                Student foundstudent = Student.StudentFinder(int.Parse(txtBoxSearchable.Text));
                Displaystudent = foundstudent;
                PopulateFieldswithResults(foundstudent);
                MessageBox.Show("Student Found");
            }
            else
                MessageBox.Show("Student Not Found");
        }
      

        private void ReturntoMainScreen()
        {
            this.Hide();
            Form2 mainscreenturnon = new Form2();
            mainscreenturnon.ShowDialog();
            this.Close();
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
            txtBoxFirstName.Clear(); txtBoxSurname.Clear(); txtBoxEmail.Clear(); txtBoxPhone.Clear(); txtBoxAdl1.Clear(); txtBoxAdl2.Clear(); txtBoxCity.Clear(); txtBoxStudentNumber.Clear(); txtBoxCourse.Clear();
            cbCounties.Text = " ";
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

      
        private void txtBoxSearchable_TextChanged(object sender, EventArgs e)
        {   //Validation function that uses regex to insure only integer value is entered
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxSearchable.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtBoxSearchable.Text = txtBoxSearchable.Text.Remove(txtBoxSearchable.Text.Length - 1);
            }
        }

        private void btnToggleXML_Click(object sender, EventArgs e)
        {
            if(!pnlXML.Visible)
            {
                pnlXML.Visible = true;
            }
            else
            {
                pnlXML.Visible = false;
            }
        }
        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            string result;
            result = Student.EditStudentValidator(txtBoxEmail.Text, txtBoxPhone.Text, txtBoxAdl1.Text, txtBoxAdl2.Text, cbCounties.Text, txtBoxCity.Text, SelectedRadioButton(), txtBoxSearchable.Text, txtBoxStudentNumber.Text);
            if (result == "Data Succesfully updated")
            {
                MessageBox.Show(result);
                Clearfields();
                Displaystudent = null;
            }
            else
            {
                MessageBox.Show(result);
            }
        }
        private void btnXMLExport_Click(object sender, EventArgs e)
        {
            if (Displaystudent != null)
            {
                if (txtboxXMLFileName.Text == null)
                    txtboxXMLFileName.Text = $"{Displaystudent.FirstName} {Displaystudent.Surname} Details";
                DialogResult dialogResult = MessageBox.Show("File contains previous XML data, would you like to overwrite it?", "File is not empty", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Please Enter new File name");
                    Displaystudent.ExportToXml(Displaystudent, txtboxXMLFileName.Text);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Please find a Student using the student ID search feature");
            }
        }
        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
