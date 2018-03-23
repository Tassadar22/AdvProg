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
        private DataSet StudentDataSet;
        public AddStudent()
        {
            InitializeComponent();
            Student teststudent = new Student("John", "w", "wad@awd.com", "4545", "45613", "456", "45", "dublin", "Postgraduate", "Psychology", 456464);
            teststudent.ExportToXml(teststudent);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string result;
            result =Student.StudentAddingValidator(txtBoxFirstName.Text, txtBoxSurname.Text, txtBoxEmail.Text, txtBoxPhone.Text, txtBoxAdl1.Text, txtBoxAdl2.Text, cbCounties.Text, txtBoxCity.Text, SelectedRadioButton(), cbCourse.Text, txtBoxStudentNumber.Text);
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
            cbCounties.Text = string.Empty;
            cbCourse.Text = string.Empty;
            rbPostGrad.Checked = false;
            rbUnderGrad.Checked = false;
        }

        private void btnExporttoXML_Click(object sender, EventArgs e)
        {
            DataTable DTS;
            if(StudentDataSet == null)
            {
                StudentDataSet = new DataSet("Students");
                DTS = new DataTable("Student");
                DTS.Columns.Add("FirstName");
                DTS.Columns.Add("Surname");
                DTS.Columns.Add("Email");
                DTS.Columns.Add("Phone");
                DTS.Columns.Add("AddLin1");
                DTS.Columns.Add("AddLin2");
                DTS.Columns.Add("County");
                DTS.Columns.Add("City");
                DTS.Columns.Add("Courselevel");
                DTS.Columns.Add("Course");
                DTS.Columns.Add("StuNum");
                StudentDataSet.Tables.Add(DTS);
            }
            DTS = StudentDataSet.Tables["Student"];
            DataRow rowstu = DTS.NewRow();
        }

        //Consider deleting
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
    }
}
