using LibraryApp.Data;
using LibraryApp.Entities;
using LibraryApp.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Repositories
{
    public class LibraryUserRepository : ILibraryUserRepository
    {
        private readonly LibraryAppDbContext _db;
        public LibraryUserRepository(LibraryAppDbContext db)
        {
            _db = db;
        }
        public async Task<LibraryUser?> Get(int id)
        {
            return await _db.Users.FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<List<LibraryUser>> GetAll()
        {
            return await _db.Users.ToListAsync();
        }
        public async Task<LibraryUser?>GetByUsername(string username)
        {
            return await _db.Users.FirstOrDefaultAsync(u => u.UserName == username);
        }
        public async Task Add(LibraryUser user)
        {
            await _db.Users.AddAsync(user);
        }
        public Task Delete(LibraryUser user)
        {
            _db.Remove(user);
            return Task.CompletedTask;
        }
        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
