using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Entities
{
    public class LibraryUser
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        //BOOKS
        public List<Loan> Loans { get; set; } = new();
    }
}
