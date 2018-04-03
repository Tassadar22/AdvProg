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
    public partial class AdminLogin : Form
    {
        Staff AdminStaff = new Staff();//Object created for modifying staff page
        public AdminLogin()
        {
            InitializeComponent();
            txtBoxPassword.PasswordChar = '*';//obscure login
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {//Function to return to main menu
            this.Hide();
            MainForm returntomain = new MainForm();
            returntomain.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {//Login method to check password for administrator account only
            switch(AdminStaff.UserNamePasswordChecker("Administrator",txtBoxPassword.Text))
            {
                case 'a':
                    this.Hide();
                    AdminPage adminpage = new AdminPage();
                    adminpage.ShowDialog();
                    this.Close();
                    break;
                case 'b':
                    MessageBox.Show("Incorrect Password Entered");
                    break;
            }
        }

        #region Menu
        private void menuLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm studentpage = new LoginForm();
            studentpage.ShowDialog();
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

        private void menuEditStu_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditStudent editpage = new EditStudent();
            editpage.ShowDialog();
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
        #endregion
    }
}
