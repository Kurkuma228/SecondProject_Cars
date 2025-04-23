using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondProject_Auto.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string loginName = loginName_txtb.Text;
                string loginEmail = loginEmail_txtb.Text;
                string loginPassword = loginPassword_txtb.Text;

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

                using (var context = new UserContext())
                {
                    var user = new User
                    {
                        Name = loginName,
                        Email = loginEmail,
                        Password = loginPassword
                    };

                    context.Users.Add(user);
                    context.SaveChanges();
                }
                MessageBox.Show("Вы успешно зарегистрированы");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainFormWithLogin mainFormWithLogin = new MainFormWithLogin();
            mainFormWithLogin.ShowDialog();
        }
    }
}
