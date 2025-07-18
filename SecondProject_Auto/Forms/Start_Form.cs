﻿using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using SecondProject_Auto.Forms;

namespace SecondProject_Auto
{
    public partial class Start_Form : Form
    {
        public Start_Form()
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
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (bool.Parse(config.AppSettings.Settings["IsLoggedIn"].Value))
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
                else
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

        public void register_btn_Click(object sender, EventArgs e)
        {
            var form = new Registration_Form();
            form.ShowDialog();
        }
    }
 }
