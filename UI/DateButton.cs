using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.UI
{
    public class DateButton : IconButton
    {
        private Color _bgNormal = Color.FromArgb(236, 240, 241);
        private Color _iconNormal = Color.FromArgb(52, 152, 219);
        private Color _fgNormal = Color.FromArgb(52, 152, 219);

        private Color _bgHover = Color.FromArgb(236, 240, 241);
        private Color _iconHover = Color.FromArgb(44, 62, 80);
        private Color _fgHover = Color.FromArgb(44, 62, 80);

        public DateButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            BackColor = _bgNormal;
            ForeColor = _fgNormal;
            IconColor = _iconNormal;
            IconSize = 30;
            TextImageRelation = TextImageRelation.ImageBeforeText;

            Font = new Font("Gill Sans Ultra Bold", 14F, FontStyle.Italic);
            Cursor = Cursors.Hand;

            // Enable double buffering for smooth hover
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.UserPaint, true);
        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = _bgHover;
            ForeColor = _fgHover;
            IconColor = _iconHover; // farba ikonky
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = _bgNormal;
            ForeColor = _fgNormal;
            IconColor = _iconNormal;
        }
    }
}
