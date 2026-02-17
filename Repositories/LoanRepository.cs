using LibraryApp.Data;
using LibraryApp.Entities;
using LibraryApp.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly LibraryAppDbContext _db;
        public LoanRepository(LibraryAppDbContext db) { _db = db; }
        public async Task<Loan?> Get(int id)
        {
            return await _db
                .Loans
                .Include(l => l.BorrowedBook)
                .Include(l => l.BorrowedByUser)
                .FirstOrDefaultAsync(l => l.Id == id);
        }
        public async Task<List<Loan>> GetAll()
        {
            return await _db
                .Loans
                .Include(l => l.BorrowedBook)
                .Include(l => l.BorrowedByUser)
                .ToListAsync();
        }
        public async Task<List<Loan>> GetAllByUser(int userId)
        {
            return await _db
                .Loans
                .Where(l => l.UserId == userId)
                .Include(l => l.BorrowedBook)
                .Include(l => l.BorrowedByUser)
                .ToListAsync();
        }
        public async Task Add(Loan loan)
        {
            await _db.Loans.AddAsync(loan);
        }
        public Task Delete(Loan loan)
        {
            _db.Loans.Remove(loan);
            return Task.CompletedTask;
        }
        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
