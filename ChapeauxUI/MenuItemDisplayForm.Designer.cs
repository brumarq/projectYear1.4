
namespace ChapeauxUI
{
    partial class MenuItemDisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItemDisplayForm));
            this.listViewDisplayForm = new System.Windows.Forms.ListView();
            this.lvItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvVAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butAdd = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtVatRate = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblVatRate = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.butMenuItemOverview = new System.Windows.Forms.Button();
            this.butUserOverview = new System.Windows.Forms.Button();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.ptcHeader = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewDisplayForm
            // 
            this.listViewDisplayForm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listViewDisplayForm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvItemID,
            this.lvName,
            this.lvPrice,
            this.lvStock,
            this.lvCategory,
            this.lvType,
            this.lvVAT});
            this.listViewDisplayForm.FullRowSelect = true;
            this.listViewDisplayForm.GridLines = true;
            this.listViewDisplayForm.HideSelection = false;
            this.listViewDisplayForm.Location = new System.Drawing.Point(49, 165);
            this.listViewDisplayForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewDisplayForm.MultiSelect = false;
            this.listViewDisplayForm.Name = "listViewDisplayForm";
            this.listViewDisplayForm.Size = new System.Drawing.Size(905, 488);
            this.listViewDisplayForm.TabIndex = 0;
            this.listViewDisplayForm.UseCompatibleStateImageBehavior = false;
            this.listViewDisplayForm.View = System.Windows.Forms.View.Details;
            this.listViewDisplayForm.SelectedIndexChanged += new System.EventHandler(this.listViewDisplayForm_SelectedIndexChanged);
            // 
            // lvItemID
            // 
            this.lvItemID.Text = "Item ID";
            this.lvItemID.Width = 54;
            // 
            // lvName
            // 
            this.lvName.Text = "Name";
            this.lvName.Width = 225;
            // 
            // lvPrice
            // 
            this.lvPrice.Text = "Price";
            this.lvPrice.Width = 70;
            // 
            // lvStock
            // 
            this.lvStock.Text = "Stock";
            this.lvStock.Width = 70;
            // 
            // lvCategory
            // 
            this.lvCategory.Text = "Category";
            this.lvCategory.Width = 90;
            // 
            // lvType
            // 
            this.lvType.Text = "Type";
            this.lvType.Width = 90;
            // 
            // lvVAT
            // 
            this.lvVAT.Text = "VAT Rate";
            this.lvVAT.Width = 90;
            // 
            // butAdd
            // 
            this.butAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.butAdd.Location = new System.Drawing.Point(720, 742);
            this.butAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(204, 86);
            this.butAdd.TabIndex = 35;
            this.butAdd.Text = "Add new Item";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(720, 687);
            this.butDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(204, 46);
            this.butDelete.TabIndex = 36;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(345, 780);
            this.butUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(235, 43);
            this.butUpdate.TabIndex = 37;
            this.butUpdate.Text = "Confirm changes";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(87, 740);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 27);
            this.txtName.TabIndex = 39;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(219, 740);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 27);
            this.txtPrice.TabIndex = 39;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(472, 740);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(108, 27);
            this.txtStock.TabIndex = 39;
            // 
            // txtVatRate
            // 
            this.txtVatRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVatRate.Location = new System.Drawing.Point(345, 740);
            this.txtVatRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVatRate.Name = "txtVatRate";
            this.txtVatRate.Size = new System.Drawing.Size(121, 27);
            this.txtVatRate.TabIndex = 39;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(84, 721);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(219, 719);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 40;
            this.lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(469, 719);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 17);
            this.lblStock.TabIndex = 40;
            this.lblStock.Text = "Stock";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(84, 770);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 40;
            this.lblCategory.Text = "Category";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(215, 777);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 40;
            this.lblType.Text = "Type";
            // 
            // lblVatRate
            // 
            this.lblVatRate.AutoSize = true;
            this.lblVatRate.Location = new System.Drawing.Point(342, 719);
            this.lblVatRate.Name = "lblVatRate";
            this.lblVatRate.Size = new System.Drawing.Size(69, 17);
            this.lblVatRate.TabIndex = 40;
            this.lblVatRate.Text = "VAT Rate";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Lunch",
            "Dinner",
            "Drink"});
            this.cbCategory.Location = new System.Drawing.Point(87, 794);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 28);
            this.cbCategory.TabIndex = 41;
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbType.Location = new System.Drawing.Point(218, 794);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 28);
            this.cbType.TabIndex = 41;
            // 
            // butMenuItemOverview
            // 
            this.butMenuItemOverview.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.butMenuItemOverview.Location = new System.Drawing.Point(239, 97);
            this.butMenuItemOverview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butMenuItemOverview.Name = "butMenuItemOverview";
            this.butMenuItemOverview.Size = new System.Drawing.Size(273, 34);
            this.butMenuItemOverview.TabIndex = 39;
            this.butMenuItemOverview.Text = "Menu Item Overview";
            this.butMenuItemOverview.UseVisualStyleBackColor = true;
            this.butMenuItemOverview.Click += new System.EventHandler(this.butMenuItemOverview_Click);
            // 
            // butUserOverview
            // 
            this.butUserOverview.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.butUserOverview.Location = new System.Drawing.Point(19, 97);
            this.butUserOverview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butUserOverview.Name = "butUserOverview";
            this.butUserOverview.Size = new System.Drawing.Size(233, 34);
            this.butUserOverview.TabIndex = 39;
            this.butUserOverview.Text = "User Overview";
            this.butUserOverview.UseVisualStyleBackColor = true;
            this.butUserOverview.Click += new System.EventHandler(this.butUserOverview_Click);
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblUserFullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.ForeColor = System.Drawing.Color.White;
            this.lblUserFullName.Location = new System.Drawing.Point(547, 47);
            this.lblUserFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserFullName.Size = new System.Drawing.Size(377, 30);
            this.lblUserFullName.TabIndex = 43;
            this.lblUserFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pctLogo.Image = global::ChapeauxUI.Properties.Resources.Capture;
            this.pctLogo.Location = new System.Drawing.Point(928, 7);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(61, 57);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 42;
            this.pctLogo.TabStop = false;
            // 
            // ptcHeader
            // 
            this.ptcHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptcHeader.Image = global::ChapeauxUI.Properties.Resources.top_bar;
            this.ptcHeader.Location = new System.Drawing.Point(-311, -1);
            this.ptcHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptcHeader.Name = "ptcHeader";
            this.ptcHeader.Size = new System.Drawing.Size(1331, 94);
            this.ptcHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcHeader.TabIndex = 7;
            this.ptcHeader.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::ChapeauxUI.Properties.Resources.logout_better;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(853, 82);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(155, 66);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(82, 682);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(188, 25);
            this.lblUpdate.TabIndex = 40;
            this.lblUpdate.Text = "Update Menu Item";
            // 
            // MenuItemDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1011, 869);
            this.Controls.Add(this.lblUserFullName);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.butMenuItemOverview);
            this.Controls.Add(this.butUserOverview);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblVatRate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtVatRate);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptcHeader);
            this.Controls.Add(this.listViewDisplayForm);
            this.Controls.Add(this.btnLogout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuItemDisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuItemDisplayForm";
            this.Load += new System.EventHandler(this.MenuItemDisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcHeader;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListView listViewDisplayForm;
        private System.Windows.Forms.ColumnHeader lvItemID;
        private System.Windows.Forms.ColumnHeader lvName;
        private System.Windows.Forms.ColumnHeader lvPrice;
        private System.Windows.Forms.ColumnHeader lvStock;
        private System.Windows.Forms.ColumnHeader lvCategory;
        private System.Windows.Forms.ColumnHeader lvType;
        private System.Windows.Forms.ColumnHeader lvVAT;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtVatRate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblVatRate;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button butMenuItemOverview;
        private System.Windows.Forms.Button butUserOverview;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUpdate;
    }
}