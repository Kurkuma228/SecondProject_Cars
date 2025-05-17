using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SecondProject_Auto.Forms
{
    public partial class Login_Form : Form
    {
        static public bool IsLoggedIn { get; private set; } = false;

        public Login_Form()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string nameOrEmail = loginNameEmail_txtb.Text.Trim();
            string password = loginPassword_txtb.Text.Trim();

            if (string.IsNullOrEmpty(nameOrEmail))
            {
                MessageBox.Show("Пожалуйста, введите имя или email.");
                return;
            }

            if (nameOrEmail.Length < 3)
            {
                MessageBox.Show("Имя или email должно быть не короче 3 символов.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите пароль.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Пароль должен быть не короче 6 символов.");
                return;
            }

            if (AuthenticateUser(nameOrEmail, password))
            {
                MessageBox.Show("Успешный вход");

                int userId = GetUserIdByNameOrEmail(nameOrEmail);

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["IsLoggedIn"].Value = "true";
                config.AppSettings.Settings["UserId"].Value = userId.ToString();
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                IsLoggedIn = true;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Вы ввели неверное имя/почту или пароль");
            }
        }

        public bool AuthenticateUser(string input, string password)
        {
            string hashedPassword = HashPassword(password);

            string query = @"SELECT COUNT(*) FROM Users WHERE (Name = @Input OR Email = @Input) AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SecondDBConnection"].ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Input", input);
                command.Parameters.AddWithValue("@Password", hashedPassword);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при авторизации: {ex.Message}");
                    return false;
                }
            }
        }

        private int GetUserIdByNameOrEmail(string input)
        {
            string query = "SELECT Id FROM Users WHERE (Name = @Input OR Email = @Input)";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SecondDBConnection"].ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Input", input);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int userId))
                    {
                        return userId;
                    }
                    else
                    {
                        throw new Exception("Пользователь не найден.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}");
                    return -1;
                }
            }
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            using (Registration_Form registration_Form = new Registration_Form())
            {
                registration_Form.ShowDialog();
            }
            Visible = true;
        }

        public void loginNameEmail_txtb_Enter(object sender, EventArgs e)
        {
            loginAndEmail_lbl.Visible = false;
        }

        public void loginNameEmail_txtb_Leave(object sender, EventArgs e)
        {
            if (loginNameEmail_txtb.Text == "")
            {
                loginAndEmail_lbl.Visible = true;
            }
        }

        public void loginPassword_txtb_Enter(object sender, EventArgs e)
        {
            passwrod_lbl.Visible = false;
        }

        public void loginPassword_txtb_Leave(object sender, EventArgs e)
        {
            if (loginPassword_txtb.Text == "")
            {
                passwrod_lbl.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                loginPassword_txtb.UseSystemPasswordChar = false;
            }
            else
            {
                loginPassword_txtb.UseSystemPasswordChar = true;
            }
        }
    }
}