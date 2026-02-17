namespace LibraryApp.Forms
{
    partial class BaseForm
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
            btnMinimize = new LibraryApp.UI.BaseButton();
            btnMaximize = new LibraryApp.UI.BaseButton();
            btnClose = new LibraryApp.UI.BaseButton();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            iconPBLogo = new FontAwesome.Sharp.IconPictureBox();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPBLogo).BeginInit();
            SuspendLayout();
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(44, 62, 80);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 62, 80);
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 62, 80);
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnMinimize.ForeColor = Color.FromArgb(52, 152, 219);
            btnMinimize.Location = new Point(1032, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(35, 45);
            btnMinimize.TabIndex = 5;
            btnMinimize.Text = "🗕";
            btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(44, 62, 80);
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 62, 80);
            btnMaximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 62, 80);
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnMaximize.ForeColor = Color.FromArgb(52, 152, 219);
            btnMaximize.Location = new Point(1073, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(35, 45);
            btnMaximize.TabIndex = 4;
            btnMaximize.Text = "🗖";
            btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(44, 62, 80);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 62, 80);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 62, 80);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnClose.ForeColor = Color.FromArgb(52, 152, 219);
            btnClose.Location = new Point(1114, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 45);
            btnClose.TabIndex = 6;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(44, 62, 80);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(iconPBLogo);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1152, 62);
            panelTitleBar.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(52, 152, 219);
            lblTitle.Location = new Point(65, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 53);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "LIBRARY";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconPBLogo
            // 
            iconPBLogo.BackColor = Color.FromArgb(44, 62, 80);
            iconPBLogo.ForeColor = Color.FromArgb(52, 152, 219);
            iconPBLogo.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            iconPBLogo.IconColor = Color.FromArgb(52, 152, 219);
            iconPBLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPBLogo.IconSize = 53;
            iconPBLogo.Location = new Point(3, 3);
            iconPBLogo.Name = "iconPBLogo";
            iconPBLogo.Size = new Size(56, 53);
            iconPBLogo.TabIndex = 8;
            iconPBLogo.TabStop = false;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 692);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseForm";
            Text = "BaseForm";
            panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPBLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private UI.BaseButton btnMinimize;
        private UI.BaseButton btnMaximize;
        private UI.BaseButton btnClose;
        private Panel panelTitleBar;
        private Label lblTitle;
        private FontAwesome.Sharp.IconPictureBox iconPBLogo;
    }
}