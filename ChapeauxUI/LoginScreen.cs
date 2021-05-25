using ChapeauxLogic;
using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
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

        private void ChapeauxUI_Load(object sender, EventArgs e)
        {
        
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
                User user = userService.LoginCheck(givenUsername);

                if (user == null)
                {
                    throw new Exception("Username does not exist");
                }
                else
                {
                    /*
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

                    // Checking if the given password is correct. Source: https://medium.com/@mehanix/lets-talk-security-salted-password-hashing-in-c-5460be5c3aae
                    // Turn received hashed password into bytes
                    byte[] hashBytes = Convert.FromBase64String(user.LoginPassword);
                    // Take the salt out of hashBytes and save it into the salt array
                    byte[] salt = new byte[16];
                    Array.Copy(hashBytes, 0, salt, 0, 16);

                    // Hash the given password with the salt that was saved in the database, and save the result in the hash array
                    Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(givenPassword, salt, 10000);
                    byte[] hash = pbkdf2.GetBytes(20);

                    // Compare the hash from the given password with the hash from the database
                    bool result = true;
                    for (int i = 0; i < 20; i++)
                    {
                        if (hashBytes[i + 16] != hash[i])
                        {
                            result = false;
                        }
                    }

                    if (result) 
                    {
                        //MessageBox.Show("Login Sucessfull");
                        //OverviewPanel.Show();
                        
                        new TableOverviewForm(user).Show();
                        this.Hide();
                        //LoginPanel.Hide();
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
