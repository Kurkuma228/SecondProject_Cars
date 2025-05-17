using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SecondProject_Auto.Forms
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        public void register_btn_Click(object sender, EventArgs e)
        {
            string loginName = loginName_txtb.Text.Trim();
            string loginEmail = loginEmail_txtb.Text.Trim();
            string loginPassword = loginPassword_txtb.Text.Trim();
            string loginSecPassword = loginSecPassword_txtb.Text.Trim();

            if (string.IsNullOrWhiteSpace(loginName))
            {
                MessageBox.Show("Введите имя.");
                return;
            }

            if (loginName.Length < 2)
            {
                MessageBox.Show("Имя должно содержать минимум 2 символа.");
                return;
            }

            if (string.IsNullOrWhiteSpace(loginEmail))
            {
                MessageBox.Show("Введите почту.");
                return;
            }

            if (!IsValidEmail(loginEmail))
            {
                MessageBox.Show("Некорректный формат email.");
                return;
            }

            if (string.IsNullOrWhiteSpace(loginPassword))
            {
                MessageBox.Show("Введите пароль.");
                return;
            }

            if (loginPassword.Length < 6)
            {
                MessageBox.Show("Пароль должен содержать минимум 6 символов.");
                return;
            }

            if (string.IsNullOrWhiteSpace(loginSecPassword))
            {
                MessageBox.Show("Повторите пароль.");
                return;
            }

            if (loginPassword != loginSecPassword)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            string hashedPassword = HashPassword(loginPassword);

            try
            {
                using (var context = new UserContext())
                {
                    var existingUser = context.Users.FirstOrDefault(u => u.Name == loginName || u.Email == loginEmail);
                    if (existingUser != null)
                    {
                        MessageBox.Show("Пользователь с таким именем или email уже существует.");
                        return;
                    }

                    var user = new User
                    {
                        Name = loginName,
                        Email = loginEmail,
                        Password = hashedPassword
                    };

                    context.Users.Add(user);
                    context.SaveChanges();
                }

                MessageBox.Show("Вы успешно зарегистрированы!");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

        private string HashPassword(string password)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        #region Placeholder Handling

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

        private void loginSecPassword_txtb_Enter(object sender, EventArgs e)
        {
            secPassword_lbl.Visible = false;
        }

        private void loginSecPassword_txtb_Leave(object sender, EventArgs e)
        {
            if (loginSecPassword_txtb.Text == "")
            {
                secPassword_lbl.Visible = true;
            }
        }

        #endregion

        private void login_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}