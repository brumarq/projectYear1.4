
namespace ChapeauxUI
{
    partial class DeleteMenuItem
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.butDeleteMenuItem = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtVATRate = new System.Windows.Forms.TextBox();
            this.lblVATRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(72, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(72, 192);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(72, 253);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(53, 17);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Course";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(74, 144);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 17);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "Stock";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(72, 99);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            // 
            // butDeleteMenuItem
            // 
            this.butDeleteMenuItem.Location = new System.Drawing.Point(521, 382);
            this.butDeleteMenuItem.Name = "butDeleteMenuItem";
            this.butDeleteMenuItem.Size = new System.Drawing.Size(152, 33);
            this.butDeleteMenuItem.TabIndex = 1;
            this.butDeleteMenuItem.Text = "Delete Menu Item";
            this.butDeleteMenuItem.UseVisualStyleBackColor = true;
            this.butDeleteMenuItem.Click += new System.EventHandler(this.butDeleteMenuItem_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(236, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(236, 96);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(275, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(236, 250);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(275, 22);
            this.txtCourse.TabIndex = 3;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(236, 144);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(275, 22);
            this.txtStock.TabIndex = 3;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(236, 189);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(275, 22);
            this.txtCategory.TabIndex = 3;
            // 
            // txtVATRate
            // 
            this.txtVATRate.Location = new System.Drawing.Point(236, 310);
            this.txtVATRate.Name = "txtVATRate";
            this.txtVATRate.Size = new System.Drawing.Size(275, 22);
            this.txtVATRate.TabIndex = 3;
            // 
            // lblVATRate
            // 
            this.lblVATRate.AutoSize = true;
            this.lblVATRate.Location = new System.Drawing.Point(72, 313);
            this.lblVATRate.Name = "lblVATRate";
            this.lblVATRate.Size = new System.Drawing.Size(69, 17);
            this.lblVATRate.TabIndex = 4;
            this.lblVATRate.Text = "VAT Rate";
            // 
            // DeleteMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVATRate);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.butDeleteMenuItem);
            this.Controls.Add(this.txtVATRate);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrice);
            this.Name = "DeleteMenuItem";
            this.Text = "DeleteMenuItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button butDeleteMenuItem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtVATRate;
        private System.Windows.Forms.Label lblVATRate;
    }
}