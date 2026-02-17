using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace LibraryApp.UI
{
    public class BaseDataGridView : DataGridView
    {
        private Color _lightBlue = Color.FromArgb(52, 152, 219);
        private Color _darkBlue = Color.FromArgb(44, 62, 80);
        private Color _white = Color.FromArgb(236, 240, 241);
        public BaseDataGridView()
        {
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MultiSelect = false;
            ReadOnly = true;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            RowHeadersVisible = false;

            EnableHeadersVisualStyles = false;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ColumnHeadersHeight = 40;
            ColumnHeadersDefaultCellStyle.BackColor = _darkBlue;
            ColumnHeadersDefaultCellStyle.ForeColor = _white;
            ColumnHeadersDefaultCellStyle.SelectionBackColor = ColumnHeadersDefaultCellStyle.BackColor;
            ColumnHeadersDefaultCellStyle.SelectionForeColor = ColumnHeadersDefaultCellStyle.ForeColor;
            ColumnHeadersDefaultCellStyle.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;


            DefaultCellStyle.BackColor = _white;
            DefaultCellStyle.ForeColor = _lightBlue;
            DefaultCellStyle.SelectionBackColor = _lightBlue;
            DefaultCellStyle.SelectionForeColor = _white;
            DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DefaultCellStyle.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic);


            GridColor = _darkBlue;
            BackgroundColor = _white;
            BorderStyle = BorderStyle.None;
        }
    }
}
