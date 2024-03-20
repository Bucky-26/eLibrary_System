using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundButton : Button
{
    public RoundButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.BackColor = Color.White;
        this.ForeColor = Color.Black;
        this.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
        this.AutoSize = true;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        // Create a graphics path to define the button's shape
        GraphicsPath path = new GraphicsPath();
        int radius = 20; // Adjust the radius for rounding
        Rectangle bounds = this.ClientRectangle;
        bounds.Width--;
        bounds.Height--;

        // Add arcs to the path to create rounded corners
        path.AddArc(bounds.X, bounds.Y, radius * 2, radius * 2, 180, 90); // Top-left corner
        path.AddArc(bounds.Right - (radius * 2), bounds.Y, radius * 2, radius * 2, 270, 90); // Top-right corner
        path.AddArc(bounds.Right - (radius * 2), bounds.Bottom - (radius * 2), radius * 2, radius * 2, 0, 90); // Bottom-right corner
        path.AddArc(bounds.X, bounds.Bottom - (radius * 2), radius * 2, radius * 2, 90, 90); // Bottom-left corner

        // Close the path
        path.CloseFigure();

        // Set the button's region to the custom path
        this.Region = new Region(path);

        // Fill the button with the background color
        using (SolidBrush brush = new SolidBrush(this.BackColor))
        {
            pevent.Graphics.FillPath(brush, path);
        }

        // Draw the button's text in the center
        TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}
