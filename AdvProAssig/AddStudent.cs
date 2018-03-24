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

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string result;
            result = Student.AddStudentValidator(txtBoxFirstName.Text, txtBoxSurname.Text, txtBoxEmail.Text, txtBoxPhone.Text, txtBoxAdl1.Text, txtBoxAdl2.Text, cbCounties.Text, txtBoxCity.Text, SelectedRadioButton(), cbCourse.Text, txtBoxStudentNumber.Text);
            if(result=="Data Succesfully Added")
            {
                MessageBox.Show(result);
                Clearfields();
            }
            else
            {
                MessageBox.Show(result);
            }
            
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

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
