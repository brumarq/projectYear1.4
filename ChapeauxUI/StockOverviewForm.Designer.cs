
namespace ChapeauxUI
{
    partial class StockOverviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOverviewForm));
            this.lblStockOverview = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.butQuantityAdd = new System.Windows.Forms.Button();
            this.butQuantityRemove = new System.Windows.Forms.Button();
            this.ptcHeader = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStockOverview
            // 
            this.lblStockOverview.AutoSize = true;
            this.lblStockOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblStockOverview.Location = new System.Drawing.Point(26, 173);
            this.lblStockOverview.Name = "lblStockOverview";
            this.lblStockOverview.Size = new System.Drawing.Size(204, 31);
            this.lblStockOverview.TabIndex = 0;
            this.lblStockOverview.Text = "Stock Overview";
            // 
            // lblItemName
            // 
            this.lblItemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblItemName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblItemName.Location = new System.Drawing.Point(64, 238);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemName.Size = new System.Drawing.Size(67, 15);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item name";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCost.Location = new System.Drawing.Point(381, 238);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(53, 15);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Cost (€)";
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblItemQuantity.Location = new System.Drawing.Point(183, 238);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(83, 15);
            this.lblItemQuantity.TabIndex = 0;
            this.lblItemQuantity.Text = "Item quantity";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCategory.Location = new System.Drawing.Point(299, 238);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // butQuantityAdd
            // 
            this.butQuantityAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.butQuantityAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butQuantityAdd.Location = new System.Drawing.Point(445, 221);
            this.butQuantityAdd.Name = "butQuantityAdd";
            this.butQuantityAdd.Size = new System.Drawing.Size(94, 34);
            this.butQuantityAdd.TabIndex = 1;
            this.butQuantityAdd.Text = "Quantity +";
            this.butQuantityAdd.UseVisualStyleBackColor = false;
            // 
            // butQuantityRemove
            // 
            this.butQuantityRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.butQuantityRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butQuantityRemove.Location = new System.Drawing.Point(573, 221);
            this.butQuantityRemove.Name = "butQuantityRemove";
            this.butQuantityRemove.Size = new System.Drawing.Size(94, 34);
            this.butQuantityRemove.TabIndex = 1;
            this.butQuantityRemove.Text = "Quantity -";
            this.butQuantityRemove.UseVisualStyleBackColor = false;
            // 
            // ptcHeader
            // 
            this.ptcHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptcHeader.Image = global::ChapeauxUI.Properties.Resources.top_bar;
            this.ptcHeader.Location = new System.Drawing.Point(-319, -11);
            this.ptcHeader.Margin = new System.Windows.Forms.Padding(4);
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
            this.button1.Location = new System.Drawing.Point(4, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 66);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::ChapeauxUI.Properties.Resources.logout_better;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(548, 78);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(154, 66);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // StockOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(706, 981);
            this.Controls.Add(this.butQuantityRemove);
            this.Controls.Add(this.lblStockOverview);
            this.Controls.Add(this.butQuantityAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblItemQuantity);
            this.Controls.Add(this.ptcHeader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StockOverviewForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "StockOverviewForm";
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockOverview;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblItemQuantity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button butQuantityAdd;
        private System.Windows.Forms.Button butQuantityRemove;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.PictureBox ptcHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
    }
}