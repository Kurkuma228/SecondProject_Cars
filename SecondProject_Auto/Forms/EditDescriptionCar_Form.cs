using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using SecondProject_Auto.Enums;
using System.Diagnostics;
using System.Runtime.Remoting.Lifetime;
using System.Xml.Linq;

namespace SecondProject_Auto.Forms
{
    public partial class EditDescriptionCar_Form : Form
    {
        private string photoFilePath;
        public Auto car;
        private string name;
        private string autoType;
        private decimal price;
        private string color;
        private float mileage;
        private FuelType fuelType;
        private QualityType quality;
        private string engine;
        private int horsePower;
        private byte seatingCapacity;
        private string mfr;
        private DateTime dateCreate;
        public EditDescriptionCar_Form(Auto car)
        {
            InitializeComponent();

            photoFilePath = car.PhotoFilePath;
            this.car = car;

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

        private void photo_btn_Click(object sender, EventArgs e)
        {
            try
            { 
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.webp)|*.jpg;*.jpeg;*.png;*.webp|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(photoFilePath))
                    {
                        File.Delete(photoFilePath);
                        Console.WriteLine("Файл успешно удален.");
                    }
                    else
                    {
                        Console.WriteLine("Файл не найден.");
                    }

                    photoFilePath = @"..\..\Resources\" + openFileDialog.SafeFileName;
                    File.Copy(openFileDialog.FileName, photoFilePath);

                    car_pbx.Image = Image.FromFile(photoFilePath);
                    car_pbx.Update();

                    car.PhotoFilePath = photoFilePath;
                    MessageBox.Show("Фотография изменена!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
