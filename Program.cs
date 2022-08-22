using SalesRep;

namespace SmartToll1._0
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
#pragma warning disable CS0246 // The type or namespace name 'LoginForm' could not be found (are you missing a using directive or an assembly reference?)
            Application.Run(new Login());
#pragma warning restore CS0246 // The type or namespace name 'LoginForm' could not be found (are you missing a using directive or an assembly reference?)
        }
    }
}