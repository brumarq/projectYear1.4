
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStockOverview
            // 
            this.lblStockOverview.AutoSize = true;
            this.lblStockOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblStockOverview.Location = new System.Drawing.Point(31, 80);
            this.lblStockOverview.Name = "lblStockOverview";
            this.lblStockOverview.Size = new System.Drawing.Size(204, 31);
            this.lblStockOverview.TabIndex = 0;
            this.lblStockOverview.Text = "Stock Overview";
            // 
            // lblItemName
            // 
            this.lblItemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblItemName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblItemName.Location = new System.Drawing.Point(50, 148);
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
            this.lblCost.Location = new System.Drawing.Point(367, 148);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(53, 15);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Cost (€)";
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblItemQuantity.Location = new System.Drawing.Point(169, 148);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(83, 15);
            this.lblItemQuantity.TabIndex = 0;
            this.lblItemQuantity.Text = "Item quantity";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCategory.Location = new System.Drawing.Point(285, 148);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // butQuantityAdd
            // 
            this.butQuantityAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.butQuantityAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butQuantityAdd.Location = new System.Drawing.Point(431, 131);
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
            this.butQuantityRemove.Location = new System.Drawing.Point(559, 131);
            this.butQuantityRemove.Name = "butQuantityRemove";
            this.butQuantityRemove.Size = new System.Drawing.Size(94, 34);
            this.butQuantityRemove.TabIndex = 1;
            this.butQuantityRemove.Text = "Quantity -";
            this.butQuantityRemove.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // StockOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(706, 981);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butQuantityRemove);
            this.Controls.Add(this.lblStockOverview);
            this.Controls.Add(this.butQuantityAdd);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblItemQuantity);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StockOverviewForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "StockOverviewForm";
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}