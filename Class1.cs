using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing; // Added this line

namespace eLibrary_System
{
    class round : PictureBox
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
