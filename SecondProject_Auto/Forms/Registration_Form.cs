using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SecondProject_Auto.Forms
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }
        private void register_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string loginName = loginName_txtb.Text;
                string loginEmail = loginEmail_txtb.Text;
                string loginPassword = loginPassword_txtb.Text;
                string loginSecPassword = loginSecPassword_txtb.Text;

                if (string.IsNullOrWhiteSpace(loginName))
                {
                    MessageBox.Show("Введите имя.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(loginEmail))
                {
                    MessageBox.Show("Введите почту.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(loginPassword))
                {
                    MessageBox.Show("Введите пароль.");
                    return;
                }

                if(string.IsNullOrWhiteSpace(loginSecPassword))
                {
                    MessageBox.Show("Повторите пароль");
                    return;
                }
                if (loginPassword == loginSecPassword)
                {
                    using (var context = new UserContext())
                    {
                        var user = new User
                        {
                            Name = loginName,
                            Email = loginEmail,
                            Password = HashPassword(loginPassword)
                        };

                        context.Users.Add(user);
                        context.SaveChanges();
                    }
                }
                MessageBox.Show("Вы успешно зарегистрированы");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        private void loginName_txtb_Enter(object sender, EventArgs e)
        {
            name_lbl.Visible = false;
        }

        private void loginName_txtb_Leave(object sender, EventArgs e)
        {
            if(loginName_txtb.Text == "")
            {
               name_lbl.Visible = true;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
