using LibraryApp.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Helpers
{
    public static class AppSession
    {
        public static LibraryUser? CurrentUser { get; private set; }
        public static bool IsLoggedIn => CurrentUser != null;
        public static bool IsAdmin => CurrentUser?.Role == "Admin";
        public static bool IsUser => CurrentUser?.Role == "User";

        public static void Login(LibraryUser user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
