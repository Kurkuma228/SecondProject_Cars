using System.IO;
using System;
using System.Windows.Forms;

namespace SecondProject_Auto.Forms
{
    public partial class CarDescription_Form : Form
    {
        public CarDescription_Form(Auto car)
        {
            InitializeComponent();

            nameCar_lbl.Text = car.Name;
            price_lbl.Text = car.Price.ToString();
            stateEdit_lbl.Text = car.QualityType.ToString();
            milageEdit_lbl.Text = car.Mileage.ToString();
            colorEdit_lbl.Text = car.Color.ToString();
            seatingCapacityEdit_lbl.Text = car.SeatingCapacity.ToString();
            typeCarEdit_lbl.Text = car.AutoType;
            engineEdit_lbl.Text = car.Engine;
            horsePowerEdit_lbl.Text = car.HorsePower.ToString();
            fuelTypeEdit_lbl.Text = car.FuelType.ToString();
            mfrEdit_lbl.Text = car.Mfr;

            string photoPath = car.PhotoFilePath;
            if (photoPath != null)
            {
                try
                {
                    car_pbx.Load(photoPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
