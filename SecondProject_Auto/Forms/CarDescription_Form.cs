using System.IO;
using System;
using System.Windows.Forms;
using System.Configuration;

namespace SecondProject_Auto.Forms
{
    public partial class CarDescription_Form : Form
    {
        public Auto car;
        public CarDescription_Form(Auto car)
        {
            InitializeComponent();

            edit_btn.Visible = false;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings["UserId"].Value == "3")
            {
                edit_btn.Visible = true;
            }

            this.car = car;

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

        private void edit_btn_Click(object sender, EventArgs e)
        {
            using(var form = new EditDescriptionCar_Form(car))
            {
                form.ShowDialog();
                car = form.car;
            }
        }
    }
}
