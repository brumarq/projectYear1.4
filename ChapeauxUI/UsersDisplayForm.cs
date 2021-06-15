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
        ListViewItem lvItem;

        public UsersDisplayForm()
        {

            InitializeComponent();
            loggedUser = user;
            lblUserFullName.Text = $"{loggedUser.FirstName} {loggedUser.LastName}";

            GetUserList();
        }

        private void GetUserList()
        {
            try
            {
                userService = new User_Service();
                List<User> users = userService.GetUsers();

                listViewDisplayForm.Items.Clear();

                foreach (User u in users)
                {
                    lvItem = new ListViewItem(u.UserID.ToString(), "0");
                    lvItem.SubItems.Add(u.FirstName);
                    lvItem.SubItems.Add(u.LastName);
                    lvItem.SubItems.Add(u.LoginUsername);
                    lvItem.SubItems.Add(u.LoginPassword);
                    lvItem.SubItems.Add(u.Role.ToString());
                    lvItem.Tag = u;
                    listViewDisplayForm.Items.Add(lvItem);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Could not get the user list.", ex);
            }
        }

        private void listViewDisplayForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDisplayForm.SelectedItems.Count == 1)
            {
                user = listViewDisplayForm.SelectedItems[0].Tag as User;
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtUsername.Text = user.LoginUsername;
                txtPassword.Text = user.LoginPassword;
                cbRole.Text = user.Role.ToString();
            }
        }

        private string HashPassword(string givenPassword)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(givenPassword, salt, 10000);

            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);
        }

        public void AddUser()
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Add", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    user.FirstName = txtFirstName.Text;
                    user.LastName = txtLastName.Text;
                    user.LoginUsername = txtUsername.Text;
                    user.LoginPassword = HashPassword(txtPassword.Text);
                    user.Role = (Role)Enum.Parse(typeof(Role), cbRole.Text.ToString());

                    userService.AddUserAccount(user);
                    MessageBox.Show($"User added successfully.");
                }
                else
                    return;

                GetUserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void DeleteUser()
        {
            try
            {
                if (listViewDisplayForm.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        user = listViewDisplayForm.SelectedItems[0].Tag as User;

                        try
                        {
                            userService.RemoveUserAccount(user);
                            MessageBox.Show("Account deletion successful!");
                            listViewDisplayForm.Refresh();
                        }
                        catch (Exception exc)
                        {

                            MessageBox.Show(exc.Message);
                        }

                    }
                    else
                        return;

                    GetUserList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void EditUser()
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    user = listViewDisplayForm.SelectedItems[0].Tag as User;

                    user.FirstName = txtFirstName.Text;
                    user.LastName = txtFirstName.Text;
                    user.LoginUsername = txtUsername.Text;
                    user.LoginPassword = HashPassword(txtPassword.Text);
                    user.Role = (Role)Enum.Parse(typeof(Role), cbRole.Text.ToString());

                    userService.EditUserAccount(user);
                    MessageBox.Show("User successfully updated.");
                    listViewDisplayForm.Refresh();

                    GetUserList();
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            UsersDisplayForm usersDisplayForm = new UsersDisplayForm();
            usersDisplayForm.Show();
            this.Hide();
        }

        private void butLogOut_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void butMenuItemOverview_Click(object sender, EventArgs e)
        {
            if (butMenuItemOverview.Enabled)
            {
                Item menuItem = new Item();
                MenuItemDisplayForm menuItemDisplayForm = new MenuItemDisplayForm(menuItem, loggedUser);
                menuItemDisplayForm.Show();
                this.Close();
            }
        }

        private void butUserOverview_Click(object sender, EventArgs e)
        {
            GetUserList();
        }

        private void UsersDisplayForm_Load(object sender, EventArgs e)
        {
            butUserOverview.BackColor = Color.Yellow;
        }
    }
}
