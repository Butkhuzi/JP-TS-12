using TodoApp.Library;
using TodoApp.Services;

namespace TodoApp.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Choosing database type
            GlobalConfig.ChooseDatabase(DatabaseType.Sql);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new RegisterForm());
        }
    }
}