namespace LibraryApp.Forms
{
    partial class CreateEditUserForm
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
            lblTitleCreateEdit = new Label();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            lblPassword = new Label();
            label2 = new Label();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            btnSave = new LibraryApp.UI.PrimaryButton();
            btnCancel = new LibraryApp.UI.PrimaryButton();
            cbPassword = new CheckBox();
            mcDate = new MonthCalendar();
            tbDateOfBirth = new TextBox();
            btnDate = new LibraryApp.UI.DateButton();
            SuspendLayout();
            // 
            // lblTitleCreateEdit
            // 
            lblTitleCreateEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitleCreateEdit.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleCreateEdit.ForeColor = Color.FromArgb(52, 152, 219);
            lblTitleCreateEdit.Location = new Point(3, 65);
            lblTitleCreateEdit.Name = "lblTitleCreateEdit";
            lblTitleCreateEdit.Size = new Size(794, 68);
            lblTitleCreateEdit.TabIndex = 8;
            lblTitleCreateEdit.Text = "ADD USER";
            lblTitleCreateEdit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbPassword.ForeColor = Color.FromArgb(52, 152, 219);
            tbPassword.Location = new Point(260, 499);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(282, 38);
            tbPassword.TabIndex = 17;
            tbPassword.TextAlign = HorizontalAlignment.Center;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbUsername.ForeColor = Color.FromArgb(52, 152, 219);
            tbUsername.Location = new Point(260, 189);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(282, 38);
            tbUsername.TabIndex = 16;
            tbUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(236, 240, 241);
            lblPassword.Location = new Point(334, 467);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(140, 29);
            lblPassword.TabIndex = 15;
            lblPassword.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(236, 240, 241);
            label2.Location = new Point(333, 157);
            label2.Name = "label2";
            label2.Size = new Size(130, 29);
            label2.TabIndex = 14;
            label2.Text = "USERNAME";
            // 
            // tbLastName
            // 
            tbLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLastName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbLastName.ForeColor = Color.FromArgb(52, 152, 219);
            tbLastName.Location = new Point(260, 335);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(282, 38);
            tbLastName.TabIndex = 21;
            tbLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // tbFirstName
            // 
            tbFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFirstName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbFirstName.ForeColor = Color.FromArgb(52, 152, 219);
            tbFirstName.Location = new Point(260, 262);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(282, 38);
            tbFirstName.TabIndex = 20;
            tbFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(236, 240, 241);
            label1.Location = new Point(333, 303);
            label1.Name = "label1";
            label1.Size = new Size(130, 29);
            label1.TabIndex = 19;
            label1.Text = "LAST NAME";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(236, 240, 241);
            label3.Location = new Point(333, 230);
            label3.Name = "label3";
            label3.Size = new Size(141, 29);
            label3.TabIndex = 18;
            label3.Text = "FIRST NAME";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(236, 240, 241);
            label5.Location = new Point(311, 385);
            label5.Name = "label5";
            label5.Size = new Size(182, 29);
            label5.TabIndex = 22;
            label5.Text = "DATE OF BIRTH";
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
            btnSave.Location = new Point(260, 595);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 38);
            btnSave.TabIndex = 24;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            btnCancel.Location = new Point(421, 595);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 38);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cbPassword.ForeColor = Color.FromArgb(236, 240, 241);
            cbPassword.Location = new Point(328, 543);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(165, 29);
            cbPassword.TabIndex = 27;
            cbPassword.Text = "Show Password";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += CbPassword_CheckedChanged;
            // 
            // mcDate
            // 
            mcDate.Location = new Point(554, 335);
            mcDate.MaxSelectionCount = 1;
            mcDate.Name = "mcDate";
            mcDate.TabIndex = 28;
            mcDate.DateSelected += mcDate_DateSelected;
            // 
            // tbDateOfBirth
            // 
            tbDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDateOfBirth.BackColor = Color.FromArgb(236, 240, 241);
            tbDateOfBirth.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbDateOfBirth.ForeColor = Color.FromArgb(52, 152, 219);
            tbDateOfBirth.Location = new Point(260, 417);
            tbDateOfBirth.Name = "tbDateOfBirth";
            tbDateOfBirth.ReadOnly = true;
            tbDateOfBirth.Size = new Size(240, 38);
            tbDateOfBirth.TabIndex = 29;
            tbDateOfBirth.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDate
            // 
            btnDate.BackColor = Color.FromArgb(236, 240, 241);
            btnDate.FlatAppearance.BorderSize = 0;
            btnDate.FlatStyle = FlatStyle.Flat;
            btnDate.Font = new Font("Gill Sans Ultra Bold", 14F, FontStyle.Italic);
            btnDate.ForeColor = Color.FromArgb(52, 152, 219);
            btnDate.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            btnDate.IconColor = Color.FromArgb(52, 152, 219);
            btnDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDate.IconSize = 30;
            btnDate.Location = new Point(498, 417);
            btnDate.Name = "btnDate";
            btnDate.Size = new Size(44, 38);
            btnDate.TabIndex = 30;
            btnDate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDate.UseVisualStyleBackColor = false;
            btnDate.Click += btnDate_Click;
            // 
            // CreateEditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(800, 700);
            Controls.Add(btnDate);
            Controls.Add(tbDateOfBirth);
            Controls.Add(mcDate);
            Controls.Add(cbPassword);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lblPassword);
            Controls.Add(label2);
            Controls.Add(lblTitleCreateEdit);
            MaximumSize = new Size(800, 700);
            MinimumSize = new Size(800, 700);
            Name = "CreateEditUserForm";
            Text = "CreateEditUser";
            Controls.SetChildIndex(lblTitleCreateEdit, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(lblPassword, 0);
            Controls.SetChildIndex(tbUsername, 0);
            Controls.SetChildIndex(tbPassword, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(tbFirstName, 0);
            Controls.SetChildIndex(tbLastName, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(btnCancel, 0);
            Controls.SetChildIndex(cbPassword, 0);
            Controls.SetChildIndex(mcDate, 0);
            Controls.SetChildIndex(tbDateOfBirth, 0);
            Controls.SetChildIndex(btnDate, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleCreateEdit;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label lblPassword;
        private Label label2;
        private TextBox tbLastName;
        private TextBox tbFirstName;
        private Label label1;
        private Label label3;
        private Label label5;
        private UI.PrimaryButton btnSave;
        private UI.PrimaryButton btnCancel;
        private CheckBox cbPassword;
        private MonthCalendar mcDate;
        private TextBox tbDateOfBirth;
        private UI.DateButton btnDate;
    }
}