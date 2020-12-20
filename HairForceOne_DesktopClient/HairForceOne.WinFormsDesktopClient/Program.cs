using System;
using System.Windows.Forms;

namespace HairForceOne.WinFormsDesktopClient
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // hide login form? Programmet kan ikke lukkes derefter. Find løsning
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}