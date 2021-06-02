
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
            // StockAdjustmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::ChapeauxUI.Properties.Resources.Screenshot__57_;
            this.ClientSize = new System.Drawing.Size(1109, 534);
            this.Controls.Add(this.lblStockAdjustment);
            this.Name = "StockAdjustmentForm";
            this.Text = "StockAdjustmentForm";
            this.Load += new System.EventHandler(this.StockAdjustmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockAdjustment;
    }
}