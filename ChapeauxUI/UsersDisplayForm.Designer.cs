
namespace ChapeauxUI
{
    partial class UsersDisplayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersDisplayForm));
            this.listViewDisplayForm = new System.Windows.Forms.ListView();
            this.lvUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butAdd = new System.Windows.Forms.Button();
            this.ptcHeader = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butDelete = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.lblUserOverview = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewDisplayForm
            // 
            this.listViewDisplayForm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listViewDisplayForm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvUserId,
            this.lvFirstName,
            this.lvLastName,
            this.lvUsername,
            this.lvPassword,
            this.lvRole});
            this.listViewDisplayForm.FullRowSelect = true;
            this.listViewDisplayForm.GridLines = true;
            this.listViewDisplayForm.HideSelection = false;
            this.listViewDisplayForm.Location = new System.Drawing.Point(53, 226);
            this.listViewDisplayForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewDisplayForm.MultiSelect = false;
            this.listViewDisplayForm.Name = "listViewDisplayForm";
            this.listViewDisplayForm.Size = new System.Drawing.Size(890, 462);
            this.listViewDisplayForm.TabIndex = 0;
            this.listViewDisplayForm.UseCompatibleStateImageBehavior = false;
            this.listViewDisplayForm.View = System.Windows.Forms.View.Details;
            this.listViewDisplayForm.SelectedIndexChanged += new System.EventHandler(this.listViewDisplayForm_SelectedIndexChanged);
            // 
            // lvUserId
            // 
            this.lvUserId.Text = "User Id";
            this.lvUserId.Width = 40;
            // 
            // lvFirstName
            // 
            this.lvFirstName.Text = "First Name";
            this.lvFirstName.Width = 135;
            // 
            // lvLastName
            // 
            this.lvLastName.Text = "Last Name";
            this.lvLastName.Width = 135;
            // 
            // lvUsername
            // 
            this.lvUsername.Text = "Username";
            this.lvUsername.Width = 135;
            // 
            // lvPassword
            // 
            this.lvPassword.Text = "Password";
            this.lvPassword.Width = 135;
            // 
            // lvRole
            // 
            this.lvRole.Text = "Role";
            this.lvRole.Width = 100;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(622, 720);
            this.butAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(112, 32);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // ptcHeader
            // 
            this.ptcHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptcHeader.Image = global::ChapeauxUI.Properties.Resources.top_bar;
            this.ptcHeader.Location = new System.Drawing.Point(-311, -1);
            this.ptcHeader.Margin = new System.Windows.Forms.Padding(4);
            this.ptcHeader.Name = "ptcHeader";
            this.ptcHeader.Size = new System.Drawing.Size(1494, 94);
            this.ptcHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcHeader.TabIndex = 6;
            this.ptcHeader.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::ChapeauxUI.Properties.Resources.logout_better;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(843, 87);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(154, 66);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.butLogOut_Click);
            // 
            // butBack
            // 
            this.butBack.BackColor = System.Drawing.Color.Transparent;
            this.butBack.BackgroundImage = global::ChapeauxUI.Properties.Resources.btnBack;
            this.butBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butBack.FlatAppearance.BorderSize = 0;
            this.butBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBack.Location = new System.Drawing.Point(3, 77);
            this.butBack.Margin = new System.Windows.Forms.Padding(4);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(127, 66);
            this.butBack.TabIndex = 14;
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(858, 720);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(112, 32);
            this.butDelete.TabIndex = 33;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(740, 720);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(112, 32);
            this.butEdit.TabIndex = 34;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // lblUserOverview
            // 
            this.lblUserOverview.AutoSize = true;
            this.lblUserOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserOverview.Location = new System.Drawing.Point(47, 169);
            this.lblUserOverview.Name = "lblUserOverview";
            this.lblUserOverview.Size = new System.Drawing.Size(212, 32);
            this.lblUserOverview.TabIndex = 35;
            this.lblUserOverview.Text = "User Overview";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(18, 730);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 36;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(124, 730);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 36;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(230, 730);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 36;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(336, 730);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 36;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(18, 707);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 37;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(121, 707);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 37;
            this.lblLastName.Text = "Last Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(227, 707);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 37;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(333, 707);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 37;
            this.lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(439, 707);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(37, 17);
            this.lblRole.TabIndex = 37;
            this.lblRole.Text = "Role";
            // 
            // cbRole
            // 
            this.cbRole.AllowDrop = true;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Manager",
            "Chef",
            "Bartender",
            "Waiter"});
            this.cbRole.Location = new System.Drawing.Point(442, 728);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(121, 24);
            this.cbRole.TabIndex = 38;
            // 
            // UsersDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1010, 816);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblUserOverview);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.listViewDisplayForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.ptcHeader);
            this.Controls.Add(this.butBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UsersDisplayForm";
            this.Text = "UsersDisplayForm";
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDisplayForm;
        private System.Windows.Forms.ColumnHeader lvUserId;
        private System.Windows.Forms.ColumnHeader lvFirstName;
        private System.Windows.Forms.ColumnHeader lvLastName;
        private System.Windows.Forms.ColumnHeader lvRole;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.PictureBox ptcHeader;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader lvUsername;
        private System.Windows.Forms.ColumnHeader lvPassword;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Label lblUserOverview;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbRole;
    }
}