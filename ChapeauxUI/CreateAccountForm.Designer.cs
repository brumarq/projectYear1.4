
namespace ChapeauxUI
{
    partial class CreateAccountForm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cbManager = new System.Windows.Forms.CheckBox();
            this.cbChef = new System.Windows.Forms.CheckBox();
            this.cbBartender = new System.Windows.Forms.CheckBox();
            this.cbWaiter = new System.Windows.Forms.CheckBox();
            this.butAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(85, 227);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(85, 285);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(85, 341);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(85, 400);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(85, 462);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(37, 17);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(242, 338);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 22);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(242, 397);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 22);
            this.textBox4.TabIndex = 1;
            // 
            // cbManager
            // 
            this.cbManager.AutoSize = true;
            this.cbManager.Location = new System.Drawing.Point(236, 460);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(86, 21);
            this.cbManager.TabIndex = 2;
            this.cbManager.Text = "Manager";
            this.cbManager.UseVisualStyleBackColor = true;
            // 
            // cbChef
            // 
            this.cbChef.AutoSize = true;
            this.cbChef.Location = new System.Drawing.Point(328, 461);
            this.cbChef.Name = "cbChef";
            this.cbChef.Size = new System.Drawing.Size(59, 21);
            this.cbChef.TabIndex = 2;
            this.cbChef.Text = "Chef";
            this.cbChef.UseVisualStyleBackColor = true;
            // 
            // cbBartender
            // 
            this.cbBartender.AutoSize = true;
            this.cbBartender.Location = new System.Drawing.Point(393, 461);
            this.cbBartender.Name = "cbBartender";
            this.cbBartender.Size = new System.Drawing.Size(93, 21);
            this.cbBartender.TabIndex = 2;
            this.cbBartender.Text = "Bartender";
            this.cbBartender.UseVisualStyleBackColor = true;
            // 
            // cbWaiter
            // 
            this.cbWaiter.AutoSize = true;
            this.cbWaiter.Location = new System.Drawing.Point(492, 461);
            this.cbWaiter.Name = "cbWaiter";
            this.cbWaiter.Size = new System.Drawing.Size(71, 21);
            this.cbWaiter.TabIndex = 2;
            this.cbWaiter.Text = "Waiter";
            this.cbWaiter.UseVisualStyleBackColor = true;
            // 
            // butAddUser
            // 
            this.butAddUser.Location = new System.Drawing.Point(492, 500);
            this.butAddUser.Name = "butAddUser";
            this.butAddUser.Size = new System.Drawing.Size(142, 38);
            this.butAddUser.TabIndex = 3;
            this.butAddUser.Text = "Add User Account";
            this.butAddUser.UseVisualStyleBackColor = true;
            this.butAddUser.Click += new System.EventHandler(this.butAddUser_Click);
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 977);
            this.Controls.Add(this.butAddUser);
            this.Controls.Add(this.cbWaiter);
            this.Controls.Add(this.cbBartender);
            this.Controls.Add(this.cbChef);
            this.Controls.Add(this.cbManager);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "CreateAccountForm";
            this.Text = "CreateAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox cbManager;
        private System.Windows.Forms.CheckBox cbChef;
        private System.Windows.Forms.CheckBox cbBartender;
        private System.Windows.Forms.CheckBox cbWaiter;
        private System.Windows.Forms.Button butAddUser;
    }
}