﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlDemo
{
    public partial class LoginAgain : Form
    {
        public LoginAgain()
        {
            InitializeComponent();
            loginAgainControl.LoginFailed += this.LoginFailed;
            loginAgainControl.LoginSuccess += this.LoginSuccess;
        }

        // This Event is fired by the Login Validation User Control
        private void LoginFailed(object sender, EventArgs e)
        {
            MessageBox.Show("Login falied ....", "Login Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // This Event is fired by the Login Validation User Control
        private void LoginSuccess(object sender, EventArgs e)
        {
            MessageBox.Show("Login success you can delete users", "Login Validation",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            MainForm.logged = true;
            this.Close();
        }
    }
}
