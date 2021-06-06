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
        //User user = new User();
        //ListViewItem lvItem;
        //ListViewItem lvItem;
        //private ListView listView1;
        //
        //User currUser = new User();

        public UsersDisplayForm(User currUser)
        {
            InitializeComponent();
            //this.currUser = currUser;
        }
        private void UsersDisplayForm_Load(object sender, EventArgs e)
        {
            //User_Service user_Service = new User_Service();
            //currUser = user_Service.DisplayUsers();
            //
            //
            //if (string.IsNullOrEmpty(lvUserId.Text) || string.IsNullOrEmpty(lvFirstName.Text)
            //    || string.IsNullOrEmpty(lvLastName.Text) || string.IsNullOrEmpty(lvUsername.Text) || string.IsNullOrEmpty(lvPassword.Text)
            //    || string.IsNullOrEmpty(lvRole.Text))
            //    return;
            //
            //lvItem = new ListViewItem(lvUserId.Text);
            //lvItem.SubItems.Add(lvFirstName.Text);
            //lvItem.SubItems.Add(lvLastName.Text);
            //lvItem.SubItems.Add(lvUsername.Text);
            //lvItem.SubItems.Add(lvPassword.Text);
            //lvItem.SubItems.Add(lvRole.Text);
            //
            //// Create ListView items to add to the control.
            //ListViewItem listViewItem1 = new ListViewItem(new string[] { "Banana", "a", "b", "c" }, -1, Color.Empty, Color.Yellow, null);
            //ListViewItem listViewItem2 = new ListViewItem(new string[] { "Cherry", "v", "g", "t" }, -1, Color.Empty, Color.Red, new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((System.Byte)(0))));
            //ListViewItem listViewItem3 = new ListViewItem(new string[] { "Apple", "h", "j", "n" }, -1, Color.Empty, Color.Lime, null);
            //ListViewItem listViewItem4 = new ListViewItem(new string[] { "Pear", "y", "u", "i" }, -1, Color.Empty, Color.FromArgb(((System.Byte)(192)), ((System.Byte)(128)), ((System.Byte)(156))), null);
            //
            ////Initialize the ListView control and add columns to it.
            //this.listView1 = new ListView();
            //
            //// Set the initial sorting type for the ListView.
            //this.listView1.Sorting = SortOrder.None;
            //// Disable automatic sorting to enable manual sorting.
            //this.listView1.View = View.Details;
            //// Add columns and set their text.
            //this.listView1.Columns.Add(new ColumnHeader());
            //this.listView1.Columns[0].Text = "userID";
            //this.listView1.Columns[0].Width = 100;
            //listView1.Columns.Add(new ColumnHeader());
            //listView1.Columns[1].Text = "firstName";
            //listView1.Columns.Add(new ColumnHeader());
            //listView1.Columns[2].Text = "lastName";
            //listView1.Columns.Add(new ColumnHeader());
            //listView1.Columns[3].Text = "userName";
            //listView1.Columns.Add(new ColumnHeader());
            //listView1.Columns[3].Text = "[password]";
            //listView1.Columns.Add(new ColumnHeader());
            //listView1.Columns[3].Text = "role";
            //// Suspend control logic until form is done configuring form.
            //this.SuspendLayout();
            //// Add Items to the ListView control.
            //this.listView1.Items.AddRange(new ListViewItem[] {listViewItem1,
            //    listViewItem2,
            //    listViewItem3,
            //    listViewItem4});
            //// Set the location and size of the ListView control.
            //this.listView1.Location = new Point(10, 10);
            //this.listView1.Name = "listView1";
            //this.listView1.Size = new Size(300, 100);
            //this.listView1.TabIndex = 0;
            //// Enable editing of the items in the ListView.
            //this.listView1.LabelEdit = true;
            //
            //
            //// Initialize the form.
            //this.ClientSize = new Size(400, 400);
            //this.Controls.AddRange(new Control[] { this.listView1 });
            //this.Name = "ListViewSortForm";
            //this.Text = "Sorted ListView Control";
            
        }

        private void butDisplay_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(lvUserId.Text) || string.IsNullOrEmpty(lvFirstName.Text)
            //    || string.IsNullOrEmpty(lvLastName.Text) || string.IsNullOrEmpty(lvUsername.Text) || string.IsNullOrEmpty(lvPassword.Text)
            //    || string.IsNullOrEmpty(lvRole.Text))
            //   return;
            //
            //ListViewItem item = new ListViewItem(lvUserId.Text);
            //item.SubItems.Add(lvFirstName.Text);
            //item.SubItems.Add(lvLastName.Text);
            //item.SubItems.Add(lvUsername.Text);
            //item.SubItems.Add(lvPassword.Text);
            //item.SubItems.Add(lvRole.Text);
            //
            //listView1.View = View.Details;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
