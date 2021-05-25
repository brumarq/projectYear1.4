
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butDisplay = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvUserId,
            this.lvFirstName,
            this.lvLastName,
            this.lvRole});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(491, 462);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lvUserId
            // 
            this.lvUserId.Text = "User Id";
            this.lvUserId.Width = 63;
            // 
            // lvFirstName
            // 
            this.lvFirstName.Text = "First Name";
            this.lvFirstName.Width = 135;
            // 
            // lvLastName
            // 
            this.lvLastName.Text = "Last Name";
            this.lvLastName.Width = 129;
            // 
            // lvRole
            // 
            this.lvRole.Text = "Role";
            this.lvRole.Width = 87;
            // 
            // butDisplay
            // 
            this.butDisplay.Location = new System.Drawing.Point(521, 222);
            this.butDisplay.Name = "butDisplay";
            this.butDisplay.Size = new System.Drawing.Size(112, 47);
            this.butDisplay.TabIndex = 1;
            this.butDisplay.Text = "Display";
            this.butDisplay.UseVisualStyleBackColor = true;
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(660, 222);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(112, 47);
            this.butClear.TabIndex = 1;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            // 
            // UsersDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 543);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butDisplay);
            this.Controls.Add(this.listView1);
            this.Name = "UsersDisplayForm";
            this.Text = "UsersDisplayForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lvUserId;
        private System.Windows.Forms.ColumnHeader lvFirstName;
        private System.Windows.Forms.ColumnHeader lvLastName;
        private System.Windows.Forms.ColumnHeader lvRole;
        private System.Windows.Forms.Button butDisplay;
        private System.Windows.Forms.Button butClear;
    }
}