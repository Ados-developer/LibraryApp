namespace LibraryApp.Forms
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            cbPassword = new CheckBox();
            btnLogin = new LibraryApp.UI.PrimaryButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(52, 152, 219);
            label1.Location = new Point(0, 127);
            label1.Name = "label1";
            label1.Size = new Size(801, 71);
            label1.TabIndex = 8;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(236, 240, 241);
            label2.Location = new Point(334, 214);
            label2.Name = "label2";
            label2.Size = new Size(130, 29);
            label2.TabIndex = 9;
            label2.Text = "USERNAME";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(236, 240, 241);
            label4.Location = new Point(324, 321);
            label4.Name = "label4";
            label4.Size = new Size(140, 29);
            label4.TabIndex = 11;
            label4.Text = "PASSWORD";
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbUsername.ForeColor = Color.FromArgb(52, 152, 219);
            tbUsername.Location = new Point(261, 264);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(282, 38);
            tbUsername.TabIndex = 12;
            tbUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbPassword.ForeColor = Color.FromArgb(52, 152, 219);
            tbPassword.Location = new Point(261, 370);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(282, 38);
            tbPassword.TabIndex = 13;
            tbPassword.TextAlign = HorizontalAlignment.Center;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cbPassword.ForeColor = Color.FromArgb(236, 240, 241);
            cbPassword.Location = new Point(311, 414);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(165, 29);
            cbPassword.TabIndex = 14;
            cbPassword.Text = "Show Password";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += CbPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(52, 152, 219);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 240, 241);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 240, 241);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(236, 240, 241);
            btnLogin.Location = new Point(324, 463);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 39);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(800, 700);
            Controls.Add(btnLogin);
            Controls.Add(cbPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(800, 700);
            MinimumSize = new Size(800, 700);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(tbUsername, 0);
            Controls.SetChildIndex(tbPassword, 0);
            Controls.SetChildIndex(cbPassword, 0);
            Controls.SetChildIndex(btnLogin, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private CheckBox cbPassword;
        private UI.PrimaryButton btnLogin;
    }
}