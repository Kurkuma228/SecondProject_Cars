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
        string fuelType { get; set; }
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

            fuelType = typeGas_txt.Text;

            engine = engine_txt.Text;

            horsePower = uint.Parse(horsepower_txt.Text);

            seatingCapacity = byte.Parse(seat_txt.Text);

            mfr = mfr_txt.Text;

            photoFilePath = photo_txt.Text;

            using (var context = new AutoContext())
            {
                var car = new Auto();

                car.Name = name;
                car.AutoType = autoType;
                car.Price = price;
                car.Color = color;
                car.Milage = milage;
                car.FuelType = 
                context.Autos.Add(car);
            }
        }
    }
}
