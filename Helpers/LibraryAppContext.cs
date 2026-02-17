using LibraryApp.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Helpers
{
    public class LibraryAppContext : ApplicationContext
    {
        private readonly IServiceProvider _services;

        public LibraryAppContext(IServiceProvider services)
        {
            _services = services;
            ShowLogin();
        }

        private void ShowLogin()
        {
            var login = _services.GetRequiredService<LoginForm>();
            login.FormClosed += (s, e) =>
            {
                if (login.DialogResult == DialogResult.OK)
                    ShowMain();
                else
                    ExitThread();
            };
            login.Show();
        }

        private void ShowMain()
        {
            var main = _services.GetRequiredService<LibraryAppForm>();
            main.FormClosed += (s, e) =>
            {
                AppSession.Logout();
                ShowLogin();
            };
            main.Show();
        }
    }
}
