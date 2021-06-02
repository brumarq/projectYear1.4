﻿using System;
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
            
            User addUser = new User();
            //Application.Run(new AddAccountForm(addUser));
            
            User delUser = new User();
            //Application.Run(new DeleteAccountForm(delUser));

            User prevUser = new User();
            User currUser = new User();
            //Application.Run(new EditAccountForm(prevUser, currUser));


            Item addItem = new Item();
            //Application.Run(new AddMenuItem(addItem));

            Item deleteItem = new Item();
            //Application.Run(new DeleteMenuItem(deleteItem));

            Item lastItem = new Item();
            Item currItem = new Item();
            //Application.Run(new EditMenuItemForm(lastItem,currItem));


            //Application.Run(new LoginScreen());

        }
    }
}
