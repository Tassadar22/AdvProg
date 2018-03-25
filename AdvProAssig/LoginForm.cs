﻿using System;
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
        ModifyStudentRecord findstu = new ModifyStudentRecord();
        //Variable for passing values between both checker functions
        Staff loginstaff = new Staff();
        public LoginForm()
        {
                InitializeComponent();
                //Add * character to password textbox
                txtBoxPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            switch(loginstaff.UserNamePasswordChecker(txtBoxUserName.Text, txtBoxPassword.Text))
            {
                case 'a':
                    //Upon succesful login
                    this.Hide();
                    MainForm studentpage = new MainForm();
                    studentpage.ShowDialog();
                    this.Close();
                    break;
                case 'b':
                    MessageBox.Show("Incorrect Password entered");
                    break;
                case 'c':
                    MessageBox.Show("Username Not Found");
                    break;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Quick login button added for testing purposes
        private void btnQkLogin_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            MainForm studentpage = new MainForm();
            studentpage.ShowDialog();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}