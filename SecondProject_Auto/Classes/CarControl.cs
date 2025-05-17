using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace SecondProject_Auto.Forms
{
    public partial class CarControl : UserControl
    {
        private Label name_lbl;
        private Label price_lbl;
        private Button description_btn;
        private PictureBox car_pbx;
        private CustomControls.CircleButton circleButton1;

        public event EventHandler CarEdited;

        public event EventHandler<CarEventArgs> CarSelected;

        public Auto Car { get; private set; }

        public int Id { get; set; }
        public string Name
        {
            get => name_lbl.Text;
            set => name_lbl.Text = value;
        }

        public decimal Price
        {
            get => decimal.Parse(price_lbl.Text.Trim());
            set => price_lbl.Text = $"От {value:F0} ₽";
        }
        private string _imageUrl;
        public string ImageUrl
        {
            get => _imageUrl; 
            set
            {
                if (value != null)
                {
                    try
                    {
                        string absolutePath = Path.GetFullPath(value);
                        car_pbx.Image = Image.FromFile(absolutePath);

                        _imageUrl = value;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public string Description { get; set; }

        public event EventHandler DescriptionButtonClick;

        public CarControl(Auto car)
        {
            InitializeComponent();
            Car = car;
        }

        private void OnSelectButtonClick(object sender, EventArgs e)
        {
            CarSelected?.Invoke(this, new CarEventArgs(Car));
        }

        private void InitializeComponent()
        {
            this.name_lbl = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.description_btn = new System.Windows.Forms.Button();
            this.circleButton1 = new CustomControls.CircleButton();
            this.car_pbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.car_pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.BackColor = System.Drawing.Color.White;
            this.name_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.name_lbl.ForeColor = System.Drawing.Color.Black;
            this.name_lbl.Location = new System.Drawing.Point(5, 174);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(254, 25);
            this.name_lbl.TabIndex = 1;
            this.name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // price_lbl
            // 
            this.price_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.price_lbl.ForeColor = System.Drawing.Color.Gray;
            this.price_lbl.Location = new System.Drawing.Point(5, 199);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(254, 20);
            this.price_lbl.TabIndex = 2;
            this.price_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // description_btn
            // 
            this.description_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.description_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(106)))), ((int)(((byte)(232)))));
            this.description_btn.FlatAppearance.BorderSize = 2;
            this.description_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.description_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.description_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.description_btn.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(106)))), ((int)(((byte)(232)))));
            this.description_btn.Location = new System.Drawing.Point(5, 219);
            this.description_btn.Name = "description_btn";
            this.description_btn.Size = new System.Drawing.Size(254, 30);
            this.description_btn.TabIndex = 3;
            this.description_btn.Text = "Описание";
            this.description_btn.UseVisualStyleBackColor = false;
            this.description_btn.Click += new System.EventHandler(this.description_btn_Click);
            // 
            // circleButton1
            // 
            this.circleButton1.BackColor = System.Drawing.SystemColors.Control;
            this.circleButton1.FlatAppearance.BorderSize = 0;
            this.circleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton1.Location = new System.Drawing.Point(226, 183);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(30, 30);
            this.circleButton1.TabIndex = 4;
            this.circleButton1.Text = "circleButton1";
            this.circleButton1.UseVisualStyleBackColor = false;
            this.circleButton1.Click += new System.EventHandler(OnSelectButtonClick);
            // 
            // car_pbx
            // 
            this.car_pbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.car_pbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.car_pbx.Location = new System.Drawing.Point(5, 5);
            this.car_pbx.Name = "car_pbx";
            this.car_pbx.Size = new System.Drawing.Size(254, 166);
            this.car_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car_pbx.TabIndex = 0;
            this.car_pbx.TabStop = false;
            // 
            // CarControl
            // 
            this.Controls.Add(this.circleButton1);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.description_btn);
            this.Controls.Add(this.car_pbx);
            this.Margin = new System.Windows.Forms.Padding(23);
            this.Name = "CarControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(264, 254);
            ((System.ComponentModel.ISupportInitialize)(this.car_pbx)).EndInit();
            this.ResumeLayout(false);

        }

        private void description_btn_Click(object sender, EventArgs e)
        {
            using(var form = new CarDescription_Form(Car))
            {
                form.ShowDialog();
                Car = form.car;
            }
        }
        public void buttonOff()
        {
            circleButton1.Visible = false;
        }
    }

    public class CarEventArgs : EventArgs
    {
        public Auto SelectedCar { get; private set; }

        public CarEventArgs(Auto selectedCar)
        {
            SelectedCar = selectedCar;
        }
    }
}