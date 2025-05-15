using SecondProject_Auto.Forms;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace SecondProject_Auto
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            bool IsLoggedIn = bool.Parse(ConfigurationManager.AppSettings["IsLoggedIn"]);

            if (IsLoggedIn)
            {
                Application.Run(new MainWithLogin_Form());
            }
            else
            {
                Main_Form mainForm = new Main_Form();
                ApplicationContext appContext = new ApplicationContext(mainForm);
                mainForm.Tag = appContext;

                Application.Run(appContext);
            }
        }
    }
}
