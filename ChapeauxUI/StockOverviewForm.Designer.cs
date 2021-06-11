
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
            this.butQuantityAdd = new System.Windows.Forms.Button();
            this.butQuantityRemove = new System.Windows.Forms.Button();
            this.ptcHeader = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvItemQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // butQuantityAdd
            // 
            this.butQuantityAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.butQuantityAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butQuantityAdd.Location = new System.Drawing.Point(32, 232);
            this.butQuantityAdd.Name = "butQuantityAdd";
            this.butQuantityAdd.Size = new System.Drawing.Size(129, 34);
            this.butQuantityAdd.TabIndex = 1;
            this.butQuantityAdd.Text = "Add Quantity";
            this.butQuantityAdd.UseVisualStyleBackColor = false;
            // 
            // butQuantityRemove
            // 
            this.butQuantityRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.butQuantityRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butQuantityRemove.Location = new System.Drawing.Point(167, 232);
            this.butQuantityRemove.Name = "butQuantityRemove";
            this.butQuantityRemove.Size = new System.Drawing.Size(129, 34);
            this.butQuantityRemove.TabIndex = 1;
            this.butQuantityRemove.Text = "Remove Quantity";
            this.butQuantityRemove.UseVisualStyleBackColor = false;
            this.butQuantityRemove.Click += new System.EventHandler(this.butQuantityRemove_Click);
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
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvItemName,
            this.lvItemQuantity,
            this.lvCategory});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(82, 304);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(484, 685);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lvItemName
            // 
            this.lvItemName.Text = "Item Name";
            this.lvItemName.Width = 225;
            // 
            // lvItemQuantity
            // 
            this.lvItemQuantity.Text = "Item Quantity";
            this.lvItemQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvItemQuantity.Width = 90;
            // 
            // lvCategory
            // 
            this.lvCategory.Text = "Category";
            this.lvCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvCategory.Width = 120;
            // 
            // StockOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(706, 981);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.butQuantityRemove);
            this.Controls.Add(this.lblStockOverview);
            this.Controls.Add(this.butQuantityAdd);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.Button butQuantityAdd;
        private System.Windows.Forms.Button butQuantityRemove;
        private System.Windows.Forms.PictureBox ptcHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lvItemName;
        private System.Windows.Forms.ColumnHeader lvItemQuantity;
        private System.Windows.Forms.ColumnHeader lvCategory;
    }
}