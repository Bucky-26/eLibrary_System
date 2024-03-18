using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls
{
    public class TransparentLabel : Label
    {
        public TransparentLabel()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.Opaque, true);
            BackColor = Color.Transparent;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            base.OnPaint(e);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            const int WM_ERASEBKGND = 0x14;
            if (m.Msg == WM_ERASEBKGND)
            {
                using (var brush = new SolidBrush(Color.Transparent))
                {
                    var g = Graphics.FromHdc(m.WParam);
                    g.FillRectangle(brush, ClientRectangle);
                }
                m.Result = IntPtr.Zero;
            }
        }
    }
}
