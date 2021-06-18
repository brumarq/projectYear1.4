using ChapeauxLogic;
using ChapeauxModel;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ChapeauxUI
{
    public partial class LoginScreen : Form
    {
        private EventLog appLog = new EventLog("Application"); // Initiate EventLog

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
                    lblError.Text = "";

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
                        lblError.Text = "Error has occured, try again!";
                    }
                }
                else
                {
                    lblError.Text = "Incorrect Password!";
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