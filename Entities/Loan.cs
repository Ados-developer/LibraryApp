using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryApp.Entities
{
    public class Loan
    {
        public int Id { get; set; }
        public DateTime BorrowedFrom { get; set; }
        public DateTime? BorrowedTo { get; set; }
        [ForeignKey(nameof(UserId))]
        public int UserId { get; set; }
        public LibraryUser? BorrowedByUser { get; set; } = null!;
        [ForeignKey(nameof(BookId))]
        public int BookId { get; set; }
        public Book BorrowedBook { get; set; } = null!;
    }
}
