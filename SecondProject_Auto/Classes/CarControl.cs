using System;
using System.Drawing;
using System.Windows.Forms;

namespace SecondProject_Auto.Forms
{
    public partial class CarControl : UserControl
    {
        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;

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

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CarControl
            // 
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CarControl";
            this.Size = new System.Drawing.Size(207, 188);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}