namespace LibraryApp.Forms
{
    partial class LibraryAppForm
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
            panel1 = new Panel();
            btnLogout = new LibraryApp.UI.LogoutButton();
            btnLoans = new LibraryApp.UI.NavbarButton();
            btnUsers = new LibraryApp.UI.NavbarButton();
            btnReturns = new LibraryApp.UI.NavbarButton();
            btnBooks = new LibraryApp.UI.NavbarButton();
            btnProfil = new LibraryApp.UI.NavbarButton();
            lblCurrentUser = new Label();
            panelUserControls = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnLoans);
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(btnReturns);
            panel1.Controls.Add(btnBooks);
            panel1.Controls.Add(btnProfil);
            panel1.Controls.Add(lblCurrentUser);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 668);
            panel1.TabIndex = 8;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(44, 62, 80);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Gill Sans Ultra Bold", 14F, FontStyle.Italic);
            btnLogout.ForeColor = Color.FromArgb(236, 240, 241);
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnLogout.IconColor = Color.FromArgb(236, 240, 241);
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.Location = new Point(182, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(61, 61);
            btnLogout.TabIndex = 0;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnLoans
            // 
            btnLoans.BackColor = Color.FromArgb(44, 62, 80);
            btnLoans.FlatAppearance.BorderSize = 0;
            btnLoans.FlatStyle = FlatStyle.Flat;
            btnLoans.Font = new Font("Gill Sans Ultra Bold", 14F, FontStyle.Italic);
            btnLoans.ForeColor = Color.FromArgb(236, 240, 241);
            btnLoans.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            btnLoans.IconColor = Color.FromArgb(52, 152, 219);
            btnLoans.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLoans.Location = new Point(3, 467);
            btnLoans.Name = "btnLoans";
            btnLoans.Size = new Size(240, 92);
            btnLoans.TabIndex = 0;
            btnLoans.Text = "LOANS";
            btnLoans.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoans.UseVisualStyleBackColor = false;
            btnLoans.Click += btnLoans_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(44, 62, 80);
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Gill Sans Ultra Bold", 14F, FontStyle.Italic);
            btnUsers.ForeColor = Color.FromArgb(236, 240, 241);
            btnUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnUsers.IconColor = Color.FromArgb(52, 152, 219);
            btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsers.Location = new Point(3, 369);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(240, 92);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "USERS";
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnReturns
            // 
            btnReturns.BackColor = Color.FromArgb(44, 62, 80);
            btnReturns.FlatAppearance.BorderSize = 0;
            btnReturns.FlatStyle = FlatStyle.Flat;
            btnReturns.Font = new Font("Gill Sans Ultra Bold", 14F, FontStyle.Italic);
            btnReturns.ForeColor = Color.FromArgb(236, 240, 241);
            btnReturns.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            btnReturns.IconColor = Color.FromArgb(52, 152, 219);
            btnReturns.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnReturns.Location = new Point(3, 271);
            btnReturns.Name = "btnReturns";
            btnReturns.Size = new Size(240, 92);
            btnReturns.TabIndex = 0;
            btnReturns.Text = "MY LOANS";
            btnReturns.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReturns.UseVisualStyleBackColor = false;
            btnReturns.Click += btnReturns_Click;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.FromArgb(44, 62, 80);
            btnBooks.FlatAppearance.BorderSize = 0;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Gill Sans Ultra Bold", 14F, FontStyle.Italic);
            btnBooks.ForeColor = Color.FromArgb(236, 240, 241);
            btnBooks.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnBooks.IconColor = Color.FromArgb(52, 152, 219);
            btnBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBooks.Location = new Point(3, 183);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(240, 82);
            btnBooks.TabIndex = 0;
            btnBooks.Text = "BOOKS";
            btnBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.FromArgb(44, 62, 80);
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Gill Sans Ultra Bold", 14F, FontStyle.Italic);
            btnProfil.ForeColor = Color.FromArgb(236, 240, 241);
            btnProfil.IconChar = FontAwesome.Sharp.IconChar.User;
            btnProfil.IconColor = Color.FromArgb(52, 152, 219);
            btnProfil.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnProfil.Location = new Point(3, 85);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(240, 92);
            btnProfil.TabIndex = 0;
            btnProfil.Text = "PROFILE";
            btnProfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 238);
            lblCurrentUser.ForeColor = Color.FromArgb(236, 240, 241);
            lblCurrentUser.Location = new Point(3, 3);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(173, 61);
            lblCurrentUser.TabIndex = 9;
            lblCurrentUser.Text = "User1";
            lblCurrentUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelUserControls
            // 
            panelUserControls.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelUserControls.Location = new Point(252, 68);
            panelUserControls.Name = "panelUserControls";
            panelUserControls.Size = new Size(1077, 650);
            panelUserControls.TabIndex = 9;
            // 
            // LibraryAppForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1341, 730);
            Controls.Add(panelUserControls);
            Controls.Add(panel1);
            MinimumSize = new Size(1100, 600);
            Name = "LibraryAppForm";
            Text = "LibraryAppForm";
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panelUserControls, 0);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblCurrentUser;
        private Panel panelUserControls;
        private UI.NavbarButton btnProfil;
        private UI.NavbarButton btnBooks;
        private UI.NavbarButton btnReturns;
        private UI.NavbarButton btnUsers;
        private UI.NavbarButton btnLoans;
        private UI.LogoutButton btnLogout;
    }
}