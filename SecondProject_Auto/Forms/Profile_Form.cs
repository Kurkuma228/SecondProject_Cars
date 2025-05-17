using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SecondProject_Auto
{
    public partial class Profile_Form : Form
    {
        public event EventHandler UserDeleted;

        public Profile_Form()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                using (var context = new UserContext())
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    string userIdValue = config.AppSettings.Settings["UserId"]?.Value;

                    if (!int.TryParse(userIdValue, out int userId))
                    {
                        MessageBox.Show("Ошибка: пользователь не определён.");
                        Close();
                        return;
                    }

                    var user = context.Users.Find(userId);

                    if (user == null)
                    {
                        MessageBox.Show("Пользователь не найден.");
                        Close();
                        return;
                    }

                    loginName_txtb.Text = user.Name;
                    loginEmail_txtb.Text = user.Email;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
                Close();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string name = loginName_txtb.Text.Trim();
            string email = loginEmail_txtb.Text.Trim();
            string password = loginPassword_txtb.Text.Trim();
            string confirmPassword = loginSecPassword_txtb.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Имя не может быть пустым.");
                return;
            }

            if (name.Length < 2)
            {
                MessageBox.Show("Имя должно содержать минимум 2 символа.");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email не может быть пустым.");
                return;
            }

            if (email.Length < 5 || !email.Contains("@"))
            {
                MessageBox.Show("Введите корректный email.");
                return;
            }

            string hashedPassword = null;

            if (!string.IsNullOrEmpty(password))
            {
                if (password.Length < 6)
                {
                    MessageBox.Show("Пароль должен содержать минимум 6 символов.");
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Пароли не совпадают.");
                    return;
                }

                hashedPassword = HashPassword(password);
            }

            try
            {
                using (var context = new UserContext())
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    string userIdValue = config.AppSettings.Settings["UserId"]?.Value;

                    if (!int.TryParse(userIdValue, out int userId))
                    {
                        MessageBox.Show("Ошибка: пользователь не определён.");
                        return;
                    }

                    var user = context.Users.Find(userId);

                    if (user == null)
                    {
                        MessageBox.Show("Пользователь не найден.");
                        return;
                    }

                    user.Name = name;
                    user.Email = email;

                    if (!string.IsNullOrEmpty(password))
                    {
                        user.Password = hashedPassword;
                    }

                    context.SaveChanges();
                    MessageBox.Show("Данные успешно обновлены.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool showPassword = !checkBox1.Checked;
            loginPassword_txtb.UseSystemPasswordChar = !showPassword;
            loginSecPassword_txtb.UseSystemPasswordChar = !showPassword;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить аккаунт?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var context = new UserContext())
                    {
                        Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        string userIdValue = _config.AppSettings.Settings["UserId"]?.Value;

                        if (!int.TryParse(userIdValue, out int userId))
                        {
                            MessageBox.Show("Ошибка: пользователь не определён.");
                            return;
                        }

                        var user = context.Users.Find(userId);

                        if (user != null)
                        {
                            context.Users.Remove(user);
                            context.SaveChanges();
                        }
                    }

                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["IsLoggedIn"].Value = "false";
                    config.AppSettings.Settings["UserId"].Value = string.Empty;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");

                    UserDeleted?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("Аккаунт удален.");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении аккаунта: {ex.Message}");
                }
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
        }

        #endregion
    }
}