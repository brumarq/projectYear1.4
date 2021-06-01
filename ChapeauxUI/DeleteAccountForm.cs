using System;
using System.Windows.Forms;
using ChapeauxModel;
using ChapeauxLogic;

namespace ChapeauxUI
{
    public partial class DeleteAccountForm : Form
    {
        
        public DeleteAccountForm()
        {
            InitializeComponent();
        }

        private void rbBartender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void butDeleteUserAccount_Click(object sender, EventArgs e)
        {
            int effectedRows = 0;
            User_Service user_Service = new User_Service();

            bool emptyFields = false;
            if (string.IsNullOrEmpty(txtFirstname.Text) || string.IsNullOrEmpty(txtLastname.Text)
                || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                emptyFields = true;
            }

            if (emptyFields == true)
            {
                MessageBox.Show("Please Fill All Required Fields To Delete", "Required Fields are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   //assigns the role
                Role userRole;
                if (rbManager.Checked)
                    userRole = Role.Manager;
                else if (rbChef.Checked)
                    userRole = Role.Chef;
                else if (rbBartender.Checked)
                    userRole = Role.Bartender;
                else
                    userRole = Role.Waiter;

                User deleteUser = new User()
                {
                    FirstName = txtFirstname.Text,
                    LastName = txtLastname.Text,
                    LoginUsername = txtUsername.Text,
                    LoginPassword = txtPassword.Text,
                    Role = userRole
                };

                DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Account!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    if (effectedRows >= 0)
                    {
                        user_Service.RemoveUserAccount(deleteUser); //delete the User from the DB 
                        MessageBox.Show("Account deletion successful!");
                    }
                }
                else
                    MessageBox.Show("Could not delete the account!");
            }
        }
    }
}