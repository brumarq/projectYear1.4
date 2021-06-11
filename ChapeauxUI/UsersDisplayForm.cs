using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ChapeauxModel;
using ChapeauxLogic;

namespace ChapeauxUI
{
    public partial class UsersDisplayForm : Form
    {
        User user;
        User_Service userService;
        ListViewItem lvItem;

        public UsersDisplayForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UsersDisplayForm_Load(object sender, EventArgs e)
        {
            
        }

        private void GetUserList()
        {
            userService = new User_Service();
            List<User> users = userService.GetUsers();
            listViewDisplayForm.Items.Clear();

            foreach (User u in users)
            {
                lvItem = new ListViewItem(u.UserID.ToString(), 0);
                lvItem.SubItems.Add(u.FirstName);
                lvItem.SubItems.Add(u.LastName);
                lvItem.SubItems.Add(u.LoginUsername);
                lvItem.SubItems.Add(u.LoginPassword);
                lvItem.SubItems.Add(u.Role.ToString());

                listViewDisplayForm.Items.Add(lvItem);
            }
        }

        private void butDisplay_Click(object sender, EventArgs e)
        {
            GetUserList();
        }

        private void listViewDisplayForm_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            AddAccountForm addAccount = new AddAccountForm(user);
            addAccount.Show();
            this.Hide();

        }

        private void butLogOut_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();

        }

        private void butBack_Click(object sender, EventArgs e)
        {
            UsersDisplayForm usersDisplayForm = new UsersDisplayForm(user);
            usersDisplayForm.Show();
            this.Hide();
        }
        private void Delete()
        {
            if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                GetUserList();
                userService.RemoveUserAccount(user);
            }
            else
                return;
        }
        private void butDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
