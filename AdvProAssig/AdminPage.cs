using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvProAssig;

namespace AdvProAssig
{
    public partial class AdminPage : Form
    {
        Staff adminstaff = new Staff();
        public AdminPage()
        {
            InitializeComponent();
            LoadStaffList();
            txtBoxPassword.PasswordChar = '*';
        }
        private void LoadStaffList()
        {
            foreach(Staff staff in adminstaff.GetstaffList())
            {
                txtBoxStaffList.Text += staff.UserName+"\n";
            }
        }
        #region MenuControls
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
        private void menuLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm studentpage = new LoginForm();
            studentpage.ShowDialog();
            this.Close();
        }
        #endregion

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                adminstaff.AddStaff(txtBoxUserName.Text, txtBoxPassword.Text);
                txtBoxUserName.Clear();
                txtBoxPassword.Clear();
                MessageBox.Show("Added Succesfully");
                ReturntoMainScreen();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDeletThis_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(adminstaff.FindStaffMemberandDelete(txtBoxSearchable.Text));
                ReturntoMainScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void menuReturn_Click(object sender, EventArgs e)
        {
            ReturntoMainScreen();
        }

        private void ReturntoMainScreen()
        {
            this.Hide();
            MainForm mainscreenturnon = new MainForm();
            mainscreenturnon.ShowDialog();
            this.Close();
        }
    }
}
