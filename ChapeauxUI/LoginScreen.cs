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
        User createUser = new User();
        User prevUser = new User();
        User curUser = new User();
        User deleteUser = new User();
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
                    throw new Exception("Enter login information!");
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
                    else if(user.Role == Role.Bartender || user.Role == Role.Chef)
                    {
                        //new KitchenDisplay(user).Show();
                    }
                       
                    else if (user.Role == Role.Manager)
                    {
                        /*new AddAccountForm(createUser).Show();
                        this.Hide();

                        new EditAccountForm(prevUser, curUser).Show();
                        this.Hide();

                        new DeleteAccountForm(user);

                        new AddMenuItem(menuItem);
                        this.Hide();

                        new DeleteMenuItem(menuItem); 
                        this.Hide();*/

                    }
                }
                else
                {
                    throw new Exception("Incorrect password!");
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


/* Use this code to create hashed Passwords
byte[] salt;
new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

var pbkdf2 = new Rfc2898DeriveBytes("test..123", salt, 10000);

byte[] hash = pbkdf2.GetBytes(20);
byte[] hashBytes = new byte[36];

Array.Copy(salt, 0, hashBytes, 0, 16);
Array.Copy(hash, 0, hashBytes, 16, 20);

string savedPasswordHash = Convert.ToBase64String(hashBytes);

txtPassword.Text = savedPasswordHash;
*/