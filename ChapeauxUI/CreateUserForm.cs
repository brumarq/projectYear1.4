﻿using System;
using System.Windows.Forms;
using ChapeauxModel;
using ChapeauxLogic;

namespace ChapeauxUI
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm(User user)
        {
            InitializeComponent();
        }

        private void butCreateUserAccount_Click(object sender, EventArgs e)
        {
            User_Service user_Service = new User_Service();
            
            bool emptyFields = false;
            if (string.IsNullOrEmpty(txtFirstname.Text) || string.IsNullOrEmpty(txtLastname.Text)
                || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            { 
                emptyFields = true; 
            }
            
            if (emptyFields == true)
            {
                MessageBox.Show("Please Fill All Required Fields", "Required Fields are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Role userRole;
                if (rbManager.Checked)
                    userRole = Role.Manager;
                else if (rbChef.Checked)
                    userRole = Role.Chef;
                else if (rbBartender.Checked)
                    userRole = Role.Bartender;
                else
                    userRole = Role.Waiter;


                User tempUser = user_Service.GetUserByUsername(txtUsername.Text.ToString());
                
                if (tempUser != null) 
                    MessageBox.Show("Username already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    User newUser = new User() 
                    {
                        FirstName = txtFirstname.Text,
                        LastName = txtLastname.Text,
                        LoginUsername = txtUsername.Text,
                        LoginPassword = txtPassword.Text,
                        Role = userRole
                    };
                    user_Service.GetUsers(newUser); //add the new User to the DB
                    MessageBox.Show("Account Creation Successful", "Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        private void rbBartender_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
