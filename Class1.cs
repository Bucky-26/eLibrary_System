using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace eLibrary_System
{
    public class round : PictureBox // Changed accessibility to public
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath _path = new GraphicsPath();
            _path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(_path);
            base.OnPaint(pe);
        }
    }
}
