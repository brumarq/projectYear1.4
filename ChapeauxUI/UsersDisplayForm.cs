using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ChapeauxModel;
using ChapeauxLogic;
using System.Drawing;
using System.Security.Cryptography;

namespace ChapeauxUI
{
    public partial class UsersDisplayForm : Form
    {
        User user;
        User loggedUser;
        User_Service userService;
        
        public UsersDisplayForm(User user)
        {
            InitializeComponent();
            loggedUser = user;
            lblUserFullName.Text = $"{loggedUser.FirstName} {loggedUser.LastName}";

            RefreshUserList();
        }

        //this list also get users with 'GetUsers' method
        public void RefreshUserList() 
        {
            try
            {
                userService = new User_Service();
                List<User> users = userService.GetUsers();

                listViewDisplayForm.Items.Clear();

                foreach (User u in users)
                {
                    ListViewItem lvItem = new ListViewItem(u.UserID.ToString(), 0);
                    lvItem.SubItems.Add(u.FirstName);
                    lvItem.SubItems.Add(u.LastName);
                    lvItem.SubItems.Add(u.LoginUsername);
                    lvItem.SubItems.Add(u.LoginPassword);
                    lvItem.SubItems.Add(u.Role.ToString());
                    lvItem.Tag = u;
                    if (u.LoginUsername == "" || u.LoginPassword == "")
                    {
                        lvItem.ForeColor = Color.DarkGray;
                    }
                    listViewDisplayForm.Items.Add(lvItem);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Could not get the user list.", ex);
            }
        }

        //fill textbox information for selected user
        private void listViewDisplayForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDisplayForm.SelectedItems.Count == 1)
            {
                user = listViewDisplayForm.SelectedItems[0].Tag as User;
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtUsername.Text = user.LoginUsername;
                cbRole.Text = user.Role.ToString();
            }
        }

        public string HashPassword(string givenPassword)
        {
            if (givenPassword == "")
            {
                //to prevent from hashing empty passwords 
                return givenPassword;
            }
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(givenPassword, salt, 10000);

            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            AddNewUserForm addNewUserForm = new AddNewUserForm(this, user);
            if (addNewUserForm.Enabled)
            {
                //lets not go back to another form before doing something with form infront
                addNewUserForm.ShowDialog();
            }
        }

        private void UpdateUser()
        {
            try
            {
                if (MessageBox.Show($"Are you sure you want to update '{txtFirstName.Text} {txtLastName.Text}'?", "Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    user = listViewDisplayForm.SelectedItems[0].Tag as User;

                    user.FirstName = txtFirstName.Text;
                    user.LastName = txtLastName.Text;
                    user.LoginUsername = txtUsername.Text;
                    user.LoginPassword = HashPassword(txtPassword.Text);
                    user.Role = (Role)Enum.Parse(typeof(Role), cbRole.Text.ToString());

                    userService.EditUserAccount(user);
                    MessageBox.Show("User successfully updated.");
                    listViewDisplayForm.Refresh();

                    RefreshUserList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void RemoveUserPermissions()
        {
            try
            {
                if (listViewDisplayForm.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show($"Are you sure you want to remove {txtFirstName.Text} {txtLastName.Text}'s login permission?", "Remove", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        user = listViewDisplayForm.SelectedItems[0].Tag as User;

                        try
                        {
                            userService.RemoveUserPermissions(user);
                            MessageBox.Show("User Login permission removed!");
                            listViewDisplayForm.Refresh();
                        }
                        catch (Exception exc)
                        {

                            MessageBox.Show(exc.Message);
                        }

                    }
                    
                    RefreshUserList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            RemoveUserPermissions();
        }


        private void butBack_Click(object sender, EventArgs e)
        {
            UsersDisplayForm usersDisplayForm = new UsersDisplayForm(user);
            usersDisplayForm.Show();
            Hide();
        }

        private void butMenuItemOverview_Click(object sender, EventArgs e)
        {
            if (butMenuItemOverview.Enabled)
            {
                Item menuItem = new Item();
                MenuItemDisplayForm menuItemDisplayForm = new MenuItemDisplayForm(menuItem, loggedUser);
                menuItemDisplayForm.Show();
                Close();
            }
        }

        private void butUserOverview_Click(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        private void UsersDisplayForm_Load(object sender, EventArgs e)
        {
            butUserOverview.BackColor = Color.Yellow;
        }

        private void butLogOut_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            Hide();
        }
    }
}
