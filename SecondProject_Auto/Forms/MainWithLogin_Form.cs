using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace SecondProject_Auto.Forms
{
    public partial class MainWithLogin_Form : Form
    {
        private List<CarControl> allCarControls = new List<CarControl>();
        private List<Auto> allCars = new List<Auto>();
        private Auto selectedCar;
        private bool isFiltering = false;

        public MainWithLogin_Form()
        {
            InitializeComponent();

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings["UserId"].Value == "2")
            {
                addCar_btn.Visible = true;
            }

            using (var context = new AutoContext())
            {
                allCars = context.Autos.ToList();

                foreach (var car in allCars)
                {
                    CarControl carControl = new CarControl(car);
                    carControl.Name = car.Name;
                    carControl.Id = car.Id;
                    carControl.Price = car.Price;
                    carControl.ImageUrl = car.PhotoFilePath;

                    carControl.buttonOff(); 

                    flowLayoutPanel1.Controls.Add(carControl);
                    allCarControls.Add(carControl);
                }

                foreach (var car in allCars)
                {
                    CarControl carControl = new CarControl(car);
                    carControl.CarSelected += OnCarSelected; 
                    carControl.Name = car.Name;
                    carControl.Id = car.Id;
                    carControl.Price = car.Price;
                    carControl.ImageUrl = car.PhotoFilePath;
                    flowLayoutPanel2.Controls.Add(carControl);
                }
            }
        }

        private void OnCarSelected(object sender, CarEventArgs e)
        {
            if (isFiltering) return;

            var carControl = (CarControl)sender;
            var candidateCar = e.SelectedCar;

            if (candidateCar == null) return;

            isFiltering = true;

            if (selectedCar == null || selectedCar.Id != candidateCar.Id)
            {
                selectedCar = candidateCar;
                FilterSimilarCars();
            }
            else
            {
                selectedCar = null;
                ShowAllCars();
            }

            isFiltering = false;
        }

        private void FilterSimilarCars()
        {
            if (selectedCar == null) return;

            var similarCars = GetSimilarCars(selectedCar, allCars);

            if (!similarCars.Any(c => c.Id == selectedCar.Id))
            {
                similarCars.Insert(0, selectedCar);
            }

            foreach (var control in allCarControls)
            {
                control.Visible = similarCars.Any(c => c.Id == control.Car.Id);
            }

            flowLayoutPanel1.ResumeLayout();
            flowLayoutPanel1.Invalidate();
        }

        private void ShowAllCars()
        {
            foreach (var control in allCarControls)
            {
                control.Visible = true;
            }

            flowLayoutPanel1.ResumeLayout();
            flowLayoutPanel1.Invalidate();
        }

        public static int CalculateMatchScore(Auto target, Auto candidate)
        {
            int score = 0;

            if (!string.IsNullOrWhiteSpace(candidate.AutoType) &&
                !string.IsNullOrWhiteSpace(target.AutoType) &&
                candidate.AutoType.Trim().ToLower() == target.AutoType.Trim().ToLower())
            {
                score += 3;
            }

            if (candidate.QualityType == target.QualityType) score += 2;
            if (candidate.FuelType == target.FuelType) score += 2;

            if (Math.Abs(candidate.Price - target.Price) <= target.Price * 0.15m)
                score += 2;

            if (Math.Abs(candidate.HorsePower - target.HorsePower) <= 20)
                score += 1;

            if (!string.IsNullOrWhiteSpace(candidate.Mfr) &&
                candidate.Mfr.Trim().ToLower() == target.Mfr.Trim().ToLower())
            {
                score += 1;
            }

            return score;
        }

        public List<Auto> GetSimilarCars(Auto targetCar, List<Auto> allCars, int topN = 3)
        {
            var scoredCars = allCars
                .Select(car => new
                {
                    Auto = car,
                    Score = CalculateMatchScore(targetCar, car)
                })
                .OrderByDescending(x => x.Score)
                .ToList();

            return scoredCars
                .Where(x => x.Score > 0)
                .Take(topN)
                .Select(x => x.Auto)
                .ToList();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            var form = new Profile_Form();
            Visible = false;
            form.ShowDialog();
            form.UserDeleted += OnUserDeleted;
            Visible = true;
        }

        public void exit_btn_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["IsLoggedIn"].Value = "false";
            config.AppSettings.Settings["UserId"].Value = null;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            var form = new Start_Form();

            ApplicationContext context = (ApplicationContext)Application.OpenForms[0].Tag;
            context.MainForm = form;
            form.Tag = context;

            form.Show();
            Close();
        }

        private void OnUserDeleted(object sender, EventArgs e)
        {
            var form = new Start_Form();

            ApplicationContext context = (ApplicationContext)Application.OpenForms[0].Tag;
            context.MainForm = form;
            form.Tag = context;

            form.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new AddCar_Form())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadCars();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

            form_btn.ForeColor = System.Drawing.Color.FromArgb(100, 106, 232);
            form_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);

            favorite_btn.ForeColor = System.Drawing.Color.FromArgb(100, 106, 232);
            favorite_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);

            main_btn.ForeColor = System.Drawing.Color.Black;
            main_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

            main_btn.ForeColor = System.Drawing.Color.FromArgb(100, 106, 232);
            main_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);

            favorite_btn.ForeColor = System.Drawing.Color.FromArgb(100, 106, 232);
            favorite_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);

            form_btn.ForeColor = System.Drawing.Color.Black;
            form_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;

            form_btn.ForeColor = System.Drawing.Color.FromArgb(100, 106, 232);
            form_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);

            main_btn.ForeColor = System.Drawing.Color.FromArgb(100, 106, 232);
            main_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);

            favorite_btn.ForeColor = System.Drawing.Color.Black;
            favorite_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
        }

        private void LoadCars()
        {
            flowLayoutPanel1.Controls.Clear();
            allCarControls.Clear();

            using (var context = new AutoContext())
            {
                allCars = context.Autos.ToList();

                foreach (var car in allCars)
                {
                    CarControl carControl = new CarControl(car);
                    carControl.Name = car.Name;
                    carControl.Id = car.Id;
                    carControl.Price = car.Price;
                    carControl.ImageUrl = car.PhotoFilePath;

                    carControl.buttonOff(); 

                    flowLayoutPanel1.Controls.Add(carControl);
                    allCarControls.Add(carControl);
                }
            }
        }
    }
}