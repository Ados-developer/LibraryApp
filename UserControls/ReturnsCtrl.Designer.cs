namespace LibraryApp.UserControls
{
    partial class ReturnsCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnsCtrl));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvLoans = new LibraryApp.UI.BaseDataGridView();
            btnReturn = new LibraryApp.UI.ToolButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).BeginInit();
            SuspendLayout();
            // 
            // dgvLoans
            // 
            dgvLoans.AllowUserToAddRows = false;
            dgvLoans.AllowUserToDeleteRows = false;
            resources.ApplyResources(dgvLoans, "dgvLoans");
            dgvLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoans.BackgroundColor = Color.FromArgb(236, 240, 241);
            dgvLoans.BorderStyle = BorderStyle.None;
            dgvLoans.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle3.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle4.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvLoans.DefaultCellStyle = dataGridViewCellStyle4;
            dgvLoans.EnableHeadersVisualStyles = false;
            dgvLoans.GridColor = Color.FromArgb(44, 62, 80);
            dgvLoans.MultiSelect = false;
            dgvLoans.Name = "dgvLoans";
            dgvLoans.ReadOnly = true;
            dgvLoans.RowHeadersVisible = false;
            dgvLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(44, 62, 80);
            btnReturn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnReturn, "btnReturn");
            btnReturn.ForeColor = Color.FromArgb(236, 240, 241);
            btnReturn.IconChar = FontAwesome.Sharp.IconChar.Backward;
            btnReturn.IconColor = Color.FromArgb(236, 240, 241);
            btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReturn.IconSize = 40;
            btnReturn.Name = "btnReturn";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Name = "label1";
            // 
            // ReturnsCtrl
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnReturn);
            Controls.Add(dgvLoans);
            Name = "ReturnsCtrl";
            ((System.ComponentModel.ISupportInitialize)dgvLoans).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private UI.BaseDataGridView dgvLoans;
        private UI.ToolButton btnReturn;
        private Label label1;
    }
}
