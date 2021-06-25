using System;
using System.Windows.Forms;
using ChapeauxModel;
using ChapeauxLogic;

namespace ChapeauxUI
{
    public partial class AddNewUserForm : Form
    {
        User user;
        User_Service user_Service;
        UsersDisplayForm userDisplayForm;

        public AddNewUserForm(UsersDisplayForm userForm)
        {
            InitializeComponent();
            userDisplayForm = userForm;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Are you sure you want to add user '{txtFirstName.Text} {txtLastName.Text}'?", "Add", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    user = new User();
                    user.FirstName = txtFirstName.Text;
                    user.LastName = txtLastName.Text;
                    user.LoginUsername = txtUsername.Text;
                    user.LoginPassword = userDisplayForm.HashPassword(txtPassword.Text);
                    user.Role = (Role)Enum.Parse(typeof(Role), cbRole.Text.ToString());

                    user_Service = new User_Service();
                    user_Service.AddUserAccount(user);
                    MessageBox.Show($"User added successfully.");
                }

                userDisplayForm.RefreshUserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
