namespace LibraryApp.UserControls
{
    partial class UsersCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            btnAdd = new LibraryApp.UI.ToolButton();
            btnEdit = new LibraryApp.UI.ToolButton();
            btnDelete = new LibraryApp.UI.ToolButton();
            dgvUsers = new LibraryApp.UI.BaseDataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Gill Sans Ultra Bold", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(919, 56);
            label1.TabIndex = 0;
            label1.Text = "USERS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(44, 62, 80);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            btnAdd.ForeColor = Color.FromArgb(236, 240, 241);
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnAdd.IconColor = Color.FromArgb(236, 240, 241);
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 40;
            btnAdd.Location = new Point(3, 88);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(148, 45);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Pridať";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(44, 62, 80);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            btnEdit.ForeColor = Color.FromArgb(236, 240, 241);
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnEdit.IconColor = Color.FromArgb(236, 240, 241);
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.IconSize = 40;
            btnEdit.Location = new Point(598, 88);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(148, 45);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Upraviť";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(44, 62, 80);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            btnDelete.ForeColor = Color.FromArgb(236, 240, 241);
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnDelete.IconColor = Color.FromArgb(236, 240, 241);
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 40;
            btnDelete.Location = new Point(752, 88);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 45);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Vymazať";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.FromArgb(236, 240, 241);
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle3.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle4.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle4;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.FromArgb(44, 62, 80);
            dgvUsers.Location = new Point(3, 139);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(919, 252);
            dgvUsers.TabIndex = 6;
            // 
            // UsersCtrl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvUsers);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "UsersCtrl";
            Size = new Size(925, 394);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private UI.ToolButton btnAdd;
        private UI.ToolButton btnEdit;
        private UI.ToolButton btnDelete;
        private UI.BaseDataGridView dgvUsers;
    }
}
