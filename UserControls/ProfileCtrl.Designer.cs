namespace LibraryApp.UserControls
{
    partial class ProfileCtrl
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
            label1 = new Label();
            lblDateOfBirth = new Label();
            label3 = new Label();
            label4 = new Label();
            lblFirstName = new Label();
            label6 = new Label();
            lblLastName = new Label();
            label8 = new Label();
            lblUsername = new Label();
            btnEdit = new LibraryApp.UI.ToolButton();
            btnChangePassword = new LibraryApp.UI.ToolButton();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(1147, 79);
            label1.TabIndex = 2;
            label1.Text = "My profile";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Anchor = AnchorStyles.Top;
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 238);
            lblDateOfBirth.ForeColor = Color.FromArgb(52, 152, 219);
            lblDateOfBirth.Location = new Point(763, 230);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(152, 25);
            lblDateOfBirth.TabIndex = 1;
            lblDateOfBirth.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(602, 120);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(602, 157);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 4;
            label4.Text = "First Name";
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.Top;
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 238);
            lblFirstName.ForeColor = Color.FromArgb(52, 152, 219);
            lblFirstName.Location = new Point(763, 157);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(121, 25);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "FirstName";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.FromArgb(44, 62, 80);
            label6.Location = new Point(602, 195);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 6;
            label6.Text = "Last Name";
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Top;
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 238);
            lblLastName.ForeColor = Color.FromArgb(52, 152, 219);
            lblLastName.Location = new Point(763, 195);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(115, 25);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "LastName";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label8.ForeColor = Color.FromArgb(44, 62, 80);
            label8.Location = new Point(602, 230);
            label8.Name = "label8";
            label8.Size = new Size(155, 25);
            label8.TabIndex = 8;
            label8.Text = "Date Of Birth";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 238);
            lblUsername.ForeColor = Color.FromArgb(52, 152, 219);
            lblUsername.Location = new Point(763, 120);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(118, 25);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username";
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top;
            btnEdit.BackColor = Color.FromArgb(44, 62, 80);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            btnEdit.ForeColor = Color.FromArgb(236, 240, 241);
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEdit.IconColor = Color.FromArgb(236, 240, 241);
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.IconSize = 40;
            btnEdit.Location = new Point(613, 267);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(265, 32);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit Profile";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.Top;
            btnChangePassword.BackColor = Color.FromArgb(44, 62, 80);
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            btnChangePassword.ForeColor = Color.FromArgb(236, 240, 241);
            btnChangePassword.IconChar = FontAwesome.Sharp.IconChar.None;
            btnChangePassword.IconColor = Color.FromArgb(236, 240, 241);
            btnChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChangePassword.IconSize = 40;
            btnChangePassword.Location = new Point(613, 305);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(265, 32);
            btnChangePassword.TabIndex = 10;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnChangePassword);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblDateOfBirth);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1153, 753);
            panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top;
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = Color.FromArgb(44, 62, 80);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconPictureBox1.IconColor = Color.FromArgb(44, 62, 80);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox1.IconSize = 312;
            iconPictureBox1.Location = new Point(239, 94);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(357, 312);
            iconPictureBox1.TabIndex = 11;
            iconPictureBox1.TabStop = false;
            // 
            // ProfileCtrl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panel1);
            Name = "ProfileCtrl";
            Size = new Size(1153, 753);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblDateOfBirth;
        private Label label3;
        private Label label4;
        private Label lblFirstName;
        private Label label6;
        private Label lblLastName;
        private Label label8;
        private Label lblUsername;
        private UI.ToolButton btnEdit;
        private UI.ToolButton btnChangePassword;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
