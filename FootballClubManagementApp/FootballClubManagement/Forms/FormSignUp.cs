using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FootballClubManagement.Forms
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }
        private void btnSignIn_MouseLeave(object sender, EventArgs e)
        {
            this.btnSignUp.BackColor = Color.MediumSpringGreen;
        }

        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            this.txtUserName.BackColor = Color.PaleTurquoise;
            this.ActiveControl = null;
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            this.txtPassword.BackColor = Color.PaleTurquoise;
            this.ActiveControl = null;
        }

        private void btnSignIn_MouseEnter(object sender, EventArgs e)
        {
            this.btnSignUp.BackColor = Color.MediumAquamarine;
        }

        private void txtUserName_MouseEnter(object sender, EventArgs e)
        {
            this.txtUserName.BackColor = Color.White;
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            this.txtPassword.BackColor = Color.White;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (this.txtUserName.Text.IsWhiteSpace())
            {
                MessageBox.Show("You need to fill in user name !", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.txtPassword.Text.IsWhiteSpace())
            {
                MessageBox.Show("You need to fill in password !", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();
                new FormMain().Show();
            }
        }

        private void lbSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }
    }
}
