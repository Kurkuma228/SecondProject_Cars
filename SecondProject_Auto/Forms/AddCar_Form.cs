using SecondProject_Auto.Enums;
using System;
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
        uint milage { get; set; }
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = name_txt.Text;

            autoType = autoType_txt.Text;

            price = decimal.Parse(price_txt.Text);

            color = color_txt.Text;

            milage = uint.Parse(mileage_txt.Text);

            fuelType = (FuelType)Enum.Parse(typeof(FuelType), fuelType_cmb.Text);

            switch(quality_cmb.Text)
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

            photoFilePath = photo_txt.Text;

            dateCreate = DateTime.Parse(yearCreate_dtp.Text);

            using (var context = new AutoContext())
            {
                var car = new Auto();

                car.Name = name;
                car.AutoType = autoType;
                car.Price = price;
                car.Color = color;
                car.Milage = milage;
                car.FuelType = fuelType;
                car.QualityType = quality;
                car.Engine = engine;
                car.HorsePower = horsePower;
                car.SeatingCapacity = seatingCapacity;
                car.Mfr = mfr;
                car.PhotoFilePath = photoFilePath;
                car.YearCreate = dateCreate;

                context.Autos.Add(car);
            }
        }
    }
}
