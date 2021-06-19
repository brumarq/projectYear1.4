
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butDelete = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
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
            this.butUserOverview = new System.Windows.Forms.Button();
            this.butMenuItemOverview = new System.Windows.Forms.Button();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
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
            this.listViewDisplayForm.Location = new System.Drawing.Point(37, 134);
            this.listViewDisplayForm.Margin = new System.Windows.Forms.Padding(2);
            this.listViewDisplayForm.MultiSelect = false;
            this.listViewDisplayForm.Name = "listViewDisplayForm";
            this.listViewDisplayForm.Size = new System.Drawing.Size(668, 376);
            this.listViewDisplayForm.TabIndex = 0;
            this.listViewDisplayForm.UseCompatibleStateImageBehavior = false;
            this.listViewDisplayForm.View = System.Windows.Forms.View.Details;
            this.listViewDisplayForm.SelectedIndexChanged += new System.EventHandler(this.listViewDisplayForm_SelectedIndexChanged);
            // 
            // lvUserId
            // 
            this.lvUserId.Text = "User Id";
            this.lvUserId.Width = 47;
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
            this.butAdd.Location = new System.Drawing.Point(550, 574);
            this.butAdd.Margin = new System.Windows.Forms.Padding(2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(84, 26);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Add new User";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // ptcHeader
            // 
            this.ptcHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptcHeader.Image = global::ChapeauxUI.Properties.Resources.top_bar;
            this.ptcHeader.Location = new System.Drawing.Point(-233, -1);
            this.ptcHeader.Name = "ptcHeader";
            this.ptcHeader.Size = new System.Drawing.Size(1120, 76);
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
            this.btnLogout.Location = new System.Drawing.Point(632, 71);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 54);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.butLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(647, 570);
            this.butDelete.Margin = new System.Windows.Forms.Padding(2);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(84, 26);
            this.butDelete.TabIndex = 33;
            this.butDelete.Text = "Remove User";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(431, 575);
            this.butEdit.Margin = new System.Windows.Forms.Padding(2);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(101, 26);
            this.butEdit.TabIndex = 34;
            this.butEdit.Text = "Confirm Changes";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(17, 575);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(76, 20);
            this.txtFirstName.TabIndex = 36;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(97, 575);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(76, 20);
            this.txtLastName.TabIndex = 36;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(176, 575);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(76, 20);
            this.txtUsername.TabIndex = 36;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(256, 575);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(76, 20);
            this.txtPassword.TabIndex = 36;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(17, 557);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 37;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(94, 557);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 37;
            this.lblLastName.Text = "Last Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(174, 557);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 37;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(254, 557);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 37;
            this.lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(333, 557);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
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
            this.cbRole.Location = new System.Drawing.Point(335, 574);
            this.cbRole.Margin = new System.Windows.Forms.Padding(2);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(92, 21);
            this.cbRole.TabIndex = 38;
            // 
            // butUserOverview
            // 
            this.butUserOverview.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUserOverview.ForeColor = System.Drawing.Color.Black;
            this.butUserOverview.Location = new System.Drawing.Point(14, 79);
            this.butUserOverview.Margin = new System.Windows.Forms.Padding(2);
            this.butUserOverview.Name = "butUserOverview";
            this.butUserOverview.Size = new System.Drawing.Size(175, 28);
            this.butUserOverview.TabIndex = 39;
            this.butUserOverview.Text = "User Overview";
            this.butUserOverview.UseVisualStyleBackColor = true;
            this.butUserOverview.Click += new System.EventHandler(this.butUserOverview_Click);
            // 
            // butMenuItemOverview
            // 
            this.butMenuItemOverview.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMenuItemOverview.Location = new System.Drawing.Point(176, 79);
            this.butMenuItemOverview.Margin = new System.Windows.Forms.Padding(2);
            this.butMenuItemOverview.Name = "butMenuItemOverview";
            this.butMenuItemOverview.Size = new System.Drawing.Size(205, 28);
            this.butMenuItemOverview.TabIndex = 39;
            this.butMenuItemOverview.Text = "Menu Item Overview";
            this.butMenuItemOverview.UseVisualStyleBackColor = true;
            this.butMenuItemOverview.Click += new System.EventHandler(this.butMenuItemOverview_Click);
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblUserFullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.ForeColor = System.Drawing.Color.White;
            this.lblUserFullName.Location = new System.Drawing.Point(399, 17);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserFullName.Size = new System.Drawing.Size(283, 24);
            this.lblUserFullName.TabIndex = 41;
            this.lblUserFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pctLogo.Image = global::ChapeauxUI.Properties.Resources.Capture;
            this.pctLogo.Location = new System.Drawing.Point(685, 6);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(46, 46);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 40;
            this.pctLogo.TabStop = false;
            // 
            // UsersDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(758, 663);
            this.Controls.Add(this.lblUserFullName);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.butMenuItemOverview);
            this.Controls.Add(this.butUserOverview);
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
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.listViewDisplayForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.ptcHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsersDisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersDisplayForm";
            this.Load += new System.EventHandler(this.UsersDisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader lvUsername;
        private System.Windows.Forms.ColumnHeader lvPassword;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butEdit;
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
        private System.Windows.Forms.Button butUserOverview;
        private System.Windows.Forms.Button butMenuItemOverview;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}