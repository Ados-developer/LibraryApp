namespace LibraryApp.Forms
{
    partial class ChangePasswordForm
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
            tbOldPassword = new TextBox();
            tbConfirmNewPassword = new TextBox();
            tbNewPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSave = new LibraryApp.UI.PrimaryButton();
            btnCancel = new LibraryApp.UI.PrimaryButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(52, 152, 219);
            label1.Location = new Point(12, 153);
            label1.Name = "label1";
            label1.Size = new Size(776, 56);
            label1.TabIndex = 0;
            label1.Text = "change password";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbOldPassword
            // 
            tbOldPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbOldPassword.ForeColor = Color.FromArgb(52, 152, 219);
            tbOldPassword.Location = new Point(234, 297);
            tbOldPassword.Name = "tbOldPassword";
            tbOldPassword.Size = new Size(322, 38);
            tbOldPassword.TabIndex = 8;
            tbOldPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // tbConfirmNewPassword
            // 
            tbConfirmNewPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbConfirmNewPassword.ForeColor = Color.FromArgb(52, 152, 219);
            tbConfirmNewPassword.Location = new Point(234, 492);
            tbConfirmNewPassword.Name = "tbConfirmNewPassword";
            tbConfirmNewPassword.Size = new Size(322, 38);
            tbConfirmNewPassword.TabIndex = 9;
            tbConfirmNewPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbNewPassword.ForeColor = Color.FromArgb(52, 152, 219);
            tbNewPassword.Location = new Point(234, 395);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new Size(322, 38);
            tbNewPassword.TabIndex = 10;
            tbNewPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(236, 240, 241);
            label2.Location = new Point(12, 255);
            label2.Name = "label2";
            label2.Size = new Size(776, 39);
            label2.TabIndex = 11;
            label2.Text = "Old Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(236, 240, 241);
            label3.Location = new Point(12, 450);
            label3.Name = "label3";
            label3.Size = new Size(776, 39);
            label3.TabIndex = 12;
            label3.Text = "Confirm New Password";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(236, 240, 241);
            label4.Location = new Point(12, 353);
            label4.Name = "label4";
            label4.Size = new Size(776, 39);
            label4.TabIndex = 13;
            label4.Text = "New Password";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(52, 152, 219);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 240, 241);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 240, 241);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(236, 240, 241);
            btnSave.Location = new Point(234, 562);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 40);
            btnSave.TabIndex = 14;
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
            btnCancel.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(236, 240, 241);
            btnCancel.Location = new Point(420, 562);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(136, 40);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(800, 700);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbNewPassword);
            Controls.Add(tbConfirmNewPassword);
            Controls.Add(tbOldPassword);
            Controls.Add(label1);
            MaximumSize = new Size(800, 700);
            MinimumSize = new Size(800, 700);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(tbOldPassword, 0);
            Controls.SetChildIndex(tbConfirmNewPassword, 0);
            Controls.SetChildIndex(tbNewPassword, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(btnCancel, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbConfirmNewPassword;
        private TextBox tbOldPassword;
        private TextBox tbNewPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private UI.PrimaryButton btnSave;
        private UI.PrimaryButton btnCancel;
    }
}