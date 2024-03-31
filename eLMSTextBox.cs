using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class eLMSTextbox : TextBox
{
    private string placeholderText = string.Empty;
    private Color borderColor = Color.Gray;
    private int borderWidth = 2;
    private bool showBorder = true;
    private int borderRadius = 5;

    public eLMSTextbox()
    {
        BackColor = Color.White;
    }

    public string PlaceholderText
    {
        get { return placeholderText; }
        set
        {
            placeholderText = value;
            Invalidate();
        }
    }

    public Color BorderColor
    {
        get { return borderColor; }
        set
        {
            borderColor = value;
            Invalidate();
        }
    }

    public int BorderWidth
    {
        get { return borderWidth; }
        set
        {
            borderWidth = value;
            Invalidate();
        }
    }

    public bool ShowBorder
    {
        get { return showBorder; }
        set
        {
            showBorder = value;
            Invalidate();
        }
    }

    public int BorderRadius
    {
        get { return borderRadius; }
        set
        {
            borderRadius = value;
            Invalidate(); // Trigger repaint when radius changes
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Draw border if showBorder is true
        if (showBorder)
        {
            using (GraphicsPath borderPath = GetRoundRect(ClientRectangle, borderRadius))
            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawPath(borderPen, borderPath);
            }
        }

        // Draw placeholder text if TextBox is empty and not focused
        if (string.IsNullOrEmpty(Text) && !Focused)
        {
            using (Brush brush = new SolidBrush(ForeColor))
            {
                e.Graphics.DrawString(placeholderText, Font, brush, new PointF(2, 2));
            }
        }
    }

    private GraphicsPath GetRoundRect(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
        path.AddArc(rect.Right - (radius * 2), rect.Y, radius * 2, radius * 2, 270, 90);
        path.AddArc(rect.Right - (radius * 2), rect.Bottom - (radius * 2), radius * 2, radius * 2, 0, 90);
        path.AddArc(rect.X, rect.Bottom - (radius * 2), radius * 2, radius * 2, 90, 90);
        path.CloseFigure();
        return path;
    }

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        Invalidate();
    }

    protected override void OnGotFocus(EventArgs e)
    {
        base.OnGotFocus(e);
        Invalidate();
    }

    protected override void OnLostFocus(EventArgs e)
    {
        base.OnLostFocus(e);
        Invalidate();
    }
}
