using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondProject_Auto.Drawings
{
    public class CustomDetailButton : Button
    {
    public CustomDetailButton()
        {
            // Настройки по умолчанию
            this.FlatStyle = FlatStyle.Flat; // Плоский стиль без стандартных границ
            this.FlatAppearance.BorderSize = 0; // Убираем границы
            this.BackColor = Color.White; // Цвет фона
            this.ForeColor = Color.FromArgb(64, 64, 64); // Цвет текста
            this.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular); // Шрифт
            this.Size = new Size(150, 30); // Размер кнопки
            this.Text = "View Details"; // Текст кнопки
            this.TextAlign = ContentAlignment.MiddleCenter; // Выравнивание текста
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;

            // Рисуем фон кнопки
            using (Brush brush = new SolidBrush(this.BackColor))
            {
                g.FillRectangle(brush, ClientRectangle);
            }

            // Рисуем текст
            TextRenderer.DrawText(g, this.Text, this.Font, ClientRectangle,
                this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            // Рисуем нижнюю подчеркивающую линию
            using (Pen pen = new Pen(Color.FromArgb(128, 128, 128), 1)) // Серая линия
            {
                g.DrawLine(pen, 0, this.Height - 1, this.Width, this.Height - 1);
            }

            using (Pen borderPen = new Pen(Color.RoyalBlue, 1)) // Синяя линия
            {
                g.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }

            base.OnPaint(pe);
        }
    }
}

