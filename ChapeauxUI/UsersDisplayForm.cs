using System;
using System.Windows.Forms;
using ChapeauxModel;
using System.Collections.Generic;
using System.Drawing;
using ChapeauxLogic;

namespace ChapeauxUI
{
    public partial class UsersDisplayForm : Form
    {
        User user = new User();
        //ListViewItem lvItem;

        public UsersDisplayForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void butDisplay_Click(object sender, EventArgs e)
        {
            //User_Service userService = new User_Service();
            //
            //
            //List<ListViewItem> listViewItems = new List<ListViewItem>();
            //
            //User getUsers = new User();
            //List<User> user = userService.GetUsers(getUsers);
            //
            ///* listViewDisplayForm.Columns.Add("userID");
            // listViewDisplayForm.Columns.Add("firstName");
            // listViewDisplayForm.Columns.Add("lastName");
            // listViewDisplayForm.Columns.Add("role");*/
            //
            ////listViewDisplayForm.View = View.Details;
            //
            //ListViewItem item = new ListViewItem();
            //item.SubItems.Add(lvUserId);
            //
            //for (int i = 0; i < listViewDisplayForm.Columns.Count; i++)
            //{
            //    lvItem = new ListViewItem();
            //}
            //foreach (ListViewItem item in listViewDisplayForm.Items)
            //{
            //    listViewDisplayForm.Items.Add(item);
            //    listViewDisplayForm.Columns.Add("userID");
            //}
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
