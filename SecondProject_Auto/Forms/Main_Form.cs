using System;
using System.Linq;
using System.Windows.Forms;
using SecondProject_Auto.Forms;

namespace SecondProject_Auto
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            LoadData();
            label2.Parent = car_pbox;
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
        private void start_btn_Click(object sender, EventArgs e)
        {
            if (Login_Form.IsLoggedIn)
            {
                var form = new MainWithLogin_Form();

                ApplicationContext context = (ApplicationContext)Application.OpenForms[0].Tag;
                context.MainForm = form;
                form.Tag = context;
                form.Show();
                Close();
            }
            else
            {
                var logform = new Login_Form();
                Visible = false;
                logform.ShowDialog();
                if(Login_Form.IsLoggedIn)
                {
                    var form = new MainWithLogin_Form();

                    ApplicationContext context = (ApplicationContext)Application.OpenForms[0].Tag;
                    context.MainForm = form;
                    form.Tag = context;
                    form.Show();
                    Close();
                }
                if (!Login_Form.IsLoggedIn)
                {
                    Visible = true;
                }
            }
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            var form = new Login_Form();
            form.ShowDialog();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            var form = new Registration_Form();
            form.ShowDialog();
        }
    }
 }
