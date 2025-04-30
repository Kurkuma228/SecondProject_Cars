using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondProject_Auto.Drawings
{
    public class CircularButton : Button
    {
        public CircularButton()
        {
            FlatStyle = FlatStyle.Flat; 
            FlatAppearance.BorderSize = 0; 
            BackColor = Color.FromArgb(100, 106, 232);
            ForeColor = Color.White; 
            Size = new Size(50, 50); 
            TextAlign = ContentAlignment.MiddleCenter; 
            BackgroundImage = null;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Width - 1, Height - 1);

            Region = new Region(path);

            using (Brush brush = new SolidBrush(BackColor))
            {
                pevent.Graphics.FillEllipse(brush, 0, 0, Width - 1, Height - 1);
            }

            TextRenderer.DrawText(pevent.Graphics, Text, Font,
                new Rectangle(0, 0, Width, Height),
                ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            base.OnPaint(pevent);
        }

    }
}