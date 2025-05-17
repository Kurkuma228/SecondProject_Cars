using System;
using System.Configuration;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace SecondProject_Auto
{
    public partial class Profile_Form : Form
    {
        public event EventHandler UserDeleted;
        public Profile_Form()
        {
            InitializeComponent();
            using(var context = new UserContext())
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var user = context.Users.Find(Int32.Parse(config.AppSettings.Settings["UserId"].Value));
                loginName_txtb.Text = user.Name;
                loginEmail_txtb.Text = user.Email;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            using (var context = new UserContext())
            {
                try
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var user = context.Users.Find(Int32.Parse(config.AppSettings.Settings["UserId"].Value));

                    user.Name = loginName_txtb.Text;
                    user.Email = loginEmail_txtb.Text;
                    user.Password = loginPassword_txtb.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                loginPassword_txtb.UseSystemPasswordChar = false;
                loginSecPassword_txtb.UseSystemPasswordChar = false;
            }
            else
            {
                loginPassword_txtb.UseSystemPasswordChar = true;
                loginSecPassword_txtb.UseSystemPasswordChar = true;
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            using (var context = new UserContext())
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var user = context.Users.Find(Int32.Parse(config.AppSettings.Settings["UserId"].Value));
                context.Users.Remove(user);
            }
            UserDeleted?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void loginName_txtb_Enter(object sender, EventArgs e)
        {
            name_lbl.Visible = false;
        }

        private void loginName_txtb_Leave(object sender, EventArgs e)
        {
            if (loginName_txtb.Text == "")
            {
                name_lbl.Visible = true;
            }
        }

        private void loginEmail_txtb_Enter(object sender, EventArgs e)
        {
            email_lbl.Visible = false;
        }

        private void loginEmail_txtb_Leave(object sender, EventArgs e)
        {
            if (loginEmail_txtb.Text == "")
            {
                email_lbl.Visible = true;
            }
        }

        private void loginPassword_txtb_Enter(object sender, EventArgs e)
        {
            password_lbl.Visible = false;
        }

        private void loginPassword_txtb_Leave(object sender, EventArgs e)
        {
            if (loginPassword_txtb.Text == "")
            {
                password_lbl.Visible = true;
            }
        }

        private void loginSecPassword_txtb_Enter(object sender, EventArgs e)
        {
            passwordSec_lbl.Visible = false;
        }

        private void loginSecPassword_txtb_Leave(object sender, EventArgs e)
        {
            if (loginSecPassword_txtb.Text == "")
            {
                passwordSec_lbl.Visible = true;
            }
        } 3
    }
}
