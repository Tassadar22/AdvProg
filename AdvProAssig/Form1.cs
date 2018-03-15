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
        //Variable for passing values between both checker functions
        Staff loginstaff = new Staff();
        static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDataBase;Integrated Security=True;";
        SqlConnection conn = new SqlConnection(ConnectionString);
        public LoginForm()
        {
            InitializeComponent();
            DummyStaffDataEntry();
            txtBoxPassword.PasswordChar = '*';
            /*using (conn)
            {
                conn.Open();
                if(conn.State==ConnectionState.Open)
                    txtBoxTest.Text = "Connection succesful";
            }*/
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

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

    }
}
