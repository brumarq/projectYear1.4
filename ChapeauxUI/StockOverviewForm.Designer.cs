
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
            this.lblStockOverview = new System.Windows.Forms.Label();
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
            // StockOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::ChapeauxUI.Properties.Resources.Screenshot__57_;
            this.ClientSize = new System.Drawing.Size(706, 977);
            this.Controls.Add(this.lblStockOverview);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StockOverviewForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "StockOverviewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockOverview;
    }
}