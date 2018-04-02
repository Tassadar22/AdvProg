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
    public partial class DatabaseHistory : Form
    {
        Staff methodstaff = new Staff();
        List<Staff> stafflist = new List<Staff>();
        public DatabaseHistory()
        {
            InitializeComponent();
            stafflist = methodstaff.GetstaffList();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            var list = new BindingList<Staff>(stafflist);
            dataGridStaff.DataSource = list;

            dataGridStaff.Columns[0].Name = "User Name";
            dataGridStaff.Columns[1].Name = "Password";
            dataGridStaff.AutoSize = true;
            dataGridStaff.AutoGenerateColumns = false;
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

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainscreenturnon = new MainForm();
            mainscreenturnon.ShowDialog();
            this.Close();
        }
    }
}
