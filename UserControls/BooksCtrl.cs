using LibraryApp.Entities;
using LibraryApp.Forms;
using LibraryApp.Helpers;
using LibraryApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.UserControls
{
    public partial class BooksCtrl : UserControl
    {
        private readonly IBookRepository _bookRepo;
        private readonly ILoanRepository _loanRepo;
        private readonly IServiceProvider _serviceProvider;
        private LibraryUser currentUser = AppSession.CurrentUser!;
        public BooksCtrl(IBookRepository bookRepo, IServiceProvider serviceProvider, ILoanRepository loanRepo)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _bookRepo = bookRepo;
            _loanRepo = loanRepo;
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HandleButtons();
            await ReadBooks();
        }
        private async Task ReadBooks(string? author = null, string? title = null)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Author");
            table.Columns.Add("Title");
            table.Columns.Add("Borrowed");

            List<Book> books;
            if (string.IsNullOrEmpty(author) && string.IsNullOrEmpty(title))
            {
                books = await _bookRepo.GetAll();
            }
            else
            {
                books = await _bookRepo.Search(author, title);
            }
            foreach (Book book in books)
            {
                DataRow row = table.NewRow();
                row["ID"] = book.Id;
                row["Author"] = book.Author;
                row["Title"] = book.Title;
                row["Borrowed"] = book.IsBorrowed ? "Yes" : "No";
                table.Rows.Add(row);
            }
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = table;
            if (dgvBooks.Columns["ID"] != null)
            {
                dgvBooks.Columns["ID"]!.Visible = false;
            }
        }
        private void HandleButtons()
        {
            if (currentUser.Role == "Admin")
            {
                btnAdd.Enabled = true;
                btnAdd.Visible = true;
                btnEdit.Enabled = true;
                btnEdit.Visible = true;
                btnDelete.Enabled = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnAdd.Visible = false;
                btnEdit.Enabled = false;
                btnEdit.Visible = false;
                btnDelete.Enabled = false;
                btnDelete.Visible = false;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            CreateEditBookForm form = _serviceProvider.GetRequiredService<CreateEditBookForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadBooks();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            string? val = this.dgvBooks.SelectedRows[0].Cells[0].Value!.ToString();
            if (val == null || val.Length == 0) return;
            int id = int.Parse(val);
            Book? book = await _bookRepo.Get(id);
            if (book == null) return;
            CreateEditBookForm form = _serviceProvider.GetRequiredService<CreateEditBookForm>();
            form.EditBook(book);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await ReadBooks();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string? val = this.dgvBooks.SelectedRows[0].Cells[0].Value!.ToString();
            if (val == null || val.Length == 0) return;
            int id = int.Parse(val);
            Book? book = await _bookRepo.Get(id);
            if (book == null) return;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this book ?", "Delete Book", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            await _bookRepo.Delete(book);
            await _bookRepo.SaveChangesAsync();
            await ReadBooks();
        }
        private async void tbAuthorFilter_TextChanged(object sender, EventArgs e)
        {
            await ReadBooks(tbAuthorFilter.Text, tbTitleFilter.Text);
        }
        private async void tbTitleFilter_TextChanged(object sender, EventArgs e)
        {
            await ReadBooks(tbAuthorFilter.Text, tbTitleFilter.Text);
        }

        private async void btnBorrow_Click(object sender, EventArgs e)
        {
            string? val = this.dgvBooks.SelectedRows[0].Cells[0].Value!.ToString();
            if (val == null || val.Length == 0) return;
            int bookId = int.Parse(val);
            Book? book = await _bookRepo.Get(bookId);
            if (book == null) return;
            if (book.IsBorrowed)
            {
                MessageBox.Show("This book is already borrowed.");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to borrow this book ?", "Borrow a Book", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            book.IsBorrowed = true;
            Loan loan = new Loan
            {
                BookId = book.Id,
                UserId = currentUser.Id,
                BorrowedByUser = currentUser,
                BorrowedFrom = DateTime.Now,
            };
            await _loanRepo.Add(loan);
            await _loanRepo.SaveChangesAsync();

            await ReadBooks();
        }
    }
}
