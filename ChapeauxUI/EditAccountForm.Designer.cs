
namespace ChapeauxUI
{
    partial class EditAccountForm
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
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.rbChef = new System.Windows.Forms.RadioButton();
            this.rbBartender = new System.Windows.Forms.RadioButton();
            this.rbWaiter = new System.Windows.Forms.RadioButton();
            this.butEditUserAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(102, 98);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(102, 152);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(102, 207);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(102, 264);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(313, 93);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 22);
            this.txtFirstname.TabIndex = 5;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(313, 147);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 22);
            this.txtLastname.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(313, 202);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(313, 259);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(102, 313);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(37, 17);
            this.lblRole.TabIndex = 9;
            this.lblRole.Text = "Role";
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Location = new System.Drawing.Point(313, 311);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(85, 21);
            this.rbManager.TabIndex = 10;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Manager";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // rbChef
            // 
            this.rbChef.AutoSize = true;
            this.rbChef.Location = new System.Drawing.Point(416, 311);
            this.rbChef.Name = "rbChef";
            this.rbChef.Size = new System.Drawing.Size(58, 21);
            this.rbChef.TabIndex = 11;
            this.rbChef.TabStop = true;
            this.rbChef.Text = "Chef";
            this.rbChef.UseVisualStyleBackColor = true;
            // 
            // rbBartender
            // 
            this.rbBartender.AutoSize = true;
            this.rbBartender.Location = new System.Drawing.Point(498, 311);
            this.rbBartender.Name = "rbBartender";
            this.rbBartender.Size = new System.Drawing.Size(92, 21);
            this.rbBartender.TabIndex = 12;
            this.rbBartender.TabStop = true;
            this.rbBartender.Text = "Bartender";
            this.rbBartender.UseVisualStyleBackColor = true;
            // 
            // rbWaiter
            // 
            this.rbWaiter.AutoSize = true;
            this.rbWaiter.Location = new System.Drawing.Point(596, 311);
            this.rbWaiter.Name = "rbWaiter";
            this.rbWaiter.Size = new System.Drawing.Size(70, 21);
            this.rbWaiter.TabIndex = 13;
            this.rbWaiter.TabStop = true;
            this.rbWaiter.Text = "Waiter";
            this.rbWaiter.UseVisualStyleBackColor = true;
            // 
            // butEditUserAccount
            // 
            this.butEditUserAccount.Location = new System.Drawing.Point(577, 367);
            this.butEditUserAccount.Name = "butEditUserAccount";
            this.butEditUserAccount.Size = new System.Drawing.Size(152, 37);
            this.butEditUserAccount.TabIndex = 14;
            this.butEditUserAccount.Text = "Edit User Account";
            this.butEditUserAccount.UseVisualStyleBackColor = true;
            this.butEditUserAccount.Click += new System.EventHandler(this.butEditUserAccount_Click);
            // 
            // EditAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butEditUserAccount);
            this.Controls.Add(this.rbWaiter);
            this.Controls.Add(this.rbBartender);
            this.Controls.Add(this.rbChef);
            this.Controls.Add(this.rbManager);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "EditAccountForm";
            this.Text = "EditAccountForm";
            this.Load += new System.EventHandler(this.EditAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.RadioButton rbChef;
        private System.Windows.Forms.RadioButton rbBartender;
        private System.Windows.Forms.RadioButton rbWaiter;
        private System.Windows.Forms.Button butEditUserAccount;
    }
}