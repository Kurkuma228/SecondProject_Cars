using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                button1.Visible = true;
            }
                using (var context = new AutoContext())
            {
                var cars = context.Autos.ToList();
                foreach (var car in cars)
                {
                    CarControl carControl = new CarControl();
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
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["IsLoggedIn"].Value = "false";
            config.AppSettings.Settings["UserId"].Value = null;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            var form = new Main_Form();

            ApplicationContext context = (ApplicationContext)Application.OpenForms[0].Tag;
            context.MainForm = form;
            form.Tag = context;

            form.Show();
            Close();
        }
        private void OnUserDeleted(object sender, EventArgs e)
        {
            var form = new Main_Form();

            ApplicationContext context = (ApplicationContext)Application.OpenForms[0].Tag;
            context.MainForm = form;
            form.Tag = context;

            form.Show();
            Close();
        }
    }
}
