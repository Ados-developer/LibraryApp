using LibraryApp.Entities;
using LibraryApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public partial class CreateEditBookForm : BaseForm
    {
        private readonly IBookRepository _bookRepo;
        public CreateEditBookForm(IBookRepository bookRepo)
        {
            InitializeComponent();
            _bookRepo = bookRepo;
            this.DialogResult = DialogResult.Cancel;
        }
        private int bookId = 0;
        public void EditBook(Book book)
        {
            lblTitleCreateEdit.Text = "EDIT BOOK";
            bookId = book.Id;
            tbAuthor.Text = book.Author;
            tbTitle.Text = book.Title;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (bookId == 0)
            {
                Book book = new Book();
                book.Author = tbAuthor.Text;
                book.Title = tbTitle.Text;
                await _bookRepo.Add(book);
            }
            else
            {
                Book? book = await _bookRepo.Get(bookId);
                if (book != null)
                {
                    book.Author = tbAuthor.Text;
                    book.Title = tbTitle.Text;
                }
            }
            await _bookRepo.SaveChangesAsync();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
