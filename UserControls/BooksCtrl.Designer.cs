namespace LibraryApp.UserControls
{
    partial class BooksCtrl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvBooks = new LibraryApp.UI.BaseDataGridView();
            label1 = new Label();
            btnAdd = new LibraryApp.UI.ToolButton();
            btnEdit = new LibraryApp.UI.ToolButton();
            btnDelete = new LibraryApp.UI.ToolButton();
            label2 = new Label();
            tbAuthorFilter = new TextBox();
            tbTitleFilter = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnBorrow = new LibraryApp.UI.ToolButton();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.FromArgb(236, 240, 241);
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle2.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.GridColor = Color.FromArgb(44, 62, 80);
            dgvBooks.Location = new Point(3, 258);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(1071, 389);
            dgvBooks.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(3, 140);
            label1.Name = "label1";
            label1.Size = new Size(1071, 54);
            label1.TabIndex = 1;
            label1.Text = "BOOKS";
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
            btnAdd.Location = new Point(171, 207);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 45);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
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
            btnEdit.Location = new Point(750, 207);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(148, 45);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
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
            btnDelete.Location = new Point(904, 207);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 45);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Snap ITC", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(1071, 32);
            label2.TabIndex = 7;
            label2.Text = "FILTER";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbAuthorFilter
            // 
            tbAuthorFilter.Anchor = AnchorStyles.None;
            tbAuthorFilter.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbAuthorFilter.ForeColor = Color.FromArgb(52, 152, 219);
            tbAuthorFilter.Location = new Point(117, 70);
            tbAuthorFilter.Name = "tbAuthorFilter";
            tbAuthorFilter.Size = new Size(368, 38);
            tbAuthorFilter.TabIndex = 8;
            tbAuthorFilter.TextAlign = HorizontalAlignment.Center;
            tbAuthorFilter.TextChanged += tbAuthorFilter_TextChanged;
            // 
            // tbTitleFilter
            // 
            tbTitleFilter.Anchor = AnchorStyles.None;
            tbTitleFilter.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbTitleFilter.ForeColor = Color.FromArgb(52, 152, 219);
            tbTitleFilter.Location = new Point(606, 70);
            tbTitleFilter.Name = "tbTitleFilter";
            tbTitleFilter.Size = new Size(365, 38);
            tbTitleFilter.TabIndex = 9;
            tbTitleFilter.TextAlign = HorizontalAlignment.Center;
            tbTitleFilter.TextChanged += tbTitleFilter_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Snap ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(120, 42);
            label3.Name = "label3";
            label3.Size = new Size(365, 25);
            label3.TabIndex = 10;
            label3.Text = "Author";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Snap ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(606, 42);
            label4.Name = "label4";
            label4.Size = new Size(365, 25);
            label4.TabIndex = 11;
            label4.Text = "Title";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.FromArgb(44, 62, 80);
            btnBorrow.FlatAppearance.BorderSize = 0;
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            btnBorrow.ForeColor = Color.FromArgb(236, 240, 241);
            btnBorrow.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnBorrow.IconColor = Color.FromArgb(236, 240, 241);
            btnBorrow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrow.IconSize = 40;
            btnBorrow.Location = new Point(3, 207);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(162, 45);
            btnBorrow.TabIndex = 14;
            btnBorrow.Text = "Borrow";
            btnBorrow.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbTitleFilter);
            panel1.Controls.Add(tbAuthorFilter);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 120);
            panel1.TabIndex = 15;
            // 
            // BooksCtrl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnBorrow);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(dgvBooks);
            Name = "BooksCtrl";
            Size = new Size(1077, 650);
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UI.BaseDataGridView dgvBooks;
        private Label label1;
        private UI.ToolButton btnAdd;
        private UI.ToolButton btnEdit;
        private UI.ToolButton btnDelete;
        private Label label2;
        private TextBox tbAuthorFilter;
        private TextBox tbTitleFilter;
        private Label label3;
        private Label label4;
        private UI.ToolButton btnBorrow;
        private Panel panel1;
    }
}
