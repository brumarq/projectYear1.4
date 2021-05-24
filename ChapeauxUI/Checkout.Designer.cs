
namespace ChapeauxUI
{
    partial class CheckoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnToPayment = new System.Windows.Forms.PictureBox();
            this.frameBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewCheckoutOrder = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVATHigh = new System.Windows.Forms.Label();
            this.lblVATLow = new System.Windows.Forms.Label();
            this.lblTipAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.txtTipAmount = new System.Windows.Forms.TextBox();
            this.txtToPay = new System.Windows.Forms.TextBox();
            this.lblVATLowResult = new System.Windows.Forms.Label();
            this.lblVATHighResult = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnUserInfo = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnClearTip = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.pnlCheckout = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearTip)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.pnlCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnToPayment
            // 
            this.btnToPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnToPayment.Image")));
            this.btnToPayment.Location = new System.Drawing.Point(552, 0);
            this.btnToPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnToPayment.Name = "btnToPayment";
            this.btnToPayment.Size = new System.Drawing.Size(176, 69);
            this.btnToPayment.TabIndex = 5;
            this.btnToPayment.TabStop = false;
            // 
            // frameBox
            // 
            this.frameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frameBox.BackgroundImage")));
            this.frameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frameBox.Location = new System.Drawing.Point(0, 81);
            this.frameBox.Name = "frameBox";
            this.frameBox.Size = new System.Drawing.Size(728, 817);
            this.frameBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frameBox.TabIndex = 7;
            this.frameBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Checkout Order";
            // 
            // listViewCheckoutOrder
            // 
            this.listViewCheckoutOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCheckoutOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewCheckoutOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Product,
            this.Qty,
            this.UnitPrice});
            this.listViewCheckoutOrder.HideSelection = false;
            this.listViewCheckoutOrder.Location = new System.Drawing.Point(46, 133);
            this.listViewCheckoutOrder.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.listViewCheckoutOrder.Name = "listViewCheckoutOrder";
            this.listViewCheckoutOrder.Size = new System.Drawing.Size(632, 473);
            this.listViewCheckoutOrder.TabIndex = 9;
            this.listViewCheckoutOrder.UseCompatibleStateImageBehavior = false;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Product
            // 
            this.Product.Text = "Product";
            // 
            // Qty
            // 
            this.Qty.Text = "Qty.";
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Unit Price";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(224, 25);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "TOTAL (INCL. VAT):";
            // 
            // lblVATHigh
            // 
            this.lblVATHigh.AutoSize = true;
            this.lblVATHigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblVATHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVATHigh.Location = new System.Drawing.Point(3, 28);
            this.lblVATHigh.Name = "lblVATHigh";
            this.lblVATHigh.Size = new System.Drawing.Size(186, 25);
            this.lblVATHigh.TabIndex = 11;
            this.lblVATHigh.Text = "VAT HIGH (21%):";
            // 
            // lblVATLow
            // 
            this.lblVATLow.AutoSize = true;
            this.lblVATLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblVATLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVATLow.Location = new System.Drawing.Point(3, 54);
            this.lblVATLow.Name = "lblVATLow";
            this.lblVATLow.Size = new System.Drawing.Size(172, 25);
            this.lblVATLow.TabIndex = 12;
            this.lblVATLow.Text = "VAT LOW (9%):";
            // 
            // lblTipAmount
            // 
            this.lblTipAmount.AutoSize = true;
            this.lblTipAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblTipAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipAmount.Location = new System.Drawing.Point(3, 106);
            this.lblTipAmount.Name = "lblTipAmount";
            this.lblTipAmount.Size = new System.Drawing.Size(153, 25);
            this.lblTipAmount.TabIndex = 13;
            this.lblTipAmount.Text = "TIP AMOUNT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "TO PAY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "€";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "€";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(220, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "€";
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblTotalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResult.Location = new System.Drawing.Point(242, 3);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(88, 26);
            this.lblTotalResult.TabIndex = 24;
            this.lblTotalResult.Text = "126.90";
            this.lblTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTipAmount
            // 
            this.txtTipAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipAmount.Location = new System.Drawing.Point(249, 103);
            this.txtTipAmount.Name = "txtTipAmount";
            this.txtTipAmount.Size = new System.Drawing.Size(81, 30);
            this.txtTipAmount.TabIndex = 25;
            this.txtTipAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtToPay
            // 
            this.txtToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToPay.Location = new System.Drawing.Point(249, 170);
            this.txtToPay.Name = "txtToPay";
            this.txtToPay.Size = new System.Drawing.Size(81, 30);
            this.txtToPay.TabIndex = 26;
            this.txtToPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVATLowResult
            // 
            this.lblVATLowResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblVATLowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVATLowResult.Location = new System.Drawing.Point(249, 54);
            this.lblVATLowResult.Name = "lblVATLowResult";
            this.lblVATLowResult.Size = new System.Drawing.Size(81, 26);
            this.lblVATLowResult.TabIndex = 27;
            this.lblVATLowResult.Text = "10.24";
            this.lblVATLowResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVATHighResult
            // 
            this.lblVATHighResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblVATHighResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVATHighResult.Location = new System.Drawing.Point(249, 28);
            this.lblVATHighResult.Name = "lblVATHighResult";
            this.lblVATHighResult.Size = new System.Drawing.Size(81, 26);
            this.lblVATHighResult.TabIndex = 28;
            this.lblVATHighResult.Text = "0.50";
            this.lblVATHighResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(-9, -6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(770, 84);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btnUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnUserInfo.Image")));
            this.btnUserInfo.Location = new System.Drawing.Point(612, 18);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(33, 33);
            this.btnUserInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUserInfo.TabIndex = 30;
            this.btnUserInfo.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(650, 25);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(76, 16);
            this.lblUserName.TabIndex = 31;
            this.lblUserName.Text = "[username]";
            // 
            // btnClearTip
            // 
            this.btnClearTip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearTip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearTip.Location = new System.Drawing.Point(351, 94);
            this.btnClearTip.Name = "btnClearTip";
            this.btnClearTip.Size = new System.Drawing.Size(98, 48);
            this.btnClearTip.TabIndex = 32;
            this.btnClearTip.TabStop = false;
            this.btnClearTip.Click += new System.EventHandler(this.btnClearTip_Click);
            this.btnClearTip.MouseEnter += new System.EventHandler(this.btnClearTip_MouseEnter);
            this.btnClearTip.MouseLeave += new System.EventHandler(this.btnClearTip_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(324, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 42);
            this.label8.TabIndex = 33;
            this.label8.Text = "...";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblVATHigh);
            this.panel1.Controls.Add(this.lblVATLow);
            this.panel1.Controls.Add(this.btnClearTip);
            this.panel1.Controls.Add(this.lblTipAmount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblVATLowResult);
            this.panel1.Controls.Add(this.lblVATHighResult);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTotalResult);
            this.panel1.Controls.Add(this.txtToPay);
            this.panel1.Controls.Add(this.txtTipAmount);
            this.panel1.Location = new System.Drawing.Point(46, 621);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 219);
            this.panel1.TabIndex = 34;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 69);
            this.btnBack.TabIndex = 6;
            this.btnBack.TabStop = false;
            // 
            // pnlCheckout
            // 
            this.pnlCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlCheckout.Controls.Add(this.panel1);
            this.pnlCheckout.Controls.Add(this.btnBack);
            this.pnlCheckout.Controls.Add(this.label8);
            this.pnlCheckout.Controls.Add(this.label1);
            this.pnlCheckout.Controls.Add(this.btnToPayment);
            this.pnlCheckout.Controls.Add(this.listViewCheckoutOrder);
            this.pnlCheckout.Controls.Add(this.frameBox);
            this.pnlCheckout.Location = new System.Drawing.Point(12, 84);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(728, 898);
            this.pnlCheckout.TabIndex = 35;
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pnlCheckout);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapeau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearTip)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.pnlCheckout.ResumeLayout(false);
            this.pnlCheckout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnToPayment;
        private System.Windows.Forms.PictureBox frameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewCheckoutOrder;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVATHigh;
        private System.Windows.Forms.Label lblVATLow;
        private System.Windows.Forms.Label lblTipAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalResult;
        private System.Windows.Forms.TextBox txtTipAmount;
        private System.Windows.Forms.TextBox txtToPay;
        private System.Windows.Forms.Label lblVATLowResult;
        private System.Windows.Forms.Label lblVATHighResult;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btnUserInfo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox btnClearTip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Panel pnlCheckout;
    }
}