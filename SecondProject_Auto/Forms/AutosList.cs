using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondProject_Auto
{
    public partial class AutosListForm : Form
    {
        List<Auto> autos;
        public AutosListForm(List<Auto> autos)
        {
            InitializeComponent();
            this.autos = autos;
            LoadAutos();
        }
        private void LoadAutos()
        {
            foreach (var auto in autos)
            {
                // Создаем панель для одного автомобиля
                Panel autoPanel = new Panel
                {
                    Width = 300,
                    Height = 200,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                // PictureBox для изображения
                PictureBox pictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Height = 100,
                    //Image = Image.FromFile(auto.PhotoFilePath) // Загрузка изображения
                };

                // Label для названия и описания
                Label nameLabel = new Label
                {
                    Text = auto.Name,
                    Dock = DockStyle.Top,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label descriptionLabel = new Label
                {
                    Text = $"{auto.AutoType} (${auto.Price})",
                    Dock = DockStyle.Top,
                    Font = new Font("Arial", 10),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Button для деталей
                Button detailsButton = new Button
                {
                    Text = "View Details",
                    Dock = DockStyle.Top,
                    Height = 30
                };
                detailsButton.Click += (s, e) => ShowDetails(auto);

                // Добавляем элементы на панель
                autoPanel.Controls.Add(detailsButton);
                autoPanel.Controls.Add(descriptionLabel);
                autoPanel.Controls.Add(nameLabel);
                autoPanel.Controls.Add(pictureBox);

                // Добавляем панель в FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(autoPanel);
            }
        }
        private void ShowDetails(Auto auto)
        {
            MessageBox.Show($"Details for {auto.Name}:\n{auto.AutoType}\nPrice: ${auto.Price}", "Car Details");
        }

    }
}
