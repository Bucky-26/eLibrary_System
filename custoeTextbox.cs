using System.Drawing;
using System.Windows.Forms;

namespace CustomControls
{
    public class ColoredBorderTextBox : TextBox
    {
        private Color _borderColor = Color.FromArgb(46, 204, 113); // #2ecc71

        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                if (_borderColor != value)
                {
                    _borderColor = value;
                    Invalidate(); // Redraw the control when border color changes
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw custom border
            using (Pen borderPen = new Pen(BorderColor, 2))
            {
                e.Graphics.DrawRectangle(borderPen, new Rectangle(0, 0, Width - 1, Height - 1));
            }
        }
    }
}
