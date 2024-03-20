using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    public int CornerRadius { get; set; } = 20; // Adjust the radius for rounding

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        GraphicsPath path = new GraphicsPath();
        int radius = CornerRadius;
        Rectangle bounds = new Rectangle(0, 0, Width, Height);

        // Top-left arc
        path.AddArc(bounds.X, bounds.Y, radius * 2, radius * 2, 180, 90);

        // Top-right arc
        path.AddArc(bounds.Right - (radius * 2), bounds.Y, radius * 2, radius * 2, 270, 90);

        // Bottom-right arc
        path.AddArc(bounds.Right - (radius * 2), bounds.Bottom - (radius * 2), radius * 2, radius * 2, 0, 90);

        // Bottom-left arc
        path.AddArc(bounds.X, bounds.Bottom - (radius * 2), radius * 2, radius * 2, 90, 90);

        path.CloseFigure();
        this.Region = new Region(path);
    }
}
