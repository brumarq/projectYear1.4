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
            Item item = new Item();
            User user = new User();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new LoginScreen());
            //Application.Run(new UsersDisplayForm(user));
            Application.Run(new MenuItemDisplayForm(item));

        }
    }
}
