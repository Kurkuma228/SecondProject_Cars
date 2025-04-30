using SecondProject_Auto.Drawings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondProject_Auto.Forms
{
    public partial class MainWithLogin_Form : Form
    {
        public List<Auto> Autos { get; set; }
        public MainWithLogin_Form()
        {
            InitializeComponent();
            LoadAutos();

            #region UserElements
            //Button

            CircularButton circularButton = new CircularButton
            {
                Location = new Point(890, 12),
                Text = "Profile",
                //BackgroundImage = Image.FromFile(@"..\..\Resources\Profile.png")
            };

            circularButton.Click += CircularButton_Click;

            Controls.Add(circularButton);
            circularButton.BringToFront();
            

            #endregion
        }

        private void CircularButton_Click(object sender, EventArgs e)
        {
            var form = new Profile_Form();
            form.ShowDialog();
        }

        private List<Auto> autos = new List<Auto>
        {
            new Auto
            {
                Name = "Tesla Model S",
                PhotoFilePath = "tesla.jpg",
                AutoType = "Electric luxury sedan.",
                Price = 89990m
            },
            new Auto
            {
                Name = "BMW M3",
                PhotoFilePath = "bmw.jpg",
                AutoType = "High-performance sports car.",
                Price = 72800m
            },
            new Auto
            {
                Name = "Ford F-150",
                PhotoFilePath = "ford.jpg",
                AutoType = "Durable and powerful pickup truck.",
                Price = 34550m
            },
            new Auto
            {
                Name = "Audi Q5",
                PhotoFilePath = "audi.jpg",
                AutoType = "Compact luxury SUV.",
                Price = 43500m
            }
        };

        private void profile_btn_Click(object sender, EventArgs e)
        {
            var form = new Login_Form();
            form.ShowDialog();
        }

        private void LoadAutos()
        {
            foreach (var auto in autos)
            {
                Panel autoPanel = new Panel
                {
                    Width = 300,
                    Height = 200,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                PictureBox pictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Height = 100,

                };

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

                CustomDetailButton customDetailsButton = new CustomDetailButton
                {
                    //Text = "View Details",
                    Dock = DockStyle.Top,
                    //Height = 30
                };
                customDetailsButton.Click += (s, e) => ShowDetails(auto);

                autoPanel.Controls.Add(customDetailsButton);
                autoPanel.Controls.Add(descriptionLabel);
                autoPanel.Controls.Add(nameLabel);
                autoPanel.Controls.Add(pictureBox);

                flowLayoutPanel1.Controls.Add(autoPanel);
            }
        }
        private void ShowDetails(Auto auto)
        {
            MessageBox.Show($"Details for {auto.Name}:\n{auto.AutoType}\nPrice: ${auto.Price}", "Car Details");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddCar_Form();
            form.ShowDialog();
        }
    }
}
