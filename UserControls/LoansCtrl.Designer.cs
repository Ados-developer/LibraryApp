namespace LibraryApp.UserControls
{
    partial class LoansCtrl
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
            label1 = new Label();
            dgvLoans = new LibraryApp.UI.BaseDataGridView();
            btnDelete = new LibraryApp.UI.ToolButton();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(1071, 61);
            label1.TabIndex = 2;
            label1.Text = "LOANS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvLoans
            // 
            dgvLoans.AllowUserToAddRows = false;
            dgvLoans.AllowUserToDeleteRows = false;
            dgvLoans.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoans.BackgroundColor = Color.FromArgb(236, 240, 241);
            dgvLoans.BorderStyle = BorderStyle.None;
            dgvLoans.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle2.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLoans.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLoans.EnableHeadersVisualStyles = false;
            dgvLoans.GridColor = Color.FromArgb(44, 62, 80);
            dgvLoans.Location = new Point(3, 136);
            dgvLoans.MultiSelect = false;
            dgvLoans.Name = "dgvLoans";
            dgvLoans.ReadOnly = true;
            dgvLoans.RowHeadersVisible = false;
            dgvLoans.RowHeadersWidth = 51;
            dgvLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoans.Size = new Size(1071, 511);
            dgvLoans.TabIndex = 3;
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
            btnDelete.Location = new Point(904, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 45);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Vymazať";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // LoansCtrl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(dgvLoans);
            Controls.Add(label1);
            Name = "LoansCtrl";
            Size = new Size(1077, 650);
            ((System.ComponentModel.ISupportInitialize)dgvLoans).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private UI.BaseDataGridView dgvLoans;
        private UI.ToolButton btnDelete;
    }
}
