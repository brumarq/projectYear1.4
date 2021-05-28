
namespace ChapeauxUI
{
    partial class KitchenDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenDisplay));
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnUserInfo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrderReadyToBeServed = new System.Windows.Forms.PictureBox();
            this.btnSwitchToBarman = new System.Windows.Forms.PictureBox();
            this.btnEditOrder = new System.Windows.Forms.PictureBox();
            this.btnAlertWaiter = new System.Windows.Forms.PictureBox();
            this.lblStatusOfTheOrder = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblKitchenScreen = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.listViewTableKitchen = new System.Windows.Forms.ListView();
            this.FrameWokrKitchen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrderReadyToBeServed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSwitchToBarman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlertWaiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrameWokrKitchen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(650, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(76, 16);
            this.lblUserName.TabIndex = 35;
            this.lblUserName.Text = "[username]";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btnUserInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnUserInfo.Image")));
            this.btnUserInfo.Location = new System.Drawing.Point(612, 22);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(33, 33);
            this.btnUserInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUserInfo.TabIndex = 34;
            this.btnUserInfo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(-9, -2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(770, 84);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOrderReadyToBeServed);
            this.panel1.Controls.Add(this.btnSwitchToBarman);
            this.panel1.Controls.Add(this.btnEditOrder);
            this.panel1.Controls.Add(this.btnAlertWaiter);
            this.panel1.Controls.Add(this.lblStatusOfTheOrder);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.lblKitchenScreen);
            this.panel1.Controls.Add(this.lblOrders);
            this.panel1.Controls.Add(this.listViewTableKitchen);
            this.panel1.Controls.Add(this.FrameWokrKitchen);
            this.panel1.Location = new System.Drawing.Point(2, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 907);
            this.panel1.TabIndex = 36;
            // 
            // btnOrderReadyToBeServed
            // 
            this.btnOrderReadyToBeServed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnOrderReadyToBeServed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderReadyToBeServed.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderReadyToBeServed.Image")));
            this.btnOrderReadyToBeServed.Location = new System.Drawing.Point(310, 820);
            this.btnOrderReadyToBeServed.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrderReadyToBeServed.Name = "btnOrderReadyToBeServed";
            this.btnOrderReadyToBeServed.Size = new System.Drawing.Size(419, 74);
            this.btnOrderReadyToBeServed.TabIndex = 55;
            this.btnOrderReadyToBeServed.TabStop = false;
            // 
            // btnSwitchToBarman
            // 
            this.btnSwitchToBarman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSwitchToBarman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchToBarman.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchToBarman.Image")));
            this.btnSwitchToBarman.Location = new System.Drawing.Point(441, 757);
            this.btnSwitchToBarman.Margin = new System.Windows.Forms.Padding(0);
            this.btnSwitchToBarman.Name = "btnSwitchToBarman";
            this.btnSwitchToBarman.Size = new System.Drawing.Size(186, 63);
            this.btnSwitchToBarman.TabIndex = 54;
            this.btnSwitchToBarman.TabStop = false;
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnEditOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnEditOrder.Image")));
            this.btnEditOrder.Location = new System.Drawing.Point(245, 757);
            this.btnEditOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(186, 63);
            this.btnEditOrder.TabIndex = 53;
            this.btnEditOrder.TabStop = false;
            // 
            // btnAlertWaiter
            // 
            this.btnAlertWaiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAlertWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlertWaiter.Image = ((System.Drawing.Image)(resources.GetObject("btnAlertWaiter.Image")));
            this.btnAlertWaiter.Location = new System.Drawing.Point(48, 757);
            this.btnAlertWaiter.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlertWaiter.Name = "btnAlertWaiter";
            this.btnAlertWaiter.Size = new System.Drawing.Size(186, 63);
            this.btnAlertWaiter.TabIndex = 52;
            this.btnAlertWaiter.TabStop = false;
            // 
            // lblStatusOfTheOrder
            // 
            this.lblStatusOfTheOrder.AutoSize = true;
            this.lblStatusOfTheOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblStatusOfTheOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusOfTheOrder.Location = new System.Drawing.Point(43, 392);
            this.lblStatusOfTheOrder.Name = "lblStatusOfTheOrder";
            this.lblStatusOfTheOrder.Size = new System.Drawing.Size(213, 29);
            this.lblStatusOfTheOrder.TabIndex = 51;
            this.lblStatusOfTheOrder.Text = "Status of the Order";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(48, 424);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(661, 330);
            this.listView1.TabIndex = 50;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblKitchenScreen
            // 
            this.lblKitchenScreen.AutoSize = true;
            this.lblKitchenScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblKitchenScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchenScreen.Location = new System.Drawing.Point(496, 27);
            this.lblKitchenScreen.Name = "lblKitchenScreen";
            this.lblKitchenScreen.Size = new System.Drawing.Size(233, 25);
            this.lblKitchenScreen.TabIndex = 49;
            this.lblKitchenScreen.Text = "Kitchen\'s Menu Screen";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(43, 23);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(88, 29);
            this.lblOrders.TabIndex = 47;
            this.lblOrders.Text = "Orders";
            // 
            // listViewTableKitchen
            // 
            this.listViewTableKitchen.HideSelection = false;
            this.listViewTableKitchen.Location = new System.Drawing.Point(48, 55);
            this.listViewTableKitchen.Name = "listViewTableKitchen";
            this.listViewTableKitchen.Size = new System.Drawing.Size(661, 330);
            this.listViewTableKitchen.TabIndex = 46;
            this.listViewTableKitchen.UseCompatibleStateImageBehavior = false;
            // 
            // FrameWokrKitchen
            // 
            this.FrameWokrKitchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrameWokrKitchen.BackColor = System.Drawing.Color.White;
            this.FrameWokrKitchen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FrameWokrKitchen.BackgroundImage")));
            this.FrameWokrKitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FrameWokrKitchen.Location = new System.Drawing.Point(15, 4);
            this.FrameWokrKitchen.Name = "FrameWokrKitchen";
            this.FrameWokrKitchen.Size = new System.Drawing.Size(728, 900);
            this.FrameWokrKitchen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FrameWokrKitchen.TabIndex = 48;
            this.FrameWokrKitchen.TabStop = false;
            // 
            // KitchenDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KitchenDisplay";
            this.Text = "KitchenDisplay";
            this.Load += new System.EventHandler(this.KitchenDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrderReadyToBeServed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSwitchToBarman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlertWaiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrameWokrKitchen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox btnUserInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnOrderReadyToBeServed;
        private System.Windows.Forms.PictureBox btnSwitchToBarman;
        private System.Windows.Forms.PictureBox btnEditOrder;
        private System.Windows.Forms.PictureBox btnAlertWaiter;
        private System.Windows.Forms.Label lblStatusOfTheOrder;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblKitchenScreen;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.ListView listViewTableKitchen;
        private System.Windows.Forms.PictureBox FrameWokrKitchen;
    }
}