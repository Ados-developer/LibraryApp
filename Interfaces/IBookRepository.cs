using LibraryApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Interfaces
{
    public interface IBookRepository
    {
        Task<Book?> Get(int id);
        Task<List<Book>> GetAll();
        Task Add(Book book);
        Task Delete(Book book);
        Task SaveChangesAsync();
        Task<List<Book>> Search(string? author, string? title);
    }
}
