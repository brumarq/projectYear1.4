
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
            this.listViewTableKitchen = new System.Windows.Forms.ListView();
            this.lblOrders = new System.Windows.Forms.Label();
            this.FrameBoxKitchen = new System.Windows.Forms.PictureBox();
            this.lblKitchenScreen = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblStatusOfTheOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrameBoxKitchen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(650, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(76, 16);
            this.lblUserName.TabIndex = 35;
            this.lblUserName.Text = "[username]";
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
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
            // listViewTableKitchen
            // 
            this.listViewTableKitchen.HideSelection = false;
            this.listViewTableKitchen.Location = new System.Drawing.Point(45, 155);
            this.listViewTableKitchen.Name = "listViewTableKitchen";
            this.listViewTableKitchen.Size = new System.Drawing.Size(661, 330);
            this.listViewTableKitchen.TabIndex = 36;
            this.listViewTableKitchen.UseCompatibleStateImageBehavior = false;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(40, 123);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(88, 29);
            this.lblOrders.TabIndex = 37;
            this.lblOrders.Text = "Orders";
            this.lblOrders.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrameBoxKitchen
            // 
            this.FrameBoxKitchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrameBoxKitchen.BackColor = System.Drawing.Color.White;
            this.FrameBoxKitchen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FrameBoxKitchen.BackgroundImage")));
            this.FrameBoxKitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FrameBoxKitchen.Location = new System.Drawing.Point(12, 88);
            this.FrameBoxKitchen.Name = "FrameBoxKitchen";
            this.FrameBoxKitchen.Size = new System.Drawing.Size(728, 893);
            this.FrameBoxKitchen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FrameBoxKitchen.TabIndex = 38;
            this.FrameBoxKitchen.TabStop = false;
            this.FrameBoxKitchen.Click += new System.EventHandler(this.FrameBoxKitchen_Click);
            // 
            // lblKitchenScreen
            // 
            this.lblKitchenScreen.AutoSize = true;
            this.lblKitchenScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblKitchenScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchenScreen.Location = new System.Drawing.Point(493, 111);
            this.lblKitchenScreen.Name = "lblKitchenScreen";
            this.lblKitchenScreen.Size = new System.Drawing.Size(233, 25);
            this.lblKitchenScreen.TabIndex = 39;
            this.lblKitchenScreen.Text = "Kitchen\'s Menu Screen";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(45, 539);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(661, 330);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblStatusOfTheOrder
            // 
            this.lblStatusOfTheOrder.AutoSize = true;
            this.lblStatusOfTheOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblStatusOfTheOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusOfTheOrder.Location = new System.Drawing.Point(40, 507);
            this.lblStatusOfTheOrder.Name = "lblStatusOfTheOrder";
            this.lblStatusOfTheOrder.Size = new System.Drawing.Size(213, 29);
            this.lblStatusOfTheOrder.TabIndex = 41;
            this.lblStatusOfTheOrder.Text = "Status of the Order";
            this.lblStatusOfTheOrder.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // KitchenDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.lblStatusOfTheOrder);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblKitchenScreen);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.listViewTableKitchen);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.FrameBoxKitchen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KitchenDisplay";
            this.Text = "KitchenDisplay";
            this.Load += new System.EventHandler(this.KitchenDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrameBoxKitchen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox btnUserInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListView listViewTableKitchen;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.PictureBox FrameBoxKitchen;
        private System.Windows.Forms.Label lblKitchenScreen;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblStatusOfTheOrder;
    }
}