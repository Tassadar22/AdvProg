using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvProAssig.DataAccess;
using System.Security.Cryptography;

namespace AdvProAssig
{
    public partial class LoginForm : Form
    {
        //Variable for passing values between both checker functions
        Staff loginstaff = new Staff();
        public LoginForm()
        {
                InitializeComponent();
                //Add * character to password textbox
                txtBoxPassword.PasswordChar = '*';
        }
        //Quick login button added for testing purposes
        private void btnQkLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm studentpage = new MainForm();
            studentpage.ShowDialog();
            this.Close();
        }
        private void menuLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm studentpage = new LoginForm();
            studentpage.ShowDialog();
            this.Close();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {//Send login data to server to check if user currently exists and user password is correct
            switch (loginstaff.UserNamePasswordChecker(txtBoxUserName.Text, txtBoxPassword.Text))
            {
                case 'a':
                    //Upon succesful login the main form menu is displayed
                    this.Hide();
                    MainForm studentpage = new MainForm();
                    studentpage.ShowDialog();
                    this.Close();
                    break;
                case 'b'://If password is wrong, display this message
                    MessageBox.Show("Incorrect Password entered");
                    break;
                case 'c'://If username not found in list, display message
                    MessageBox.Show("Username Not Found");
                    break;
            }
        }
    }
}
