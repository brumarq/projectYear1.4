using ChapeauxLogic;
using ChapeauxModel;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ChapeauxUI
{
    public partial class LoginScreen : Form
    {
        private EventLog appLog = new EventLog("Application"); // Initiate EventLog
        Item menuItem = new Item();

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string givenUsername = txtUsername.Text;
            string givenPassword = txtPassword.Text;

            try
            {
                if (givenUsername == "" || givenPassword == "")
                {
                    lblError.Text = "Enter login information!";
                    return;
                }

                User_Service userService = new User_Service();
                User user = userService.LoginCheck(givenUsername, givenPassword);

                if (user != null)
                {
                    if (user.Role == Role.Waiter)
                    {
                        new TableOverviewForm(user).Show();
                        this.Hide();
                    }
                    else if (user.Role == Role.Bartender || user.Role == Role.Chef)
                    {
                        new KitchenDisplay(user).Show();
                        this.Hide();
                    }
                    else if (user.Role == Role.Manager)
                    {
                        new UsersDisplayForm(user).Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new Exception("Incorrect password!");
                    }
                }
            }
            catch (Exception err)
            {
                appLog.Source = "Application";
                appLog.WriteEntry(err.Message);
                MessageBox.Show(err.Message);
            }
        }
    }
}