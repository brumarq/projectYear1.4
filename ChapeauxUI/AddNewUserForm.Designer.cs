
namespace ChapeauxUI
{
    partial class AddNewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUserForm));
            this.ptcHeader = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.lblRoleNew = new System.Windows.Forms.Label();
            this.lblPasswordNew = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblUserNameNew = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastNameNew = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.lblFirstNameNew = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptcHeader
            // 
            this.ptcHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptcHeader.Image = global::ChapeauxUI.Properties.Resources.top_bar;
            this.ptcHeader.Location = new System.Drawing.Point(-3, 1);
            this.ptcHeader.Margin = new System.Windows.Forms.Padding(4);
            this.ptcHeader.Name = "ptcHeader";
            this.ptcHeader.Size = new System.Drawing.Size(886, 94);
            this.ptcHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcHeader.TabIndex = 7;
            this.ptcHeader.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(22, 99);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(168, 28);
            this.lblAddUser.TabIndex = 1;
            this.lblAddUser.Text = "Add New User";
            // 
            // lblRoleNew
            // 
            this.lblRoleNew.AutoSize = true;
            this.lblRoleNew.Location = new System.Drawing.Point(168, 404);
            this.lblRoleNew.Name = "lblRoleNew";
            this.lblRoleNew.Size = new System.Drawing.Size(37, 17);
            this.lblRoleNew.TabIndex = 1;
            this.lblRoleNew.Text = "Role";
            // 
            // lblPasswordNew
            // 
            this.lblPasswordNew.AutoSize = true;
            this.lblPasswordNew.Location = new System.Drawing.Point(168, 344);
            this.lblPasswordNew.Name = "lblPasswordNew";
            this.lblPasswordNew.Size = new System.Drawing.Size(69, 17);
            this.lblPasswordNew.TabIndex = 1;
            this.lblPasswordNew.Text = "Password";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(286, 185);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(194, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblUserNameNew
            // 
            this.lblUserNameNew.AutoSize = true;
            this.lblUserNameNew.Location = new System.Drawing.Point(168, 292);
            this.lblUserNameNew.Name = "lblUserNameNew";
            this.lblUserNameNew.Size = new System.Drawing.Size(73, 17);
            this.lblUserNameNew.TabIndex = 1;
            this.lblUserNameNew.Text = "Username";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(286, 239);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(194, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastNameNew
            // 
            this.lblLastNameNew.AutoSize = true;
            this.lblLastNameNew.Location = new System.Drawing.Point(168, 244);
            this.lblLastNameNew.Name = "lblLastNameNew";
            this.lblLastNameNew.Size = new System.Drawing.Size(76, 17);
            this.lblLastNameNew.TabIndex = 1;
            this.lblLastNameNew.Text = "Last Name";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(286, 287);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(194, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(423, 479);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(153, 32);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(211, 479);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(153, 32);
            this.butBack.TabIndex = 0;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // lblFirstNameNew
            // 
            this.lblFirstNameNew.AutoSize = true;
            this.lblFirstNameNew.Location = new System.Drawing.Point(168, 190);
            this.lblFirstNameNew.Name = "lblFirstNameNew";
            this.lblFirstNameNew.Size = new System.Drawing.Size(76, 17);
            this.lblFirstNameNew.TabIndex = 1;
            this.lblFirstNameNew.Text = "First Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(286, 341);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Manager",
            "Chef",
            "Bartender",
            "Waiter"});
            this.cbRole.Location = new System.Drawing.Point(286, 397);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(194, 24);
            this.cbRole.TabIndex = 35;
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(877, 554);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAddUser);
            this.Controls.Add(this.lblFirstNameNew);
            this.Controls.Add(this.ptcHeader);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.lblRoleNew);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.lblPasswordNew);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastNameNew);
            this.Controls.Add(this.lblUserNameNew);
            this.Controls.Add(this.txtLastName);
            this.Name = "AddNewUserForm";
            this.Text = "AddNewUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.Label lblRoleNew;
        private System.Windows.Forms.Label lblPasswordNew;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblUserNameNew;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastNameNew;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Label lblFirstNameNew;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cbRole;
    }
}