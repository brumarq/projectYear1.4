using System;
using ChapeauxModel;
using ChapeauxLogic;
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
            User delUser = new User();
            
            User connectedEmployee = new User();
            User employeeToEdit = new User();

            Application.Run(new DeleteAccountForm());
            Application.Run(new EditAccountForm(connectedEmployee, employeeToEdit));
            Application.Run(new LoginScreen());
        }
    }
}
