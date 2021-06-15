using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ChapeauxModel;
using ChapeauxLogic;
using System.Drawing;

namespace ChapeauxUI
{
    public partial class UsersDisplayForm : Form
    {
        User user;
        User_Service userService;
        ListViewItem lvItem;

        public UsersDisplayForm()
        {
            InitializeComponent();

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

        public void AddUser()
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Add", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    user.FirstName = txtFirstName.Text;
                    user.LastName = txtLastName.Text;
                    user.LoginUsername = txtUsername.Text;
                    user.LoginPassword = txtPassword.Text;
                    cbRole.Text = user.Role.ToString();

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
                        
                        userService.RemoveUserAccount(user);
                        MessageBox.Show("Account deletion successful!");
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
                    user.LoginPassword = txtPassword.Text;
                    
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
                MenuItemDisplayForm menuItemDisplayForm = new MenuItemDisplayForm(menuItem);
                menuItemDisplayForm.Show();
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
