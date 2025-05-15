using System;
using System.Drawing;
using System.Windows.Forms;

namespace SecondProject_Auto.Forms
{
    public partial class CarControl : UserControl
    {
        private Label labelName;
        private Label labelPrice;
        private Button buttonDescription;
        private PictureBox pictureBoxCar;

        public int Id { get; set; }
        public string Name
        {
            get => labelName.Text;
            set => labelName.Text = value;
        }

        public decimal Price
        {
            get => decimal.Parse(labelPrice.Text.Replace("₽", "").Trim());
            set => labelPrice.Text = $"₽{value:F0}";
        }

        public string ImageUrl { get; set; }
        public string Description { get; set; }

        // Событие для кнопки "Описание"
        public event EventHandler DescriptionButtonClick;

        public CarControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonDescription = new System.Windows.Forms.Button();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(5, 155);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(254, 25);
            this.labelName.TabIndex = 2;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelPrice.ForeColor = System.Drawing.Color.Green;
            this.labelPrice.Location = new System.Drawing.Point(5, 180);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(254, 20);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDescription
            // 
            this.buttonDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDescription.Location = new System.Drawing.Point(5, 201);
            this.buttonDescription.Name = "buttonDescription";
            this.buttonDescription.Size = new System.Drawing.Size(254, 30);
            this.buttonDescription.TabIndex = 0;
            this.buttonDescription.Text = "Описание";
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxCar.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(254, 150);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 3;
            this.pictureBoxCar.TabStop = false;
            // 
            // CarControl
            // 
            this.Controls.Add(this.buttonDescription);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxCar);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CarControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(264, 236);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);

        }

        private void DescriptionButton_Click(object sender, EventArgs e)
        {
            DescriptionButtonClick?.Invoke(this, e);
        }

        /// <summary>
        /// Установка данных машины
        /// </summary>
        public void SetData(int id, string name, decimal price, string imageUrl, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            ImageUrl = imageUrl;
            Description = description;

            try
            {
                if (!string.IsNullOrEmpty(imageUrl) && System.IO.File.Exists(imageUrl))
                {
                    pictureBoxCar.Image = Image.FromFile(imageUrl);
                }
                else
                {
                    pictureBoxCar.Image = Properties.Resources.placeholder; // Заглушка
                }
            }
            catch
            {
                pictureBoxCar.Image = Properties.Resources.placeholder; // При ошибке тоже заглушка
            }
        }
    }
}