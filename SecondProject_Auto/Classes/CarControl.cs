using System;
using System.Drawing;
using System.Windows.Forms;

namespace SecondProject_Auto.Forms
{
    public partial class CarControl : UserControl
    {
        private Label name_lbl;
        private Label price_lbl;
        private Button description_btn;
        private PictureBox car_pbx;

        public int Id { get; set; }
        public string Name
        {
            get => name_lbl.Text;
            set => name_lbl.Text = value;
        }

        public decimal Price
        {
            get => decimal.Parse(price_lbl.Text.Replace("₽", "").Trim());
            set => price_lbl.Text = $"₽{value:F0}";
        }

        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public event EventHandler DescriptionButtonClick;

        public CarControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.name_lbl = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.description_btn = new System.Windows.Forms.Button();
            this.car_pbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.car_pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.name_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.name_lbl.Location = new System.Drawing.Point(5, 155);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(254, 25);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price_lbl
            // 
            this.price_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.price_lbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.price_lbl.ForeColor = System.Drawing.Color.Green;
            this.price_lbl.Location = new System.Drawing.Point(5, 180);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(254, 20);
            this.price_lbl.TabIndex = 1;
            this.price_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // description_btn
            // 
            this.description_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.description_btn.Location = new System.Drawing.Point(5, 201);
            this.description_btn.Name = "description_btn";
            this.description_btn.Size = new System.Drawing.Size(254, 30);
            this.description_btn.TabIndex = 0;
            this.description_btn.Text = "Описание";
            this.description_btn.Click += new System.EventHandler(this.description_btn_Click);
            // 
            // car_pbx
            // 
            this.car_pbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.car_pbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.car_pbx.Location = new System.Drawing.Point(5, 5);
            this.car_pbx.Name = "car_pbx";
            this.car_pbx.Size = new System.Drawing.Size(254, 150);
            this.car_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car_pbx.TabIndex = 3;
            this.car_pbx.TabStop = false;
            // 
            // CarControl
            // 
            this.Controls.Add(this.description_btn);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.car_pbx);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CarControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(264, 236);
            ((System.ComponentModel.ISupportInitialize)(this.car_pbx)).EndInit();
            this.ResumeLayout(false);

        }

        private void description_btn_Click(object sender, EventArgs e)
        {
            using(var form = new CarDescription_Form())
            {
                form.ShowDialog();
            }
        }
    }
}