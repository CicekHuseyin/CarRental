using CarRental.Business.Abstract;
using CarRental.Business.Concrete;

namespace CarRental.WinFormsUI
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
            ApplicationConfiguration.Initialize();

            IAuthService authService = new AuthManager(); // Business katmaný
            Application.Run(new FrmLogin());
        }
    }
}