using System.Drawing.Text;

namespace Tap_The_Circles_
{
    internal static class Program
    {
        private static int balance;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(balance));
        }
    }
}