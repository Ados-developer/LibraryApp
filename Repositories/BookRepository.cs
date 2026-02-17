using LibraryApp.Data;
using LibraryApp.Entities;
using LibraryApp.Helpers;
using LibraryApp.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryAppDbContext _db;
        public BookRepository(LibraryAppDbContext db)
        {
            _db = db;
        }
        public async Task<Book?> Get(int id)
        {
            return await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
        }
        public async Task<List<Book>> GetAll()
        {
            return await _db.Books.ToListAsync();
        }
        public async Task Add(Book book)
        {
            await _db.Books.AddAsync(book);
        }
        public Task Delete(Book book)
        {
            _db.Books.Remove(book);
            return Task.CompletedTask;
        }
        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
        public async Task<List<Book>> Search(string? author, string? title)
        {
            IQueryable<Book> query = _db.Books;
            if (!string.IsNullOrWhiteSpace(author))
            {
                string filterAuthor = author.Replace(" ","").ToLower();
                query = query.Where(b =>
                    b.Author != null &&
                    b.Author.Replace(" ","").ToLower().Contains(filterAuthor));
            }
            if (!string.IsNullOrWhiteSpace(title))
            {
                string filterTitle = title.Replace(" ", "").ToLower();
                query = query.Where(b =>
                    b.Title != null &&
                    b.Title.Replace(" ", "").ToLower().Contains(filterTitle));
            }
            return await query.ToListAsync();
        }
    }
}
