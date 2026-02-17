using LibraryApp.Entities;
using LibraryApp.Helpers;
using LibraryApp.Interfaces;
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
    public partial class ReturnsCtrl : UserControl
    {
        private readonly ILoanRepository _loanRepo;
        private readonly IBookRepository _bookRepo;
        public ReturnsCtrl(ILoanRepository loanRepo, IBookRepository bookRepo)
        {
            InitializeComponent();
            _bookRepo = bookRepo;
            _loanRepo = loanRepo;
        }
        private LibraryUser? currentUser = AppSession.CurrentUser;
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await ReadLoans();
        }
        public async Task ReadLoans()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Book Title");
            table.Columns.Add("Book Author");
            table.Columns.Add("From");
            table.Columns.Add("To");

            List<Loan> loans = await _loanRepo.GetAllByUser(currentUser!.Id);
            foreach (Loan loan in loans)
            {
                DataRow row = table.NewRow();
                row["ID"] = loan.Id;
                row["Book Title"] = loan.BorrowedBook.Title;
                row["Book Author"] = loan.BorrowedBook.Author;
                row["From"] = loan.BorrowedFrom.ToString("yyyy-MM-dd HH:mm");
                row["To"] = loan.BorrowedTo.HasValue ? loan.BorrowedTo.Value.ToString("yyyy-MM-dd HH:mm") : "";
                table.Rows.Add(row);
            }
            dgvLoans.DataSource = null;
            dgvLoans.DataSource = table;
            if (dgvLoans.Columns["ID"] != null)
            {
                dgvLoans.Columns["ID"]!.Visible = false;
            }
        }

        private async void btnReturn_Click(object sender, EventArgs e)
        {
            string? val = this.dgvLoans.SelectedRows[0].Cells[0].Value!.ToString();
            if (val == null || val.Length == 0) return;
            int loanId = int.Parse(val);
            Loan? loan = await _loanRepo.Get(loanId);
            if (loan == null) return;
            Book? book = await _bookRepo.Get(loan.BookId);
            if (book == null) return;
            if(loan.BorrowedTo != null)
            {
                MessageBox.Show("This Book was already returned.");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to return this book ?", "Return The Book", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            book.IsBorrowed = false;
            loan.BorrowedTo = DateTime.Now;
            await _loanRepo.SaveChangesAsync();
            await ReadLoans();
        }
    }
}
