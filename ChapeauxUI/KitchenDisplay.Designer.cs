﻿
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
            this.pnlKitchenDisplay = new System.Windows.Forms.Panel();
            this.btnOrderReadyToBeServed = new System.Windows.Forms.Button();
            this.btnShowOrderDetails = new System.Windows.Forms.Button();
            this.lblStatusOfTheOrder = new System.Windows.Forms.Label();
            this.listViewOrdersDetail = new System.Windows.Forms.ListView();
            this.lblKitchenScreen = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.listViewTableKitchen = new System.Windows.Forms.ListView();
            this.FrameWokrKitchen = new System.Windows.Forms.PictureBox();
            this.pnlBarmanDisplay = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewBarmanOrdersDetail = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewBarmanDisplay = new System.Windows.Forms.ListView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.OrderItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.btnUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlKitchenDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrameWokrKitchen)).BeginInit();
            this.pnlBarmanDisplay.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // pnlKitchenDisplay
            // 
            this.pnlKitchenDisplay.BackColor = System.Drawing.Color.White;
            this.pnlKitchenDisplay.Controls.Add(this.btnOrderReadyToBeServed);
            this.pnlKitchenDisplay.Controls.Add(this.btnShowOrderDetails);
            this.pnlKitchenDisplay.Controls.Add(this.lblStatusOfTheOrder);
            this.pnlKitchenDisplay.Controls.Add(this.listViewOrdersDetail);
            this.pnlKitchenDisplay.Controls.Add(this.lblKitchenScreen);
            this.pnlKitchenDisplay.Controls.Add(this.lblOrders);
            this.pnlKitchenDisplay.Controls.Add(this.listViewTableKitchen);
            this.pnlKitchenDisplay.Controls.Add(this.FrameWokrKitchen);
            this.pnlKitchenDisplay.Location = new System.Drawing.Point(3, 91);
            this.pnlKitchenDisplay.Name = "pnlKitchenDisplay";
            this.pnlKitchenDisplay.Size = new System.Drawing.Size(747, 907);
            this.pnlKitchenDisplay.TabIndex = 36;
            // 
            // btnOrderReadyToBeServed
            // 
            this.btnOrderReadyToBeServed.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderReadyToBeServed.Image")));
            this.btnOrderReadyToBeServed.Location = new System.Drawing.Point(324, 817);
            this.btnOrderReadyToBeServed.Name = "btnOrderReadyToBeServed";
            this.btnOrderReadyToBeServed.Size = new System.Drawing.Size(385, 55);
            this.btnOrderReadyToBeServed.TabIndex = 53;
            this.btnOrderReadyToBeServed.UseVisualStyleBackColor = true;
            // 
            // btnShowOrderDetails
            // 
            this.btnShowOrderDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnShowOrderDetails.Image")));
            this.btnShowOrderDetails.Location = new System.Drawing.Point(48, 817);
            this.btnShowOrderDetails.Name = "btnShowOrderDetails";
            this.btnShowOrderDetails.Size = new System.Drawing.Size(170, 55);
            this.btnShowOrderDetails.TabIndex = 52;
            this.btnShowOrderDetails.UseVisualStyleBackColor = true;
            this.btnShowOrderDetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatusOfTheOrder
            // 
            this.lblStatusOfTheOrder.AutoSize = true;
            this.lblStatusOfTheOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblStatusOfTheOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusOfTheOrder.Location = new System.Drawing.Point(43, 392);
            this.lblStatusOfTheOrder.Name = "lblStatusOfTheOrder";
            this.lblStatusOfTheOrder.Size = new System.Drawing.Size(160, 29);
            this.lblStatusOfTheOrder.TabIndex = 51;
            this.lblStatusOfTheOrder.Text = "Order\'s Detail";
            // 
            // listViewOrdersDetail
            // 
            this.listViewOrdersDetail.HideSelection = false;
            this.listViewOrdersDetail.Location = new System.Drawing.Point(48, 424);
            this.listViewOrdersDetail.Name = "listViewOrdersDetail";
            this.listViewOrdersDetail.Size = new System.Drawing.Size(661, 330);
            this.listViewOrdersDetail.TabIndex = 50;
            this.listViewOrdersDetail.UseCompatibleStateImageBehavior = false;
            // 
            // lblKitchenScreen
            // 
            this.lblKitchenScreen.AutoSize = true;
            this.lblKitchenScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblKitchenScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchenScreen.Location = new System.Drawing.Point(476, 27);
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
            this.listViewTableKitchen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderItemId,
            this.OrderId,
            this.Count,
            this.State,
            this.Comment,
            this.orderDateTime});
            this.listViewTableKitchen.HideSelection = false;
            this.listViewTableKitchen.Location = new System.Drawing.Point(48, 55);
            this.listViewTableKitchen.Name = "listViewTableKitchen";
            this.listViewTableKitchen.Size = new System.Drawing.Size(661, 330);
            this.listViewTableKitchen.TabIndex = 46;
            this.listViewTableKitchen.UseCompatibleStateImageBehavior = false;
            this.listViewTableKitchen.View = System.Windows.Forms.View.Details;
            this.listViewTableKitchen.SelectedIndexChanged += new System.EventHandler(this.listViewTableKitchen_SelectedIndexChanged);
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
            // pnlBarmanDisplay
            // 
            this.pnlBarmanDisplay.Controls.Add(this.panel1);
            this.pnlBarmanDisplay.Location = new System.Drawing.Point(765, 91);
            this.pnlBarmanDisplay.Name = "pnlBarmanDisplay";
            this.pnlBarmanDisplay.Size = new System.Drawing.Size(740, 889);
            this.pnlBarmanDisplay.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listViewBarmanOrdersDetail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listViewBarmanDisplay);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 907);
            this.panel1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(324, 817);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 55);
            this.button1.TabIndex = 53;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(48, 817);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 55);
            this.button2.TabIndex = 52;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Order\'s Detail";
            // 
            // listViewBarmanOrdersDetail
            // 
            this.listViewBarmanOrdersDetail.HideSelection = false;
            this.listViewBarmanOrdersDetail.Location = new System.Drawing.Point(48, 424);
            this.listViewBarmanOrdersDetail.Name = "listViewBarmanOrdersDetail";
            this.listViewBarmanOrdersDetail.Size = new System.Drawing.Size(661, 330);
            this.listViewBarmanOrdersDetail.TabIndex = 50;
            this.listViewBarmanOrdersDetail.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Bar\'s Menu Screen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "Orders";
            // 
            // listViewBarmanDisplay
            // 
            this.listViewBarmanDisplay.HideSelection = false;
            this.listViewBarmanDisplay.Location = new System.Drawing.Point(48, 55);
            this.listViewBarmanDisplay.Name = "listViewBarmanDisplay";
            this.listViewBarmanDisplay.Size = new System.Drawing.Size(661, 330);
            this.listViewBarmanDisplay.TabIndex = 46;
            this.listViewBarmanDisplay.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(15, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(728, 900);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // OrderItemId
            // 
            this.OrderItemId.Text = "OrderItemId";
            this.OrderItemId.Width = 100;
            // 
            // OrderId
            // 
            this.OrderId.Text = "OrderId";
            this.OrderId.Width = 100;
            // 
            // Count
            // 
            this.Count.Text = "Count";
            this.Count.Width = 100;
            // 
            // State
            // 
            this.State.Text = "State";
            this.State.Width = 100;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.Width = 100;
            // 
            // orderDateTime
            // 
            this.orderDateTime.Text = "orderDateTime";
            this.orderDateTime.Width = 100;
            // 
            // KitchenDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1552, 985);
            this.Controls.Add(this.pnlKitchenDisplay);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pnlBarmanDisplay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KitchenDisplay";
            this.Text = "KitchenDisplay";
            this.Load += new System.EventHandler(this.KitchenDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlKitchenDisplay.ResumeLayout(false);
            this.pnlKitchenDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrameWokrKitchen)).EndInit();
            this.pnlBarmanDisplay.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox btnUserInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pnlKitchenDisplay;
        private System.Windows.Forms.Label lblStatusOfTheOrder;
        private System.Windows.Forms.ListView listViewOrdersDetail;
        private System.Windows.Forms.Label lblKitchenScreen;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.ListView listViewTableKitchen;
        private System.Windows.Forms.PictureBox FrameWokrKitchen;
        private System.Windows.Forms.Button btnShowOrderDetails;
        private System.Windows.Forms.Button btnOrderReadyToBeServed;
        private System.Windows.Forms.Panel pnlBarmanDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewBarmanOrdersDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewBarmanDisplay;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColumnHeader OrderItemId;
        private System.Windows.Forms.ColumnHeader OrderId;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.ColumnHeader orderDateTime;
    }
}