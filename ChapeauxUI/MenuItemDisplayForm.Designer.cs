
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
            this.ptcHeader = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.listViewDisplayForm = new System.Windows.Forms.ListView();
            this.lvItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvVAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butAdd = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtVatRate = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblVatRate = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.butMenuItemOverview = new System.Windows.Forms.Button();
            this.butUserOverview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptcHeader
            // 
            this.ptcHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptcHeader.Image = global::ChapeauxUI.Properties.Resources.top_bar;
            this.ptcHeader.Location = new System.Drawing.Point(-311, -1);
            this.ptcHeader.Margin = new System.Windows.Forms.Padding(4);
            this.ptcHeader.Name = "ptcHeader";
            this.ptcHeader.Size = new System.Drawing.Size(1494, 94);
            this.ptcHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcHeader.TabIndex = 7;
            this.ptcHeader.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::ChapeauxUI.Properties.Resources.logout_better;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(854, 83);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(154, 66);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.lvCourse,
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
            // lvCourse
            // 
            this.lvCourse.Text = "Course";
            this.lvCourse.Width = 90;
            // 
            // lvVAT
            // 
            this.lvVAT.Text = "VAT Rate";
            this.lvVAT.Width = 90;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(717, 698);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(87, 36);
            this.butAdd.TabIndex = 35;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(903, 698);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(87, 35);
            this.butDelete.TabIndex = 36;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(810, 698);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(87, 35);
            this.butEdit.TabIndex = 37;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 706);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 39;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(123, 706);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 39;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(229, 706);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 22);
            this.txtStock.TabIndex = 39;
            // 
            // txtVatRate
            // 
            this.txtVatRate.Location = new System.Drawing.Point(589, 706);
            this.txtVatRate.Name = "txtVatRate";
            this.txtVatRate.Size = new System.Drawing.Size(100, 22);
            this.txtVatRate.TabIndex = 39;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 682);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(120, 682);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 40;
            this.lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(226, 682);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 17);
            this.lblStock.TabIndex = 40;
            this.lblStock.Text = "Stock";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(332, 682);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 40;
            this.lblCategory.Text = "Category";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(459, 682);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(53, 17);
            this.lblCourse.TabIndex = 40;
            this.lblCourse.Text = "Course";
            // 
            // lblVatRate
            // 
            this.lblVatRate.AutoSize = true;
            this.lblVatRate.Location = new System.Drawing.Point(586, 682);
            this.lblVatRate.Name = "lblVatRate";
            this.lblVatRate.Size = new System.Drawing.Size(69, 17);
            this.lblVatRate.TabIndex = 40;
            this.lblVatRate.Text = "VAT Rate";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Lunch",
            "Dinner",
            "Drink"});
            this.cbCategory.Location = new System.Drawing.Point(335, 704);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 24);
            this.cbCategory.TabIndex = 41;
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Items.AddRange(new object[] {
            "Main ",
            "Special",
            "Bites",
            "Starters",
            "Dessert",
            "Drink"});
            this.cbCourse.Location = new System.Drawing.Point(462, 704);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(121, 24);
            this.cbCourse.TabIndex = 41;
            // 
            // butMenuItemOverview
            // 
            this.butMenuItemOverview.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.butMenuItemOverview.Location = new System.Drawing.Point(239, 97);
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
            this.butUserOverview.Location = new System.Drawing.Point(18, 97);
            this.butUserOverview.Name = "butUserOverview";
            this.butUserOverview.Size = new System.Drawing.Size(233, 34);
            this.butUserOverview.TabIndex = 39;
            this.butUserOverview.Text = "User Overview";
            this.butUserOverview.UseVisualStyleBackColor = true;
            this.butUserOverview.Click += new System.EventHandler(this.butUserOverview_Click);
            // 
            // MenuItemDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1010, 816);
            this.Controls.Add(this.butMenuItemOverview);
            this.Controls.Add(this.butUserOverview);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblVatRate);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtVatRate);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptcHeader);
            this.Controls.Add(this.listViewDisplayForm);
            this.Controls.Add(this.btnLogout);
            this.Name = "MenuItemDisplayForm";
            this.Text = "MenuItemDisplayForm";
            this.Load += new System.EventHandler(this.MenuItemDisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListView listViewDisplayForm;
        private System.Windows.Forms.ColumnHeader lvItemID;
        private System.Windows.Forms.ColumnHeader lvName;
        private System.Windows.Forms.ColumnHeader lvPrice;
        private System.Windows.Forms.ColumnHeader lvStock;
        private System.Windows.Forms.ColumnHeader lvCategory;
        private System.Windows.Forms.ColumnHeader lvCourse;
        private System.Windows.Forms.ColumnHeader lvVAT;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtVatRate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblVatRate;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Button butMenuItemOverview;
        private System.Windows.Forms.Button butUserOverview;
    }
}