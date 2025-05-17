using Moq;
using SecondProject_Auto;
using SecondProject_Auto.Enums;
using SecondProject_Auto.Forms;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Xunit;

namespace SecondProject_Auto.Tests.ComprehensiveTests
{
    public class AllUnitTests
    {
        // Тест 1: Добавление пользователя в БД
        [Fact]
        public void UserContext_AddUser_ShouldPersistInDatabase()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<UserContext>());
            var user = new User { Name = "TestUser1", Email = "test1@example.com", Password = "pass1" };
            using (var context = new UserContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            using (var context = new UserContext())
            {
                var savedUser = context.Users.Find(user.Id);
                Assert.NotNull(savedUser);
                Assert.Equal("test1@example.com", savedUser.Email);
            }
            using (var context = new UserContext())
            {
                context.Users.RemoveRange(context.Users.Where(u => u.Name == "TestUser1"));
                context.SaveChanges();
            }
        }

        // Тест 2: Поиск пользователя по ID
        [Fact]
        public void UserContext_FindUserById_ShouldReturnCorrectUser()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<UserContext>());
            var user = new User { Name = "TestUser2", Email = "test2@example.com", Password = "pass2" };
            using (var context = new UserContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            using (var context = new UserContext())
            {
                var foundUser = context.Users.Find(user.Id);
                Assert.NotNull(foundUser);
                Assert.Equal("TestUser2", foundUser.Name);
            }
            using (var context = new UserContext())
            {
                context.Users.RemoveRange(context.Users.Where(u => u.Name == "TestUser2"));
                context.SaveChanges();
            }
        }

        // Тест 3: Добавление автомобиля в БД
        [Fact]
        public void AutoContext_AddAuto_ShouldPersistInDatabase()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<AutoContext>());
            if (!Enum.TryParse<FuelType>("Бензин", out var fuelType))
                Assert.Fail("Неверное значение FuelType");
            var auto = new Auto
            {
                Name = "TestAuto1",
                Price = 30000,
                AutoType = "Sedan",
                FuelType = fuelType,
                Engine = "2.0L",
                HorsePower = 150,
                SeatingCapacity = 5,
                Mfr = "Manufacturer1"
            };
            using (var context = new AutoContext())
            {
                context.Autos.Add(auto);
                context.SaveChanges();
            }
            using (var context = new AutoContext())
            {
                var savedAuto = context.Autos.Find(auto.Id);
                Assert.NotNull(savedAuto);
                Assert.Equal(30000, savedAuto.Price);
            }
            using (var context = new AutoContext())
            {
                context.Autos.RemoveRange(context.Autos.Where(a => a.Name == "TestAuto1"));
                context.SaveChanges();
            }
        }

        // Тест 4: Создание CarControl с тестовым автомобилем
        [Fact]
        public void CarControl_Initialize_ShouldCreateAllControlsExceptImage()
        {
            var testAuto = new Auto
            {
                Id = 1,
                Name = "TestCar",
                Price = 25000,
                Color = "Red",
                PhotoFilePath = "test.jpg"
            };

            var carControl = new CarControl(testAuto);

            var nameLabel = carControl.Controls.OfType<Label>().FirstOrDefault(c => c.Name == "name_lbl");
            var priceLabel = carControl.Controls.OfType<Label>().FirstOrDefault(c => c.Name == "price_lbl");
            var descriptionButton = carControl.Controls.OfType<Button>().FirstOrDefault(c => c.Name == "description_btn");

            Assert.NotNull(nameLabel);
            Assert.NotNull(priceLabel);
            Assert.NotNull(descriptionButton);
        }

        // Тест 5: Установка свойств CarControl
        [Fact]
        public void CarControl_SetPropertiesDirectly_ShouldSetPropertiesCorrectly()
        {
            var testAuto = new Auto
            {
                Id = 1,
                Name = "TestCar",
                Price = 25000,
                Color = "Red",
                PhotoFilePath = "test.jpg"
            };

            var carControl = new CarControl(testAuto);

            carControl.Id = 2;
            carControl.Name = "UpdatedCarName";
            carControl.Price = 30000;
            carControl.Description = "Updated Description";

            var nameLabel = carControl.Controls.OfType<Label>().FirstOrDefault(c => c.Name == "name_lbl");

            Assert.Equal(2, carControl.Id);
            Assert.Equal("UpdatedCarName", carControl.Name);
            Assert.Equal(30000, carControl.Price);
            Assert.Equal("Updated Description", carControl.Description);
            Assert.NotNull(nameLabel);
            Assert.Equal("UpdatedCarName", nameLabel.Text);
        }

        // Тест 6: Хэширование пароля в LoginForm
        [Fact]
        public void LoginForm_HashPassword_ShouldReturnConsistentHash()
        {
            var loginForm = new Login_Form();
            string password = "testPassword123";
            var hash1 = loginForm.HashPassword(password);
            var hash2 = loginForm.HashPassword(password);
            Assert.Equal(hash1, hash2);
            Assert.NotEqual(password, hash1);
        }

        // Тест 7: Пустые поля в регистрации
        [Fact]
        public void RegistrationForm_EmptyFields_ShouldShowValidationMessages()
        {
            var form = new Registration_Form();
            form.loginName_txtb.Text = "";
            form.loginEmail_txtb.Text = "";
            form.loginPassword_txtb.Text = "";
            form.loginSecPassword_txtb.Text = "";
            form.register_btn_Click(null, null);
            Assert.True(form.name_lbl.Visible);
            Assert.True(form.email_lbl.Visible);
            Assert.True(form.password_lbl.Visible);
            Assert.True(form.secPassword_lbl.Visible);
        }

        // Тест 8: Несовпадение паролей при регистрации
        [Fact]
        public void RegistrationForm_MismatchedPasswords_ShouldNotRegister()
        {
            var form = new Registration_Form();
            form.loginName_txtb.Text = "NewUser";
            form.loginEmail_txtb.Text = "new@user.com";
            form.loginPassword_txtb.Text = "password123";
            form.loginSecPassword_txtb.Text = "different";
            form.register_btn_Click(null, null);
            using (var context = new UserContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Name == "NewUser");
                Assert.Null(user);
            }
        }

        // Тест 9: Загрузка автомобилей на главной форме
        [Fact]
        public void MainWithLoginForm_Load_ShouldDisplayCars()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<AutoContext>());
            var testAuto = new Auto
            {
                Name = "TestAuto2",
                Price = 40000,
                AutoType = "SUV",
                FuelType = FuelType.Дизель,
                Engine = "3.0L",
                HorsePower = 250,
                SeatingCapacity = 7,
                Mfr = "Toyota"
            };
            using (var context = new AutoContext())
            {
                context.Autos.Add(testAuto);
                context.SaveChanges();
            }
            var form = new MainWithLogin_Form();
            Assert.True(form.flowLayoutPanel1.Controls.Count > 0);
            using (var context = new AutoContext())
            {
                context.Autos.RemoveRange(context.Autos.Where(a => a.Name == "TestAuto2"));
                context.SaveChanges();
            }
        }

        // Тест 10: Выход из аккаунта обновляет конфигурацию
        [Fact]
        public void MainWithLoginForm_ExitButton_ShouldUpdateConfig()
        {
            var form = new MainWithLogin_Form();
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["IsLoggedIn"].Value = "true";
            config.AppSettings.Settings["UserId"].Value = "1";
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            form.exit_btn_Click(null, null);
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            Assert.Equal("false", config.AppSettings.Settings["IsLoggedIn"].Value);
            Assert.Null(config.AppSettings.Settings["UserId"].Value);
        }

        // Тест 11: Проверка подключения к базе автомобилей
        [Fact]
        public void AutoContext_Database_ShouldBeAccessible()
        {
            using (var context = new AutoContext())
            {
                var canConnect = context.Database.Exists();
                Assert.True(canConnect);
            }
        }

        // Тест 12: Проверка подключения к базе пользователей
        [Fact]
        public void UserContext_Database_ShouldBeAccessible()
        {
            using (var context = new UserContext())
            {
                var canConnect = context.Database.Exists();
                Assert.True(canConnect);
            }
        }

        // Тест 13: Разные строки подключения для разных контекстов
        [Fact]
        public void Contexts_ShouldUseDifferentConnectionStrings()
        {
            using (var autoContext = new AutoContext())
            using (var userContext = new UserContext())
            {
                Assert.NotEqual(
                    autoContext.Database.Connection.ConnectionString,
                    userContext.Database.Connection.ConnectionString
                );
            }
        }

        // Тест 14: Аутентификация с моком возвращает true
        [Fact]
        public void LoginForm_AuthenticateUser_WithMock_ShouldReturnTrueForValidCredentials()
        {
            var mockConnection = new Mock<SqlConnection>();
            var mockCommand = new Mock<SqlCommand>();
            mockCommand.Setup(c => c.ExecuteScalar()).Returns(1);
            var loginForm = new Login_Form();
            var result = loginForm.AuthenticateUser("valid", "valid");
            Assert.True(result);
        }

        // Тест 15: Неверный формат email показывает ошибку
        [Fact]
        public void RegistrationForm_InvalidEmailFormat_ShouldShowError()
        {
            var form = new Registration_Form();
            form.loginEmail_txtb.Text = "invalid-email";
            form.register_btn_Click(null, null);
            Assert.True(form.email_lbl.Visible);
        }

        // Тест 16: Изменение фото в EditDescriptionCar_Form
        [Fact]
        public void EditDescriptionCar_ChangePhoto_ShouldUpdateImage()
        {
            var testAuto = new Auto
            {
                Name = "TestCar",
                PhotoFilePath = @"..\..\Resources\old.jpg"
            };
            var form = new EditDescriptionCar_Form(testAuto);
            var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            var tempImagePath = Path.Combine(tempDir, "new.jpg");
            File.WriteAllText(tempImagePath, "mock image data");

            var mockDialog = new Mock<OpenFileDialog>();
            mockDialog.Setup(d => d.ShowDialog()).Returns(DialogResult.OK);
            mockDialog.Setup(d => d.FileName).Returns(tempImagePath);
            mockDialog.Setup(d => d.SafeFileName).Returns("new.jpg");

            form.photo_btn_Click(null, null);

            Assert.Contains("new.jpg", form.car.PhotoFilePath);
            Assert.True(File.Exists(form.car.PhotoFilePath));
        }

        // Тест 17: Редактирование профиля пользователя
        [Fact]
        public void ProfileForm_SaveChanges_ShouldUpdateUserInDatabase()
        {
            var testUser = new User { Name = "OldName", Email = "old@example.com", Password = "pass" };
            using (var context = new UserContext())
            {
                context.Users.Add(testUser);
                context.SaveChanges();
            }
            using (var form = new Profile_Form())
            {
                form.loginName_txtb.Text = "NewName";
                form.loginEmail_txtb.Text = "new@example.com";
                form.save_btn_Click(null, null);
            }
            using (var context = new UserContext())
            {
                var updatedUser = context.Users.Find(testUser.Id);
                Assert.Equal("NewName", updatedUser.Name);
                Assert.Equal("new@example.com", updatedUser.Email);
            }
            using (var context = new UserContext())
            {
                context.Users.RemoveRange(context.Users.Where(u => u.Name == "NewName"));
                context.SaveChanges();
            }
        }

        // Тест 18: Удаление пользователя
        [Fact]
        public void ProfileForm_DeleteUser_ShouldRemoveFromDatabase()
        {
            var testUser = new User { Name = "ToDelete", Email = "delete@example.com", Password = "pass" };
            using (var context = new UserContext())
            {
                context.Users.Add(testUser);
                context.SaveChanges();
            }
            using (var form = new Profile_Form())
            {
                form.delete_btn_Click(null, null);
            }
            using (var context = new UserContext())
            {
                var deletedUser = context.Users.Find(testUser.Id);
                Assert.Null(deletedUser);
            }
        }

        // Тест 19: Включение/выключение отображения пароля
        [Fact]
        public void LoginForm_TogglePasswordVisibility_ShouldWork()
        {
            var form = new Login_Form();
            form.checkBox1.Checked = false;
            Assert.False(form.loginPassword_txtb.UseSystemPasswordChar);
            form.checkBox1.Checked = true;
            Assert.True(form.loginPassword_txtb.UseSystemPasswordChar);
        }

        // Тест 20: Подсказки исчезают при фокусе
        [Fact]
        public void LoginForm_PlaceholderBehavior_ShouldDisappearOnFocus()
        {
            var form = new Login_Form();
            form.loginNameEmail_txtb.Text = "";
            form.loginNameEmail_txtb_Enter(null, null);
            Assert.False(form.loginAndEmail_lbl.Visible);
        }

        // Тест 21: Подсказки возвращаются при потере фокуса
        [Fact]
        public void LoginForm_PlaceholderBehavior_ShouldReappearOnLeave()
        {
            var form = new Login_Form();
            form.loginNameEmail_txtb.Text = "";
            form.loginNameEmail_txtb_Leave(null, null);
            Assert.True(form.loginAndEmail_lbl.Visible);
        }

        // Тест 22: Форма регистрации закрывается
        [Fact]
        public void RegistrationForm_Close_ShouldNotThrowException()
        {
            var form = new Registration_Form();
            var ex = Record.Exception(() => form.Close());
            Assert.Null(ex);
        }

        // Тест 23: Стартовая форма загружает данные
        [Fact]
        public void StartForm_LoadData_ShouldNotThrowException()
        {
            var form = new Start_Form();
            var ex = Record.Exception(() => form.LoadData());
            Assert.Null(ex);
        }

        // Тест 24: CarEventArgs содержит правильный автомобиль
        [Fact]
        public void CarEventArgs_ShouldContainCorrectCar()
        {
            var testAuto = new Auto { Name = "TestCar" };
            var args = new CarEventArgs(testAuto);
            Assert.Equal(testAuto, args.SelectedCar);
        }
    }
}