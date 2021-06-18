
namespace ChapeauxUI
{
    partial class AddNewItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewItemForm));
            this.lblNameNew = new System.Windows.Forms.Label();
            this.butBack = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.lblPriceNew = new System.Windows.Forms.Label();
            this.lblStockNew = new System.Windows.Forms.Label();
            this.lblCategoryNew = new System.Windows.Forms.Label();
            this.lblTypeNew = new System.Windows.Forms.Label();
            this.lblVATRateNew = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtVATRate = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.ptcHeader = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddMenuItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameNew
            // 
            this.lblNameNew.AutoSize = true;
            this.lblNameNew.Location = new System.Drawing.Point(265, 153);
            this.lblNameNew.Name = "lblNameNew";
            this.lblNameNew.Size = new System.Drawing.Size(45, 17);
            this.lblNameNew.TabIndex = 1;
            this.lblNameNew.Text = "Name";
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(227, 475);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(153, 32);
            this.butBack.TabIndex = 0;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(439, 475);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(153, 32);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // lblPriceNew
            // 
            this.lblPriceNew.AutoSize = true;
            this.lblPriceNew.Location = new System.Drawing.Point(265, 207);
            this.lblPriceNew.Name = "lblPriceNew";
            this.lblPriceNew.Size = new System.Drawing.Size(40, 17);
            this.lblPriceNew.TabIndex = 1;
            this.lblPriceNew.Text = "Price";
            // 
            // lblStockNew
            // 
            this.lblStockNew.AutoSize = true;
            this.lblStockNew.Location = new System.Drawing.Point(265, 255);
            this.lblStockNew.Name = "lblStockNew";
            this.lblStockNew.Size = new System.Drawing.Size(43, 17);
            this.lblStockNew.TabIndex = 1;
            this.lblStockNew.Text = "Stock";
            // 
            // lblCategoryNew
            // 
            this.lblCategoryNew.AutoSize = true;
            this.lblCategoryNew.Location = new System.Drawing.Point(265, 307);
            this.lblCategoryNew.Name = "lblCategoryNew";
            this.lblCategoryNew.Size = new System.Drawing.Size(65, 17);
            this.lblCategoryNew.TabIndex = 1;
            this.lblCategoryNew.Text = "Category";
            // 
            // lblTypeNew
            // 
            this.lblTypeNew.AutoSize = true;
            this.lblTypeNew.Location = new System.Drawing.Point(265, 356);
            this.lblTypeNew.Name = "lblTypeNew";
            this.lblTypeNew.Size = new System.Drawing.Size(40, 17);
            this.lblTypeNew.TabIndex = 1;
            this.lblTypeNew.Text = "Type";
            // 
            // lblVATRateNew
            // 
            this.lblVATRateNew.AutoSize = true;
            this.lblVATRateNew.Location = new System.Drawing.Point(265, 413);
            this.lblVATRateNew.Name = "lblVATRateNew";
            this.lblVATRateNew.Size = new System.Drawing.Size(69, 17);
            this.lblVATRateNew.TabIndex = 1;
            this.lblVATRateNew.Text = "VAT Rate";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(383, 148);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(383, 202);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(194, 22);
            this.txtPrice.TabIndex = 2;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(383, 250);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(194, 22);
            this.txtStock.TabIndex = 2;
            // 
            // txtVATRate
            // 
            this.txtVATRate.Location = new System.Drawing.Point(383, 408);
            this.txtVATRate.Name = "txtVATRate";
            this.txtVATRate.Size = new System.Drawing.Size(194, 22);
            this.txtVATRate.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Lunch ",
            "Dinner",
            "Drink"});
            this.cbCategory.Location = new System.Drawing.Point(383, 298);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(194, 24);
            this.cbCategory.TabIndex = 3;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Main ",
            "Special",
            "Bites",
            "Starters",
            "Dessert",
            "Soft Drink",
            "Hot Drink",
            "Wine",
            "Beer"});
            this.cbType.Location = new System.Drawing.Point(383, 349);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(194, 24);
            this.cbType.TabIndex = 3;
            // 
            // ptcHeader
            // 
            this.ptcHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptcHeader.Image = global::ChapeauxUI.Properties.Resources.top_bar;
            this.ptcHeader.Location = new System.Drawing.Point(-3, -1);
            this.ptcHeader.Margin = new System.Windows.Forms.Padding(4);
            this.ptcHeader.Name = "ptcHeader";
            this.ptcHeader.Size = new System.Drawing.Size(886, 94);
            this.ptcHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcHeader.TabIndex = 7;
            this.ptcHeader.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // lblAddMenuItem
            // 
            this.lblAddMenuItem.AutoSize = true;
            this.lblAddMenuItem.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMenuItem.Location = new System.Drawing.Point(21, 97);
            this.lblAddMenuItem.Name = "lblAddMenuItem";
            this.lblAddMenuItem.Size = new System.Drawing.Size(176, 28);
            this.lblAddMenuItem.TabIndex = 1;
            this.lblAddMenuItem.Text = "Add Menu Item";
            // 
            // AddNewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(877, 554);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblAddMenuItem);
            this.Controls.Add(this.lblNameNew);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.txtVATRate);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblPriceNew);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblStockNew);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCategoryNew);
            this.Controls.Add(this.lblVATRateNew);
            this.Controls.Add(this.lblTypeNew);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptcHeader);
            this.Name = "AddNewItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameNew;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Label lblPriceNew;
        private System.Windows.Forms.Label lblStockNew;
        private System.Windows.Forms.Label lblCategoryNew;
        private System.Windows.Forms.Label lblTypeNew;
        private System.Windows.Forms.Label lblVATRateNew;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtVATRate;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.PictureBox ptcHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddMenuItem;
    }
}