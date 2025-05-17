using SecondProject_Auto;
using SecondProject_Auto.Enums;
using System.Data.Entity;
using System.Configuration;
using Moq;
using SecondProject_Auto.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SecureProject_Auto.Tests.ComprehensiveTests
{
    public class AllUnitTests
    {
        // Тест 1
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

        // Тест 2
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

        // Тест 3
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

        // Тест 4
        [Fact]
        public void CarControl_Initialize_ShouldCreateAllControlsExceptImage()
        {
            var carControl = new CarControl();

            var nameLabel = carControl.Controls["nameLabel"] as Label;
            var priceLabel = carControl.Controls["priceLabel"] as Label;
            var descriptionButton = carControl.Controls["descriptionButton"] as Button;

            Assert.NotNull(nameLabel);
            Assert.NotNull(priceLabel);
            Assert.NotNull(descriptionButton);
        }

        // Тест 5
        [Fact]
        public void CarControl_SetPropertiesDirectly_ShouldSetPropertiesCorrectly()
        {
            var carControl = new CarControl();

            carControl.Id = 1;
            carControl.Name = "TestCar";
            carControl.Price = 25000;
            carControl.Description = "Test Description";

            var nameLabel = carControl.Controls["nameLabel"] as Label;

            Assert.Equal(1, carControl.Id);
            Assert.Equal("TestCar", carControl.Name);
            Assert.Equal(25000, carControl.Price);
            Assert.Equal("Test Description", carControl.Description);

            Assert.NotNull(nameLabel);
            Assert.Equal("TestCar", nameLabel.Text);
        }

        // Тест 6
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

        // Тест 7
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

        // Тест 8
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

        // Тест 9
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

        // Тест 10
        [Fact]
        public void MainWithLoginForm_ExitButton_ShouldUpdateConfig()
        {
            var form = new MainWithLogin_Form();
            ConfigurationManager.AppSettings["IsLoggedIn"] = "true";
            ConfigurationManager.AppSettings["UserId"] = "1";

            form.exit_btn_Click(null, null);

            Assert.Equal("false", ConfigurationManager.AppSettings["IsLoggedIn"]);
            Assert.Null(ConfigurationManager.AppSettings["UserId"]);
        }

        // Тест 11
        [Fact]
        public void AutoContext_Database_ShouldBeAccessible()
        {
            using (var context = new AutoContext())
            {
                var canConnect = context.Database.Exists();
                Assert.True(canConnect);
            }
        }

        // Тест 12
        [Fact]
        public void UserContext_Database_ShouldBeAccessible()
        {
            using (var context = new UserContext())
            {
                var canConnect = context.Database.Exists();
                Assert.True(canConnect);
            }
        }

        // Тест 13
        [Fact]
        public void Contexts_ShouldUseDifferentConnectionStrings()
        {
            using (var autoContext = new AutoContext())
            using (var userContext = new UserContext())
            {
                Assert.NotEqual(autoContext.Database.Connection.ConnectionString,
                              userContext.Database.Connection.ConnectionString);
            }
        }

        // Тест 14
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

        // Тест 15
        [Fact]
        public void RegistrationForm_InvalidEmailFormat_ShouldShowError()
        {
            var form = new Registration_Form();
            form.loginEmail_txtb.Text = "invalid-email";

            form.register_btn_Click(null, null);

            Assert.True(form.email_lbl.Visible);
            Assert.Equal("Неверный формат email", form.email_lbl.Text);
        }
    }
}