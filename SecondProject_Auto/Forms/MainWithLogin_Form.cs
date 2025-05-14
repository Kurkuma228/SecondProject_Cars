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
        public List<Auto> Autos { get; set; }
        public MainWithLogin_Form()
        {
            InitializeComponent();
        }

        private List<Auto> autos = new List<Auto>
        {
            new Auto
            {
                Name = "Tesla Model S",
                PhotoFilePath = "tesla.jpg",
                AutoType = "Electric luxury sedan.",
                Price = 89990m
            },
            new Auto
            {
                Name = "BMW M3",
                PhotoFilePath = "bmw.jpg",
                AutoType = "High-performance sports car.",
                Price = 72800m
            },
            new Auto
            {
                Name = "Ford F-150",
                PhotoFilePath = "ford.jpg",
                AutoType = "Durable and powerful pickup truck.",
                Price = 34550m
            },
            new Auto
            {
                Name = "Audi Q5",
                PhotoFilePath = "audi.jpg",
                AutoType = "Compact luxury SUV.",
                Price = 43500m
            }
        };

        private void profile_btn_Click(object sender, EventArgs e)
        {
            var form = new Login_Form();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["IsLoggedIn"].Value = "false";
            config.AppSettings.Settings["UserId"].Value = null;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            var form = new Main_Form();

            ApplicationContext context = (ApplicationContext)Application.OpenForms[0].Tag;
            context.MainForm = form;

            form.Show();
            Close();
        }
    }
}
