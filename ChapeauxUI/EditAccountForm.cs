using System;
using System.Windows.Forms;
using ChapeauxLogic;
using ChapeauxModel;

namespace ChapeauxUI
{
    public partial class EditAccountForm : Form
    {
        private User existingUser;
        private User editUser;
        public EditAccountForm(User existingUser, User editUser)
        {
            InitializeComponent();
            this.existingUser = existingUser;
            this.editUser = editUser;
        }
        private void EditAccountForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            // it fills the textboxes with the current information
            txtFirstname.Text = editUser.FirstName;
            txtLastname.Text = editUser.LastName;
            txtUsername.Text = editUser.LoginUsername;
            txtPassword.Text = editUser.LoginPassword;

            //checking the radio button with the correct role
            if (editUser.Role == Role.Manager)
            {
                rbManager.Checked = true;
            }

            else if (editUser.Role == Role.Chef)
            {
                rbChef.Checked = true;
            }

            else if (editUser.Role == Role.Bartender)
            { 
                rbBartender.Checked = true;
            }

            else
                rbWaiter.Checked = true;
        }

        private void butEditUserAccount_Click(object sender, EventArgs e)
        {
            bool emptyFields = false;
            User_Service user_Service = new User_Service();

            //validating the variables above are not null or empty
            if (string.IsNullOrEmpty(txtUsername.Text))
            { 
                txtUsername.Text = editUser.LoginUsername; 
            }
            else if (string.IsNullOrEmpty(txtFirstname.Text))
            { 
                txtFirstname.Text = editUser.FirstName; 
            }
            else if (string.IsNullOrEmpty(txtLastname.Text))
            { 
                txtLastname.Text = editUser.LastName; 
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Text = editUser.LoginPassword;
            }

            if (emptyFields == true)
            {
                MessageBox.Show("Please Fill All Required Fields", "Required Fields are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure?", "Edit Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Role newRole;       //assigns the new role
                    if (rbManager.Checked)
                        newRole = Role.Manager;
                    else if (rbChef.Checked)
                        newRole = Role.Chef;
                    else if (rbBartender.Checked)
                        newRole = Role.Bartender;
                    else
                        newRole = Role.Waiter;

                    User newUser = new User() //assigns fields to new user
                    {
                        FirstName = txtFirstname.Text,
                        LastName = txtLastname.Text,
                        LoginUsername = txtUsername.Text,
                        LoginPassword = txtPassword.Text,
                        Role = newRole
                    };
                    user_Service.EditUserAccount(existingUser, newUser); //edits the user account > edited user account
                    MessageBox.Show("Account Editing Successful!", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Could not edit the account!");
            }
        }

    }
}
