using System;
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
            bool emptyFields = false;
            User_Service user_Service = new User_Service();
            
            if (string.IsNullOrEmpty(txtFirstname.Text) || string.IsNullOrEmpty(txtLastname.Text)
                || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            { 
                emptyFields = true; 
            }
            
            if (emptyFields)
            {
                MessageBox.Show("Please Fill All Fields!", "Required Fields are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                DialogResult dialog = MessageBox.Show("Are you sure?", "Create Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    //assigns the role
                    Role userRole;
                    if (rbManager.Checked)
                        userRole = Role.Manager;
                    else if (rbChef.Checked)
                        userRole = Role.Chef;
                    else if (rbBartender.Checked)
                        userRole = Role.Bartender;
                    else
                        userRole = Role.Waiter;

                    User existingUser = user_Service.GetUserByUsername(txtUsername.Text);

                    if (existingUser != null)
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
                        
                        user_Service.AddUserAccount(newUser); //add the new User to the DB
                        MessageBox.Show("Account Creation Successful", "Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                    MessageBox.Show("Could not create the account!");
            }
        }
        private void rbBartender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
