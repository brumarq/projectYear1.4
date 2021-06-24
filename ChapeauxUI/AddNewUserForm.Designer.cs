
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
            this.ptcHeader.Location = new System.Drawing.Point(-2, 1);
            this.ptcHeader.Name = "ptcHeader";
            this.ptcHeader.Size = new System.Drawing.Size(664, 76);
            this.ptcHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcHeader.TabIndex = 7;
            this.ptcHeader.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(16, 80);
            this.lblAddUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(134, 23);
            this.lblAddUser.TabIndex = 1;
            this.lblAddUser.Text = "Add New User";
            // 
            // lblRoleNew
            // 
            this.lblRoleNew.AutoSize = true;
            this.lblRoleNew.Location = new System.Drawing.Point(126, 328);
            this.lblRoleNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoleNew.Name = "lblRoleNew";
            this.lblRoleNew.Size = new System.Drawing.Size(29, 13);
            this.lblRoleNew.TabIndex = 1;
            this.lblRoleNew.Text = "Role";
            // 
            // lblPasswordNew
            // 
            this.lblPasswordNew.AutoSize = true;
            this.lblPasswordNew.Location = new System.Drawing.Point(126, 280);
            this.lblPasswordNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordNew.Name = "lblPasswordNew";
            this.lblPasswordNew.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordNew.TabIndex = 1;
            this.lblPasswordNew.Text = "Password";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(214, 150);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(146, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblUserNameNew
            // 
            this.lblUserNameNew.AutoSize = true;
            this.lblUserNameNew.Location = new System.Drawing.Point(126, 237);
            this.lblUserNameNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserNameNew.Name = "lblUserNameNew";
            this.lblUserNameNew.Size = new System.Drawing.Size(55, 13);
            this.lblUserNameNew.TabIndex = 1;
            this.lblUserNameNew.Text = "Username";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(214, 194);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(146, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastNameNew
            // 
            this.lblLastNameNew.AutoSize = true;
            this.lblLastNameNew.Location = new System.Drawing.Point(126, 198);
            this.lblLastNameNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastNameNew.Name = "lblLastNameNew";
            this.lblLastNameNew.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameNew.TabIndex = 1;
            this.lblLastNameNew.Text = "Last Name";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(214, 233);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(146, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(317, 389);
            this.butAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(115, 26);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(158, 389);
            this.butBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(115, 26);
            this.butBack.TabIndex = 0;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // lblFirstNameNew
            // 
            this.lblFirstNameNew.AutoSize = true;
            this.lblFirstNameNew.Location = new System.Drawing.Point(126, 154);
            this.lblFirstNameNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstNameNew.Name = "lblFirstNameNew";
            this.lblFirstNameNew.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameNew.TabIndex = 1;
            this.lblFirstNameNew.Text = "First Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(214, 277);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(146, 20);
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
            this.cbRole.Location = new System.Drawing.Point(214, 323);
            this.cbRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(146, 21);
            this.cbRole.TabIndex = 35;
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(658, 450);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddNewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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