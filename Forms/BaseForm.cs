using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public partial class BaseForm : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        public BaseForm()
        {
            InitializeComponent();
            // DRAG
            EnableWindowDrag(panelTitleBar);
            EnableWindowDrag(iconPBLogo);
            EnableWindowDrag(lblTitle);

            // BUTTONS
            btnMinimize.Click += (s, e) => WindowState = FormWindowState.Minimized;
            btnMaximize.Click += (s, e) =>
            {
                WindowState = WindowState == FormWindowState.Maximized
                    ? FormWindowState.Normal
                    : FormWindowState.Maximized;
            };
            btnClose.Click += (s, e) => Close();
        }
        private void EnableWindowDrag(Control control)
        {
            control.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }
            };
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            const int resizeArea = 10; // šírka resize zóny

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

                if ((int)m.Result == 0x1) // HTCLIENT
                {
                    Point screenPoint = new Point(m.LParam.ToInt32());
                    Point clientPoint = PointToClient(screenPoint);

                    if (clientPoint.X <= resizeArea && clientPoint.Y <= resizeArea)
                        m.Result = (IntPtr)HTTOPLEFT;
                    else if (clientPoint.X >= Width - resizeArea && clientPoint.Y <= resizeArea)
                        m.Result = (IntPtr)HTTOPRIGHT;
                    else if (clientPoint.X <= resizeArea && clientPoint.Y >= Height - resizeArea)
                        m.Result = (IntPtr)HTBOTTOMLEFT;
                    else if (clientPoint.X >= Width - resizeArea && clientPoint.Y >= Height - resizeArea)
                        m.Result = (IntPtr)HTBOTTOMRIGHT;
                    else if (clientPoint.Y <= resizeArea)
                        m.Result = (IntPtr)HTTOP;
                    else if (clientPoint.Y >= Height - resizeArea)
                        m.Result = (IntPtr)HTBOTTOM;
                    else if (clientPoint.X <= resizeArea)
                        m.Result = (IntPtr)HTLEFT;
                    else if (clientPoint.X >= Width - resizeArea)
                        m.Result = (IntPtr)HTRIGHT;
                }
                return;
            }

            base.WndProc(ref m);
        }
    }
}
