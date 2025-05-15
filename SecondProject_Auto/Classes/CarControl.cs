using System;
using System.Drawing;
using System.Windows.Forms;

namespace SecondProject_Auto.Forms
{
    public partial class CarControl : UserControl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public CarControl()
        {
            PictureBox carImage = new PictureBox
            {
                Name = "carImage",
                Size = new Size(150, 100),
                Margin = new Padding(10),
                Dock = DockStyle.Top
            };

            Label nameLabel = new Label
            {
                Name = "nameLabel",
                Text = "Название автомобиля",
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(10)
            };

            Label priceLabel = new Label
            {
                Name = "priceLabel",
                Text = "Цена",
                Font = new Font("Arial", 8),
                AutoSize = true,
                Margin = new Padding(10)
            };

            Button descriptionButton = new Button
            {
                Name = "descriptionButton",
                Text = "Описание",
                Size = new Size(100, 30),
                Margin = new Padding(10)
            };

            descriptionButton.Click += DescriptionButton_Click;

            Controls.Add(carImage);
            Controls.Add(nameLabel);
            Controls.Add(priceLabel);
            Controls.Add(descriptionButton);
        }

        public void UpdateData(int id, string name, decimal price, string imageUrl, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            ImageUrl = imageUrl;
            Description = description;

            PictureBox carImage = Controls["carImage"] as PictureBox;
            Label nameLabel = Controls["nameLabel"] as Label;
            Label priceLabel = Controls["priceLabel"] as Label;

            carImage.Image = Image.FromFile(imageUrl); 
            nameLabel.Text = name;
            priceLabel.Text = $"Цена: {price:C}";
        }

        private void DescriptionButton_Click(object sender, EventArgs e)
        {
            CarDescription_Form descriptionForm = new CarDescription_Form
            {
                Text = Name
            };
            descriptionForm.ShowDialog();
        }
    }
}