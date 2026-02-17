using LibraryApp.Entities;
using LibraryApp.Forms;
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
    public partial class UsersCtrl : UserControl
    {
        private readonly ILibraryUserRepository _userRep;
        private readonly IServiceProvider _serviceProvider;
        public UsersCtrl(ILibraryUserRepository userRep, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userRep = userRep;
            _serviceProvider = serviceProvider;
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await ReadUsers();
        }
        public async Task ReadUsers()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Username");
            table.Columns.Add("Name");
            table.Columns.Add("Date of Birth");

            List<LibraryUser> users = await _userRep.GetAll();
            foreach (LibraryUser user in users)
            {
                DataRow row = table.NewRow();
                row["ID"] = user.Id;
                row["UserName"] = user.UserName;
                row["Name"] = user.FirstName + " " + user.LastName;
                row["Date of Birth"] = user.DateOfBirth.ToString("yyyy-MM-dd");
                table.Rows.Add(row);
            }
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = table;
            if (dgvUsers.Columns["ID"] != null)
            {
                dgvUsers.Columns["ID"]!.Visible = false;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            CreateEditUserForm createForm = _serviceProvider.GetRequiredService<CreateEditUserForm>();
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                await ReadUsers();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            string? val = this.dgvUsers.SelectedRows[0].Cells[0].Value!.ToString();
            if (val == null || val.Length == 0) return;
            int id = int.Parse(val);
            LibraryUser? user = await _userRep.Get(id);
            if (user == null) return;
            CreateEditUserForm editForm = _serviceProvider.GetRequiredService<CreateEditUserForm>();
            editForm.EditUser(user);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await ReadUsers();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string? val = this.dgvUsers.SelectedRows[0].Cells[0].Value!.ToString();
            if (val == null || val.Length == 0) return;
            int id = int.Parse(val);
            LibraryUser? user = await _userRep.Get(id);
            if (user == null) return;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user ?", "Delete User", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            await _userRep.Delete(user);
            await _userRep.SaveChangesAsync();
            await ReadUsers();
        }
    }
}
