using LibraryApp.Entities;
using LibraryApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryApp.UserControls
{
    public partial class LoansCtrl : UserControl
    {
        private readonly ILoanRepository _loanRepo;
        public LoansCtrl(ILoanRepository loanRepo)
        {
            InitializeComponent();
            _loanRepo = loanRepo;
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await ReadLoans();
        }
        public async Task ReadLoans()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Borrowed Book");
            table.Columns.Add("Borrowed By");
            table.Columns.Add("From");
            table.Columns.Add("To");

            List<Loan> loans = await _loanRepo.GetAll();
            foreach (Loan loan in loans)
            {
                DataRow row = table.NewRow();
                row["ID"] = loan.Id;
                row["Borrowed Book"] = loan.BorrowedBook.Title;
                row["Borrowed By"] = $"{loan.BorrowedByUser?.FirstName} {loan.BorrowedByUser?.LastName}";
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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string? val = this.dgvLoans.SelectedRows[0].Cells[0].Value!.ToString();
            if (val == null || val.Length == 0) return;
            int id = int.Parse(val);
            Loan? loan = await _loanRepo.Get(id);
            if (loan == null) return;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this loan ?", "Delete Loan", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            await _loanRepo.Delete(loan);
            await _loanRepo.SaveChangesAsync();
            await ReadLoans();
        }
    }
}
