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
        public Form2()
        {
            
            InitializeComponent();

            dataGridStudents.DataSource = Student.studentlist;
            
            


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

        private void testresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTestServerCommand_Click(object sender, EventArgs e)
        {
            txtboxTest.Text = teststu.GetstringList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
