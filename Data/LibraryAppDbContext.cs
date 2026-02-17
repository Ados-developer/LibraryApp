using LibraryApp.Entities;
using LibraryApp.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Data
{
    public class LibraryAppDbContext : DbContext
    {
        public LibraryAppDbContext(DbContextOptions<LibraryAppDbContext> options)
        : base(options)
        {
        }
        public DbSet<LibraryUser> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LibraryUser>().HasData(
                new LibraryUser { Id = 1, UserName = "Admin", PasswordHash = PasswordHelper.HashPassword("Admin"), Role = "Admin", FirstName = "Andrej", LastName = "Štrba", DateOfBirth = new DateTime(1998, 2, 28) },
                new LibraryUser { Id = 2, UserName = "User1", PasswordHash = PasswordHelper.HashPassword("test"), Role = "User", FirstName = "Anna", LastName = "Kováćová", DateOfBirth = new DateTime(1985, 3, 14) },
                new LibraryUser { Id = 3, UserName = "User2", PasswordHash = PasswordHelper.HashPassword("test"), Role = "User", FirstName = "Peter", LastName = "Novák", DateOfBirth = new DateTime(1994, 8, 7) },
                new LibraryUser { Id = 4, UserName = "User3", PasswordHash = PasswordHelper.HashPassword("test"), Role = "User", FirstName = "Lucia", LastName = "Horvátová", DateOfBirth = new DateTime(1979, 11, 21) },
                new LibraryUser { Id = 5, UserName = "User4", PasswordHash = PasswordHelper.HashPassword("test"), Role = "User", FirstName = "Martin", LastName = "Šimek", DateOfBirth = new DateTime(2002, 6, 13) }
                );
            modelBuilder.Entity<Book>().HasData(
                // A Song of Ice and Fire
                new Book { Id = 1, Author = "G.R.R. Martin", Title = "A Game of Thrones (A Song of Ice and Fire #1)" },
                new Book { Id = 2, Author = "G.R.R. Martin", Title = "A Clash of Kings (A Song of Ice and Fire #2)" },
                new Book { Id = 3, Author = "G.R.R. Martin", Title = "A Storm of Swords (A Song of Ice and Fire #3)" },
                new Book { Id = 4, Author = "G.R.R. Martin", Title = "A Feast for Crows (A Song of Ice and Fire #4)" },
                new Book { Id = 5, Author = "G.R.R. Martin", Title = "A Dance with Dragons (A Song of Ice and Fire #5)" },
                new Book { Id = 6, Author = "G.R.R. Martin", Title = "The Winds of Winter (A Song of Ice and Fire #6)" },
                new Book { Id = 7, Author = "G.R.R. Martin", Title = "A Dream of Spring (A Song of Ice and Fire #7)" },
                // Harry Potter
                new Book { Id = 8, Author = "J.K. Rowling", Title = "Harry Potter and the Philosopher's Stone" },
                new Book { Id = 9, Author = "J.K. Rowling", Title = "Harry Potter and the Chamber of Secrets" },
                new Book { Id = 10, Author = "J.K. Rowling", Title = "Harry Potter and the Prisoner of Azkaban" },
                new Book { Id = 11, Author = "J.K. Rowling", Title = "Harry Potter and the Goblet of Fire" },
                new Book { Id = 12, Author = "J.K. Rowling", Title = "Harry Potter and the Order of the Phoenix" },
                new Book { Id = 13, Author = "J.K. Rowling", Title = "Harry Potter and the Half-Blood Prince" },
                new Book { Id = 14, Author = "J.K. Rowling", Title = "Harry Potter and the Deathly Hallows" },
                // The Lord of The Rings
                new Book { Id = 15, Author = "J.R.R. Tolkien", Title = "The Hobbit" },
                new Book { Id = 16, Author = "J.R.R. Tolkien", Title = "The Fellowship of the Ring (The Lord of the Rings #1)" },
                new Book { Id = 17, Author = "J.R.R. Tolkien", Title = "The Two Towers (The Lord of the Rings #2)" },
                new Book { Id = 18, Author = "J.R.R. Tolkien", Title = "The Return of the King (The Lord of the Rings #3)" }
                );
        }
    }
}
