using System;
using System.Windows.Forms;
using ChapeauxModel;
using ChapeauxLogic;

namespace ChapeauxUI
{
    public partial class CreateUserForm : Form
    {
        private User user;

        public CreateUserForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }


        //user will not be able to insert null values
        private bool emptyFields()
        {
            if 
            ((txtFirstname.Text.ToString().Trim() == string.Empty || txtLastname.Text.ToString().Trim() == string.Empty) || 
            (txtUsername.Text.ToString().Trim() == string.Empty) || txtPassword.Text.ToString().Trim() == string.Empty)
            {
                return false;
            }
            else if (!rbManager.Checked && !rbChef.Checked && !rbBartender.Checked && !rbWaiter.Checked)
            {
                return false;
            }
            return true;
        }

        private void butCreateUserAccount_Click(object sender, EventArgs e)
        {
            User_Service user_Service = new User_Service();
            
            if(emptyFields())
            {
                MessageBox.Show("Please Fill All Required Fields", "Required Fields are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // set the User Role based on what was checked
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
                if (tempUser != null) //check if that username already exists
                    MessageBox.Show("This username already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    User newUser = new User() //create the new employee
                    {
                        FirstName = txtFirstname.Text,
                        LastName = txtLastname.Text,
                        LoginUsername = txtUsername.Text,
                        LoginPassword = txtPassword.Text,
                        Role = userRole
                    };
                    user_Service.GetUsers(newUser); //add the new employee to the DB
                    MessageBox.Show("New account added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        private void rbBartender_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
