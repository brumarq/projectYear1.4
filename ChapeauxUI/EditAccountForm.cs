using System;
using System.Windows.Forms;
using ChapeauxLogic;
using ChapeauxModel;

namespace ChapeauxUI
{
    public partial class EditAccountForm : Form
    {
        private User existingUser;
        private User newUser;
        public EditAccountForm(User existingUser, User newUser)
        {
            InitializeComponent();
            this.existingUser = existingUser;
            this.newUser = newUser;
        }

        private void butEditUserAccount_Click(object sender, EventArgs e)
        {
            User_Service user_Service = new User_Service();

            //storing input from TextBoxes into the newUser variables
            newUser.FirstName = txtFirstname.Text;
            newUser.LastName = txtLastname.Text;
            newUser.LoginUsername = txtUsername.Text;
            newUser.LoginPassword = txtPassword.Text;
            
            //checking the radio button with the correct role
            if (newUser.Role == Role.Manager)
                rbManager.Checked = true;
            else if (newUser.Role == Role.Chef)
                rbChef.Checked = true;
            else if (newUser.Role == Role.Bartender)
                rbBartender.Checked = true;
            else
                rbWaiter.Checked = true;

            //validating the variables above are not null or empty
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
                Role newRole;       //assigns the new role
                if (rbManager.Checked)
                    newRole = Role.Manager;
                else if (rbChef.Checked)
                    newRole = Role.Chef;
                else if (rbBartender.Checked)
                    newRole = Role.Bartender;
                else
                    newRole = Role.Waiter;

                User newUser = new User()
                {
                    FirstName = txtFirstname.Text,
                    LastName = txtLastname.Text,
                    LoginUsername = txtUsername.Text,
                    LoginPassword = txtPassword.Text,
                    Role = newRole
                };
                user_Service.EditUserAccount(existingUser, newUser); //edits the user account
                MessageBox.Show("Account Editing Successful!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);//messagebox asterisk contains a symbol consisting of a lowercase letter i in a circle.
            }
        }
    }
}
