using LibraryApp.Helpers;
using LibraryApp.UserControls;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class LibraryAppForm : BaseForm
    {
        private readonly IServiceProvider _serviceProvider;
        public LibraryAppForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            lblCurrentUser.Text = AppSession.CurrentUser?.UserName;
            BooksCtrl booksCtrl = _serviceProvider.GetRequiredService<BooksCtrl>();
            ShowUserControl(booksCtrl);
            handleButtons();
        }
        private void ShowUserControl(UserControl control)
        {
            panelUserControls.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelUserControls.Controls.Add(control);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersCtrl userCtrl = _serviceProvider.GetRequiredService<UsersCtrl>();
            ShowUserControl(userCtrl);
        }
        private void handleButtons()
        {
            if (AppSession.CurrentUser!.Role == "Admin")
            {
                btnUsers.Enabled = true;
                btnUsers.Visible = true;
                btnLoans.Enabled = true;
                btnLoans.Visible = true;
            }
            else
            {
                btnUsers.Enabled = false;
                btnUsers.Visible = false;
                btnLoans.Enabled = false;
                btnLoans.Visible = false;
            }
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            ProfileCtrl profileCtrl = _serviceProvider.GetRequiredService<ProfileCtrl>();
            ShowUserControl(profileCtrl);
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BooksCtrl booksCtrl = _serviceProvider.GetRequiredService<BooksCtrl>();
            ShowUserControl(booksCtrl);
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            LoansCtrl loansCtrl = _serviceProvider.GetRequiredService<LoansCtrl>();
            ShowUserControl(loansCtrl);
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            ReturnsCtrl returnsCtrl = _serviceProvider.GetRequiredService<ReturnsCtrl>();
            ShowUserControl(returnsCtrl);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
