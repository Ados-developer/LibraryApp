namespace LibraryApp.Forms
{
    partial class CreateEditBookForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new LibraryApp.UI.PrimaryButton();
            btnSave = new LibraryApp.UI.PrimaryButton();
            tbTitle = new TextBox();
            label3 = new Label();
            tbAuthor = new TextBox();
            label2 = new Label();
            lblTitleCreateEdit = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(52, 152, 219);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 240, 241);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 240, 241);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(236, 240, 241);
            btnCancel.Location = new Point(408, 509);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 38);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(52, 152, 219);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 240, 241);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 240, 241);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(236, 240, 241);
            btnSave.Location = new Point(275, 509);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 38);
            btnSave.TabIndex = 38;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbTitle
            // 
            tbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbTitle.ForeColor = Color.FromArgb(52, 152, 219);
            tbTitle.Location = new Point(194, 415);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(426, 38);
            tbTitle.TabIndex = 35;
            tbTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(236, 240, 241);
            label3.Location = new Point(369, 383);
            label3.Name = "label3";
            label3.Size = new Size(74, 29);
            label3.TabIndex = 33;
            label3.Text = "Title";
            // 
            // tbAuthor
            // 
            tbAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbAuthor.ForeColor = Color.FromArgb(52, 152, 219);
            tbAuthor.Location = new Point(194, 299);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(426, 38);
            tbAuthor.TabIndex = 31;
            tbAuthor.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(236, 240, 241);
            label2.Location = new Point(352, 267);
            label2.Name = "label2";
            label2.Size = new Size(108, 29);
            label2.TabIndex = 29;
            label2.Text = "Author";
            // 
            // lblTitleCreateEdit
            // 
            lblTitleCreateEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitleCreateEdit.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleCreateEdit.ForeColor = Color.FromArgb(52, 152, 219);
            lblTitleCreateEdit.Location = new Point(12, 113);
            lblTitleCreateEdit.Name = "lblTitleCreateEdit";
            lblTitleCreateEdit.Size = new Size(776, 68);
            lblTitleCreateEdit.TabIndex = 28;
            lblTitleCreateEdit.Text = "ADD BOOK";
            lblTitleCreateEdit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateEditBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(800, 700);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbTitle);
            Controls.Add(label3);
            Controls.Add(tbAuthor);
            Controls.Add(label2);
            Controls.Add(lblTitleCreateEdit);
            MaximumSize = new Size(800, 700);
            MinimumSize = new Size(800, 700);
            Name = "CreateEditBookForm";
            Text = "CreateEditBookForm";
            Controls.SetChildIndex(lblTitleCreateEdit, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(tbAuthor, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(tbTitle, 0);
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(btnCancel, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private UI.PrimaryButton btnCancel;
        private UI.PrimaryButton btnSave;
        private TextBox tbTitle;
        private Label label3;
        private TextBox tbAuthor;
        private Label label2;
        private Label lblTitleCreateEdit;
    }
}