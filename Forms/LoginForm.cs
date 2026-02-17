using LibraryApp.Entities;
using LibraryApp.Helpers;
using LibraryApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public partial class LoginForm : BaseForm
    {
        private readonly ILibraryUserRepository _userRep;
        public LoginForm(ILibraryUserRepository userRep)
        {
            InitializeComponent();
            _userRep = userRep;
        }
        private void CbPassword_CheckedChanged(object? sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !cbPassword.Checked;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            LibraryUser? user = await _userRep.GetByUsername(username);
            if (user == null || !PasswordHelper.VerifyPassword(password, user.PasswordHash))
            {
                MessageBox.Show("Invalid username or password");
                return;
            }
            AppSession.Login(user);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
