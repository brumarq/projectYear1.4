
namespace ChapeauxUI
{
    partial class CreateUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserForm));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.butCreateUserAccount = new System.Windows.Forms.Button();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.rbChef = new System.Windows.Forms.RadioButton();
            this.rbBartender = new System.Windows.Forms.RadioButton();
            this.rbWaiter = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.ptcHeader = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblFirstName.Location = new System.Drawing.Point(186, 262);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 22);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblLastName.Location = new System.Drawing.Point(186, 325);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 22);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblUsername.Location = new System.Drawing.Point(186, 388);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 22);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblPassword.Location = new System.Drawing.Point(186, 445);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 22);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // butCreateUserAccount
            // 
            this.butCreateUserAccount.AutoSize = true;
            this.butCreateUserAccount.Location = new System.Drawing.Point(765, 579);
            this.butCreateUserAccount.Name = "butCreateUserAccount";
            this.butCreateUserAccount.Size = new System.Drawing.Size(201, 40);
            this.butCreateUserAccount.TabIndex = 1;
            this.butCreateUserAccount.Text = "Create User Account";
            this.butCreateUserAccount.UseVisualStyleBackColor = true;
            this.butCreateUserAccount.Click += new System.EventHandler(this.butCreateUserAccount_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(370, 259);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(199, 27);
            this.txtFirstname.TabIndex = 2;
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(370, 322);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(199, 27);
            this.txtLastname.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(370, 385);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(199, 27);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(370, 442);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(199, 27);
            this.txtPassword.TabIndex = 2;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblRole.Location = new System.Drawing.Point(186, 506);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(41, 22);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Role";
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManager.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbManager.Location = new System.Drawing.Point(372, 502);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(92, 26);
            this.rbManager.TabIndex = 4;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Manager";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // rbChef
            // 
            this.rbChef.AutoSize = true;
            this.rbChef.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChef.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbChef.Location = new System.Drawing.Point(470, 502);
            this.rbChef.Name = "rbChef";
            this.rbChef.Size = new System.Drawing.Size(63, 26);
            this.rbChef.TabIndex = 5;
            this.rbChef.TabStop = true;
            this.rbChef.Text = "Chef";
            this.rbChef.UseVisualStyleBackColor = true;
            // 
            // rbBartender
            // 
            this.rbBartender.AutoSize = true;
            this.rbBartender.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBartender.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbBartender.Location = new System.Drawing.Point(539, 502);
            this.rbBartender.Name = "rbBartender";
            this.rbBartender.Size = new System.Drawing.Size(100, 26);
            this.rbBartender.TabIndex = 6;
            this.rbBartender.TabStop = true;
            this.rbBartender.Text = "Bartender";
            this.rbBartender.UseVisualStyleBackColor = true;
            this.rbBartender.CheckedChanged += new System.EventHandler(this.rbBartender_CheckedChanged);
            // 
            // rbWaiter
            // 
            this.rbWaiter.AutoSize = true;
            this.rbWaiter.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWaiter.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbWaiter.Location = new System.Drawing.Point(645, 502);
            this.rbWaiter.Name = "rbWaiter";
            this.rbWaiter.Size = new System.Drawing.Size(75, 26);
            this.rbWaiter.TabIndex = 7;
            this.rbWaiter.TabStop = true;
            this.rbWaiter.Text = "Waiter";
            this.rbWaiter.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::ChapeauxUI.Properties.Resources.logout_better;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(853, 82);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(154, 66);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblUserFullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.ForeColor = System.Drawing.Color.White;
            this.lblUserFullName.Location = new System.Drawing.Point(618, 22);
            this.lblUserFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserFullName.Size = new System.Drawing.Size(330, 30);
            this.lblUserFullName.TabIndex = 12;
            this.lblUserFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ptcHeader
            // 
            this.ptcHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptcHeader.Image = global::ChapeauxUI.Properties.Resources.top_bar;
            this.ptcHeader.Location = new System.Drawing.Point(-254, -7);
            this.ptcHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptcHeader.Name = "ptcHeader";
            this.ptcHeader.Size = new System.Drawing.Size(1494, 94);
            this.ptcHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcHeader.TabIndex = 6;
            this.ptcHeader.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ChapeauxUI.Properties.Resources.btnBack;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 66);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1010, 717);
            this.Controls.Add(this.rbWaiter);
            this.Controls.Add(this.rbBartender);
            this.Controls.Add(this.rbChef);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbManager);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserFullName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.butCreateUserAccount);
            this.Controls.Add(this.ptcHeader);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "CreateUserForm";
            this.Text = "CreateUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button butCreateUserAccount;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.RadioButton rbChef;
        private System.Windows.Forms.RadioButton rbBartender;
        private System.Windows.Forms.RadioButton rbWaiter;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.PictureBox ptcHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}