using System;
using System.Windows.Forms;
using HLock.Forms;

namespace HLock
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginForm = new LoginForm();

            Application.Run(loginForm);

            if (loginForm.LoginSucceed)
                Application.Run(new MainForm());
        }
    }
}
