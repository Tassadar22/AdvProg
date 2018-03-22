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
    public partial class Form2 : Form
    {
        DataAccess.ModifyStudentRecord teststu = new DataAccess.ModifyStudentRecord();
        Student student = new Student();
        List<Student> updatedlist = new List<Student>();
        public Form2()
        {
            InitializeComponent();
            LoadDataGrid();

            updatedlist=student.Exportlist(updatedlist);
        }

        private void LoadDataGrid()
        {
            dataGridStudents.ColumnCount = 11;
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
            
            foreach (Student student in updatedlist)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridStudents.Rows[0].Clone();
                row.Cells[0].Value = student.FirstName;
                row.Cells[1].Value = student.Surname;
                row.Cells[2].Value = student.Email;
                row.Cells[3].Value = student.Phone;
                row.Cells[4].Value = student.AddressLine1;
                row.Cells[5].Value = student.AddressLine2;
                row.Cells[6].Value = student.City;
                row.Cells[7].Value = student.County;
                row.Cells[8].Value = student.GraduateLevel;
                row.Cells[9].Value = student.Courselevel;
                row.Cells[10].Value = student.StudentNumber;
                dataGridStudents.Rows.Add(row);
            }
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
       private void btnTestServerCommand_Click(object sender, EventArgs e)
       {
            string output="";
            foreach(Student student in updatedlist)
            {
                output += student.ToString();
            }
            txtboxTest.Text = output; 
       }

    }
}
