using LibraryApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Interfaces
{
    public interface ILoanRepository
    {
        Task<Loan?> Get(int id);
        Task<List<Loan>> GetAll();
        Task<List<Loan>> GetAllByUser(int userId);
        Task Add(Loan loan);
        Task Delete(Loan loan);
        Task SaveChangesAsync();
    }
}
