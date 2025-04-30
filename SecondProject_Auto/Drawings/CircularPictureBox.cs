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
    class CircularPictureBox : PictureBox
    {
        public CircularPictureBox()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Width - 1, Height - 1);

            Region = new Region(path);

            using (Pen pen = new Pen(Color.Black, 3))
            {
                pe.Graphics.DrawEllipse(pen, 0, 0, Width - 1, Height - 1);
            }

            pe.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            pe.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pe.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            pe.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            base.OnPaint(pe);
        }
    }
}
