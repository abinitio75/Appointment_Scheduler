using System;
using System.Windows.Forms;
using System.Globalization;

namespace Appointment_Scheduler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (CultureInfo.CurrentCulture.LCID != 1033)
                CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
