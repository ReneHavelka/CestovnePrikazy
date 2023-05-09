using CestovnePrikazy.CQR.Commands.CreateTables;
using CestovnePrikazy.Services;

namespace CestovnePrikazy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //new CreateTables().DoCreateTables();
            
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}