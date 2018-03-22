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
            Student.addStudent(txtBoxFirstName.Text, txtBoxSurname.Text, txtBoxEmail.Text, txtBoxPhone.Text, txtBoxAdl1.Text, txtBoxAdl2.Text, cbCounties.Text, txtBoxCity.Text, IsRadioButtonSelect(), cbCourse.Text, int.Parse(txtBoxStudentNumber.Text));
            Student newstudent = new Student(txtBoxFirstName.Text, txtBoxSurname.Text, txtBoxEmail.Text, txtBoxPhone.Text, txtBoxAdl1.Text, txtBoxAdl2.Text, cbCounties.Text, txtBoxCity.Text, IsRadioButtonSelect(), cbCourse.Text, int.Parse(txtBoxStudentNumber.Text));
            newstudent.ExportToXml(newstudent);
            Clearfields()
        }

        private void Clearfields()
        {
            txtBoxFirstName.Clear(), txtBoxSurname.Clear(), txtBoxEmail.Clear(), txtBoxPhone.Clear(), txtBoxAdl1.Clear(), txtBoxAdl2.Clear(), cbCounties.Clear(), txtBoxCity.Clear(), , cbCourse.Text, int.Parse(txtBoxStudentNumber.Text)
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
        public string IsRadioButtonSelect()
        {
            if (rbUnderGrad.Checked)
                return rbUnderGrad.Text;
            else if (rbPostGrad.Checked)
                return rbPostGrad.Text;
            else return string.Format("None selected");
        }
    }
}
