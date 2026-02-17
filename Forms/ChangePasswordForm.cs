using LibraryApp.Entities;
using LibraryApp.Helpers;
using LibraryApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public partial class ChangePasswordForm : BaseForm
    {
        private readonly ILibraryUserRepository _userRepository;
        public ChangePasswordForm(ILibraryUserRepository userRepository)
        {  
            InitializeComponent();
            _userRepository = userRepository;
            this.DialogResult = DialogResult.Cancel;
        }
        private LibraryUser currentUser = AppSession.CurrentUser!; 
        private async void btnSave_Click(object sender, EventArgs e)
        {
            string oldPassword = tbOldPassword.Text;
            string newPassword = tbNewPassword.Text;
            string confirmNewPassword = tbConfirmNewPassword.Text;
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("New password cannot be empty.");
                return;
            }
            if (!PasswordHelper.VerifyPassword(oldPassword, currentUser.PasswordHash))
            {
                MessageBox.Show("Invalid old password");
                return;
            }
            if(newPassword != confirmNewPassword)
            {
                MessageBox.Show("New passwords do not match.");
                return;
            }
            currentUser.PasswordHash = PasswordHelper.HashPassword(newPassword);
            await _userRepository.SaveChangesAsync();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
