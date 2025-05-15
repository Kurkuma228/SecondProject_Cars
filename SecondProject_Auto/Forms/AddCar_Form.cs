using SecondProject_Auto.Enums;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SecondProject_Auto.Forms
{
    public partial class AddCar_Form : Form
    {
        string name { get; set; }
        string autoType { get; set; }
        DateTime dateCreate { get; set; }
        decimal price { get; set; }
        string color { get; set; }
        uint mileage { get; set; }
        QualityType quality { get; set; }
        FuelType fuelType { get; set; }
        string engine { get; set; }
        uint horsePower { get; set; }
        byte seatingCapacity { get; set; }
        string mfr { get; set; }
        string photoFilePath { get; set; }


        public AddCar_Form()
        {
            InitializeComponent();

            for (int year = DateTime.Now.Year;year >= 1900;  year--)
            {
                yearCreate_cmb.Items.Add(year);
            }
            yearCreate_cmb.SelectedItem = DateTime.Now.Year;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                name = name_txt.Text;

                autoType = autoType_txt.Text;

                price = decimal.Parse(price_txt.Text);

                color = color_txt.Text;

                mileage = uint.Parse(mileage_txt.Text);

                fuelType = (FuelType)Enum.Parse(typeof(FuelType), fuelType_cmb.Text);

                switch (quality_cmb.Text)
                {
                    case "Б/У":
                        quality = QualityType.Б_У;
                        break;
                    case "Новая":
                        quality = QualityType.Новая;
                        break;
                }

                engine = engine_txt.Text;

                horsePower = uint.Parse(horsepower_txt.Text);

                seatingCapacity = byte.Parse(seat_txt.Text);

                mfr = mfr_txt.Text;

                dateCreate = new DateTime(int.Parse(yearCreate_cmb.Text), 1, 1);

                using (var context = new AutoContext())
                {
                    var car = new Auto();

                    car.Name = name;
                    car.AutoType = autoType;
                    car.Price = price;
                    car.Color = color;
                    car.Mileage = mileage;
                    car.FuelType = fuelType;
                    car.QualityType = quality;
                    car.Engine = engine;
                    car.HorsePower = horsePower;
                    car.SeatingCapacity = seatingCapacity;
                    car.Mfr = mfr;
                    car.PhotoFilePath = photoFilePath;
                    car.YearCreate = dateCreate;

                    context.Autos.Add(car);
                    context.SaveChanges();
                }
                MessageBox.Show("Машина успешно добавлена!");
            //}
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Ошибка при добавлении автомобиля:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                photoFilePath = $@"..\..\Resources\{openFileDialog.SafeFileName}";
                File.Copy(openFileDialog.FileName, photoFilePath);

                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Update();
            }
        }
    }
}
