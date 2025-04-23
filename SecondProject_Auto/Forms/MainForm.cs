using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecondProject_Auto;
using SecondProject_Auto.Forms;

namespace SecondProject_Auto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            using (AutoContext db = new AutoContext())
            {
                var autos = db.Autos.ToList();
            }
            using (UserContext db2 = new UserContext())
            {
                var users = db2.Users.ToList(); 
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
