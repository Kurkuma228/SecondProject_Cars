using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls
{
    partial class CircleButton : Button
    {
        private bool _isChecked = false;

        public CircleButton()
        {
            this.Size = new Size(30, 30); 
            this.FlatStyle = FlatStyle.Flat; 
            this.FlatAppearance.BorderSize = 0; 
            this.BackColor = Color.Gray; 
            this.UseVisualStyleBackColor = false; 
            this.Click += OnButtonClick;

            this.Region = CreateCircularRegion(this.ClientRectangle, 15); 
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            _isChecked = !_isChecked;
            this.Invalidate(); 
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            int diameter = Math.Min(this.Width, this.Height);
            int x = (this.Width - diameter) / 2;
            int y = (this.Height - diameter) / 2;

            using (Brush brush = new SolidBrush(_isChecked ? Color.LimeGreen : BackColor))
            {
                pevent.Graphics.FillEllipse(brush, x, y, diameter, diameter);
            }
        }

        public bool IsChecked => _isChecked;

        private Region CreateCircularRegion(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(bounds);
            return new Region(path);
        }
    }
}