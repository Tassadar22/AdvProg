using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdvProAssig
{
    public partial class LoginForm : Form
    {
        List<Staff> stafflist = new List<Staff>();
        DAO dao = new DAO();
        string message;
        //Variable for passing values between both checker functions
        Staff loginstaff = new Staff();
        public LoginForm()
        {
            try
            {
                InitializeComponent();
                DummyStaffDataEntry();
                txtBoxPassword.PasswordChar = '*';
                dao.AddServerData();
                DAO testdao = new DAO();
                List<Student> retrievedlist = new List<Student>();
                retrievedlist = testdao.GetList();
                foreach (Student student in retrievedlist)
                {
                    testresult.Text += student.ToString();
                }
            }
            catch(Exception ex)
            {
                message = ex.Message;
            }
            testresult.Text = message;
        }
     private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 studentpage = new Form2();
            studentpage.ShowDialog();
            this.Close();
            //REMOVE COMMENTS ON FINAL VERSION
            /*if (UserNameChecker(txtBoxUserName.Text))
            {
                PasswordChecker(txtBoxPassword.Text);
            }*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool UserNameChecker(string username)
        {
            bool found = false;
            foreach(Staff user in stafflist)
            {
                if(username.ToLower()==user.UserName.ToLower())
                {
                    found = true;
                    loginstaff = user;
                }
            }
            if (found)
            {
                return true;
            }
            else
            {
                MessageBox.Show("User not found");
                return false;
            }
        }

        private void PasswordChecker(string pass)
        {
            if (pass == loginstaff.Password)
            {
                this.Hide();
                Form2 studentpage = new Form2();
                studentpage.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect password Entered");
            }
        }
        private void DummyStaffDataEntry()
        {
            stafflist.Add(new Staff("Dhoot", "Trumpet"));
            stafflist.Add(new Staff("Seamas", "password"));
            stafflist.Add(new Staff("Staff", "Rod"));
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
