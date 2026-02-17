using LibraryApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Interfaces
{
    public interface ILibraryUserRepository
    {
        Task<LibraryUser?> Get(int id);
        Task<List<LibraryUser>> GetAll();
        Task<LibraryUser?> GetByUsername(string userName);
        Task Add(LibraryUser libraryUser);
        Task Delete(LibraryUser libraryUser);
        Task SaveChangesAsync();
    }
}
