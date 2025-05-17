using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace SecondProject_Auto.Forms
{
    public partial class MainWithLogin_Form : Form
    {
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
                var cars = context.Autos.ToList();
                foreach (var car in cars)
                {
                    CarControl carControl = new CarControl(car);
                    carControl.Name = car.Name;
                    carControl.Id = car.Id;
                    carControl.Price = car.Price;
                    carControl.ImageUrl = car.PhotoFilePath;
                    flowLayoutPanel1.Controls.Add(carControl);
                }
            }
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            var form = new Profile_Form();
            Visible = false;
            form.ShowDialog();
            form.UserDeleted += OnUserDeleted;
            Visible = true;
        }

        private void exit_btn_Click(object sender, EventArgs e)
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
            using(var form = new AddCar_Form())
            {
                form.ShowDialog();
                Update();
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
    }
}
