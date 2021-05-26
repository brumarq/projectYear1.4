
namespace ChapeauxUI
{
    partial class StockAdjustmentForm
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
            this.lblStockAdjustment = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.butQuantityAdd = new System.Windows.Forms.Button();
            this.butQuantityDecrease = new System.Windows.Forms.Button();
            this.butLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStockAdjustment
            // 
            this.lblStockAdjustment.AutoSize = true;
            this.lblStockAdjustment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStockAdjustment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblStockAdjustment.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblStockAdjustment.Location = new System.Drawing.Point(12, 96);
            this.lblStockAdjustment.Name = "lblStockAdjustment";
            this.lblStockAdjustment.Size = new System.Drawing.Size(226, 31);
            this.lblStockAdjustment.TabIndex = 0;
            this.lblStockAdjustment.Text = "Stock Adjustment";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCost.Location = new System.Drawing.Point(415, 202);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(58, 17);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Cost (€)";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblItemName.Location = new System.Drawing.Point(103, 202);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(73, 17);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item name";
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblItemQuantity.Location = new System.Drawing.Point(217, 202);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(88, 17);
            this.lblItemQuantity.TabIndex = 0;
            this.lblItemQuantity.Text = "Item quantity";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCategory.Location = new System.Drawing.Point(333, 202);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // butQuantityAdd
            // 
            this.butQuantityAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.butQuantityAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butQuantityAdd.Location = new System.Drawing.Point(479, 185);
            this.butQuantityAdd.Name = "butQuantityAdd";
            this.butQuantityAdd.Size = new System.Drawing.Size(94, 34);
            this.butQuantityAdd.TabIndex = 1;
            this.butQuantityAdd.Text = "Quantity +";
            this.butQuantityAdd.UseVisualStyleBackColor = false;
            // 
            // butQuantityDecrease
            // 
            this.butQuantityDecrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.butQuantityDecrease.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butQuantityDecrease.Location = new System.Drawing.Point(607, 185);
            this.butQuantityDecrease.Name = "butQuantityDecrease";
            this.butQuantityDecrease.Size = new System.Drawing.Size(94, 34);
            this.butQuantityDecrease.TabIndex = 1;
            this.butQuantityDecrease.Text = "Quantity -";
            this.butQuantityDecrease.UseVisualStyleBackColor = false;
            // 
            // butLogOut
            // 
            this.butLogOut.Location = new System.Drawing.Point(757, 188);
            this.butLogOut.Name = "butLogOut";
            this.butLogOut.Size = new System.Drawing.Size(94, 31);
            this.butLogOut.TabIndex = 1;
            this.butLogOut.Text = "Log out";
            this.butLogOut.UseVisualStyleBackColor = true;
            // 
            // StockAdjustmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::ChapeauxUI.Properties.Resources.Screenshot__57_;
            this.ClientSize = new System.Drawing.Size(1109, 534);
            this.Controls.Add(this.butLogOut);
            this.Controls.Add(this.butQuantityDecrease);
            this.Controls.Add(this.butQuantityAdd);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblItemQuantity);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblStockAdjustment);
            this.Name = "StockAdjustmentForm";
            this.Text = "StockAdjustmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockAdjustment;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemQuantity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button butQuantityAdd;
        private System.Windows.Forms.Button butQuantityDecrease;
        private System.Windows.Forms.Button butLogOut;
    }
}