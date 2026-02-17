using LibraryApp.Entities;
using LibraryApp.Forms;
using LibraryApp.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryApp.UserControls
{
    public partial class ProfileCtrl : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        public ProfileCtrl(IServiceProvider serviceProvider)
        { 
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        private LibraryUser currentUser = AppSession.CurrentUser!;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadProfile();
        }
        private void LoadProfile()
        {
            lblUsername.Text = currentUser.UserName;
            lblFirstName.Text = currentUser.FirstName;
            lblLastName.Text = currentUser.LastName;
            lblDateOfBirth.Text = currentUser.DateOfBirth.ToString("yyyy-MM-dd");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CreateEditUserForm editForm = _serviceProvider.GetRequiredService<CreateEditUserForm>();
            editForm.EditUser(currentUser);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadProfile();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = _serviceProvider.GetRequiredService<ChangePasswordForm>();
            if(form.ShowDialog() == DialogResult.OK)
            {
                LoadProfile();
            }
        }
    }
}
