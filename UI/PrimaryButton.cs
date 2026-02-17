using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.UI
{
    public class PrimaryButton : Button
    {
        private Color _bgNormal = Color.FromArgb(52, 152, 219);
        private Color _fgNormal = Color.FromArgb(236, 240, 241);

        private Color _bgHover = Color.FromArgb(236, 240, 241);
        private Color _fgHover = Color.FromArgb(52, 152, 219);

        public PrimaryButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = _bgHover;
            FlatAppearance.MouseOverBackColor = _bgHover;

            BackColor = _bgNormal;
            ForeColor = _fgNormal;

            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Cursor = Cursors.Hand;

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.UserPaint, true);
        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = _bgHover;
            ForeColor = _fgHover;
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = _bgNormal;
            ForeColor = _fgNormal;
        }
    }
}
