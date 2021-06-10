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


        public UsersDisplayForm(User currUser)
        {
            InitializeComponent();
            user = currUser;
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
            if (listViewDisplayForm.SelectedItems.Count == 1)
            {
                user.UserID = int.Parse(listViewDisplayForm.SelectedItems[0].Text);
                // fetch data for that user
            }
        }
        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
