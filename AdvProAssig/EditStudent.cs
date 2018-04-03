using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvProAssig
{
    public partial class EditStudent : Form
    {
        Student Displaystudent;
        public EditStudent()
        {
            InitializeComponent();
            txtBoxFirstName.ReadOnly = true;
            txtBoxSurname.ReadOnly = true;
            txtBoxCourse.ReadOnly = true;
            pnlXML.Visible = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clearfields();
        }
        private void butFindStu_Click(object sender, EventArgs e)
        {
            //Update List from database
            Student.PullInfofromDB();
            bool stuidfound,notnull;
            int validintnumber;
            notnull = int.TryParse(txtBoxSearchable.Text, out validintnumber);
            stuidfound = Student.CheckDBforStudentID(validintnumber);
            if (stuidfound&notnull)
            {
                Student foundstudent = Student.StudentFinder(int.Parse(txtBoxSearchable.Text));
                Displaystudent = foundstudent;
                PopulateFieldswithResults(foundstudent);
                MessageBox.Show("Student Found");
                pnlEditStudent.Visible = false;
            }
            else
                MessageBox.Show("Student Not Found");
        }
        private void ReturntoMainScreen()
        {
            this.Hide();
            MainForm mainscreenturnon = new MainForm();
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
            if (!pnlXML.Visible)
            {
                pnlXML.Visible = true;
            }
            else
            {
                pnlXML.Visible = false;
            }
        }
       
        private void btnXMLExport_Click(object sender, EventArgs e)
        {//Function to export to XML

            if (Displaystudent != null)
            {//Checks if display name is already entered
                if (txtboxXMLFileName.Text=="")
                {
                    txtboxXMLFileName.Text = $"{Displaystudent.FirstName} {Displaystudent.Surname} details.xml";
                }
                //Sanity checking, checks if it exists and if so warns user that it will become populated
                if(File.Exists(txtboxXMLFileName.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("File contains previous XML data, if you would like to append to it, select yes\n" +
                        "If No, the original file will be deleted and a new one will be created with the same name", "File is not empty", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {//Puts student object into XML format
                        Displaystudent.ExportToXml(Displaystudent, txtboxXMLFileName.Text, true);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        File.Delete(txtboxXMLFileName.Text);
                        Displaystudent.DeleteDataset();
                        Displaystudent.ExportToXml(Displaystudent, txtboxXMLFileName.Text, false);
                    }
                }
                else
                {
                    Displaystudent.ExportToXml(Displaystudent, txtboxXMLFileName.Text, false);
                }
            }
             else
             {
                MessageBox.Show("Please find a Student using the student ID search feature");
             }
        }
     
        private bool FullFieldChecker()
        {//Check if all fields are populated before sending data on 
            bool allFieldsFull = true;
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {//Open file dialog box to search for XML file
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Browse XML Files";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtboxXMLFileName.Text = openFileDialog1.FileName;
            }
        }
        #region Menu
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainscreenturnon = new MainForm();
            mainscreenturnon.ShowDialog();
            this.Close();
        }

        private void menuExit_Click(object sender, EventArgs e)
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

        private void menuReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainscreenturnon = new MainForm();
            mainscreenturnon.ShowDialog();
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

        private void menuEditStu_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditStudent editpage = new EditStudent();
            editpage.ShowDialog();
            this.Close();
        }
        private void administrator7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin passwordlogin = new AdminLogin();
            passwordlogin.ShowDialog();
            this.Close();
        }
        #endregion

        private void btnEditStu_Click(object sender, EventArgs e)
        {
            //Form Checker which checks certain broad fields for null values before entry
            if (FullFieldChecker())
            {
                string result;
                result = Student.EditStudentValidator(txtBoxEmail.Text, txtBoxPhone.Text, txtBoxAdl1.Text, txtBoxAdl2.Text, cbCounties.Text, txtBoxCity.Text, SelectedRadioButton(), txtBoxSearchable.Text, txtBoxStudentNumber.Text);
                if (result == "Data Succesfully updated")//Pass functions passed to Student class
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
            else
            {
                MessageBox.Show("Please Complete the following fields:\n" +
                    "First Name, Surname, Email, Phone, Address Line 1\n" +
                    "and City");
            }
        }
    }
}
