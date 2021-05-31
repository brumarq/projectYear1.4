using System;
using ChapeauxModel;
using System.Windows.Forms;

namespace ChapeauxUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //User user = new User();
            //Application.Run(new CreateUserForm(user));
            Application.Run(new LoginScreen());
        }
    }
}
