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
    public partial class CreateEditUserForm : BaseForm
    {
        private readonly ILibraryUserRepository _userRepo;
        public CreateEditUserForm(ILibraryUserRepository userRepo)
        {
            InitializeComponent();
            _userRepo = userRepo;
            this.DialogResult = DialogResult.Cancel;
            this.mcDate.Visible = false;
            this.mcDate.Enabled = false;
        }
        private void CbPassword_CheckedChanged(object? sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !cbPassword.Checked;
        }
        public int userId = 0;
        public void EditUser(LibraryUser user)
        {
            this.lblTitleCreateEdit.Text = "EDIT USER";
            this.lblPassword.Visible = false;
            this.tbPassword.Enabled = false;
            this.tbPassword.Visible = false;
            this.cbPassword.Enabled = false;
            this.cbPassword.Visible = false;
            this.userId = user.Id;
            this.tbUsername.Text = user.UserName;
            this.tbFirstName.Text = user.FirstName;
            this.tbLastName.Text = user.LastName;
            this.tbDateOfBirth.Text = user.DateOfBirth.ToString("yyyy-MM-dd");
            this.mcDate.SelectionStart = user.DateOfBirth;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (userId == 0)
            {
                LibraryUser user = new LibraryUser();
                user.UserName = this.tbUsername.Text;
                user.PasswordHash = PasswordHelper.HashPassword(this.tbPassword.Text);
                user.FirstName = this.tbFirstName.Text;
                user.LastName = this.tbLastName.Text;
                user.DateOfBirth = this.mcDate.SelectionStart;
                user.Role = "User";
                await _userRepo.Add(user);
            }
            else
            {
                LibraryUser? user = await _userRepo.Get(userId);
                if (user != null)
                {
                    user.UserName = this.tbUsername.Text;
                    user.FirstName = this.tbFirstName.Text;
                    user.LastName = this.tbLastName.Text;
                    user.DateOfBirth = this.mcDate.SelectionStart;
                }
            }
            await _userRepo.SaveChangesAsync();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            if (btnDate.IconChar == FontAwesome.Sharp.IconChar.CalendarDays)
            {
                btnDate.IconChar = FontAwesome.Sharp.IconChar.X;
                mcDate.Visible = true;
                mcDate.Enabled = true;
            }
            else
            {
                btnDate.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
                mcDate.Visible = false;
                mcDate.Enabled = false;
            }
        }

        private void mcDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            tbDateOfBirth.Text = mcDate.SelectionStart.ToString("yyyy-MM-dd");
            mcDate.Visible = false;
            mcDate.Enabled = false;
            btnDate.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
        }
    }
}
