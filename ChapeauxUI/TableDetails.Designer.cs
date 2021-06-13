
namespace ChapeauUI
{
    partial class TableDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableDetails));
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.lblTableStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.btnOccupyTable = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pctBackground = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.ptcHeader = new System.Windows.Forms.PictureBox();
            this.btnBackToOverview = new System.Windows.Forms.Button();
            this.listViewOrderOverview = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblTimer = new System.Windows.Forms.Label();
            this.picChapeau = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChapeau)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblUserFullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.ForeColor = System.Drawing.Color.White;
            this.lblUserFullName.Location = new System.Drawing.Point(394, 32);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserFullName.Size = new System.Drawing.Size(283, 24);
            this.lblUserFullName.TabIndex = 12;
            this.lblUserFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTableStatus
            // 
            this.lblTableStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTableStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblTableStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTableStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableStatus.ForeColor = System.Drawing.Color.Black;
            this.lblTableStatus.Location = new System.Drawing.Point(485, 215);
            this.lblTableStatus.Name = "lblTableStatus";
            this.lblTableStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTableStatus.Size = new System.Drawing.Size(205, 24);
            this.lblTableStatus.TabIndex = 13;
            this.lblTableStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Table Details";
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnCheckout.BackgroundImage = global::ChapeauxUI.Properties.Resources.btnCheckout_enabled;
            this.btnCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Location = new System.Drawing.Point(376, 661);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(315, 287);
            this.btnCheckout.TabIndex = 19;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddNewOrder.BackgroundImage = global::ChapeauxUI.Properties.Resources.btnAddNewOrder_enabled;
            this.btnAddNewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewOrder.FlatAppearance.BorderSize = 0;
            this.btnAddNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewOrder.Location = new System.Drawing.Point(74, 742);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(297, 206);
            this.btnAddNewOrder.TabIndex = 18;
            this.btnAddNewOrder.UseVisualStyleBackColor = false;
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
            // 
            // btnOccupyTable
            // 
            this.btnOccupyTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnOccupyTable.BackgroundImage = global::ChapeauxUI.Properties.Resources.btnOccupyTable_enabled;
            this.btnOccupyTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOccupyTable.FlatAppearance.BorderSize = 0;
            this.btnOccupyTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOccupyTable.Location = new System.Drawing.Point(72, 666);
            this.btnOccupyTable.Name = "btnOccupyTable";
            this.btnOccupyTable.Size = new System.Drawing.Size(294, 79);
            this.btnOccupyTable.TabIndex = 17;
            this.btnOccupyTable.UseVisualStyleBackColor = false;
            this.btnOccupyTable.Click += new System.EventHandler(this.btnOccupyTable_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChapeauxUI.Properties.Resources.tableDesign;
            this.pictureBox1.Location = new System.Drawing.Point(76, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::ChapeauxUI.Properties.Resources.logout_better;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(592, 92);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(146, 63);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pctBackground
            // 
            this.pctBackground.Image = global::ChapeauxUI.Properties.Resources.background_rectangle;
            this.pctBackground.Location = new System.Drawing.Point(12, 149);
            this.pctBackground.Name = "pctBackground";
            this.pctBackground.Size = new System.Drawing.Size(768, 837);
            this.pctBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBackground.TabIndex = 10;
            this.pctBackground.TabStop = false;
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pctLogo.Image = global::ChapeauxUI.Properties.Resources.Capture;
            this.pctLogo.Location = new System.Drawing.Point(684, 20);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(46, 46);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 8;
            this.pctLogo.TabStop = false;
            // 
            // ptcHeader
            // 
            this.ptcHeader.Image = global::ChapeauxUI.Properties.Resources.top_bar;
            this.ptcHeader.Location = new System.Drawing.Point(0, 0);
            this.ptcHeader.Name = "ptcHeader";
            this.ptcHeader.Size = new System.Drawing.Size(768, 98);
            this.ptcHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcHeader.TabIndex = 6;
            this.ptcHeader.TabStop = false;
            // 
            // btnBackToOverview
            // 
            this.btnBackToOverview.BackColor = System.Drawing.Color.Black;
            this.btnBackToOverview.BackgroundImage = global::ChapeauxUI.Properties.Resources.backButton;
            this.btnBackToOverview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBackToOverview.FlatAppearance.BorderSize = 0;
            this.btnBackToOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToOverview.Location = new System.Drawing.Point(28, 88);
            this.btnBackToOverview.Name = "btnBackToOverview";
            this.btnBackToOverview.Size = new System.Drawing.Size(121, 67);
            this.btnBackToOverview.TabIndex = 14;
            this.btnBackToOverview.UseVisualStyleBackColor = false;
            this.btnBackToOverview.Click += new System.EventHandler(this.btnBackToOverview_Click);
            // 
            // listViewOrderOverview
            // 
            this.listViewOrderOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOrderOverview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewOrderOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Product,
            this.Qty,
            this.UnitPrice,
            this.orderStatus});
            this.listViewOrderOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewOrderOverview.FullRowSelect = true;
            this.listViewOrderOverview.HideSelection = false;
            this.listViewOrderOverview.Location = new System.Drawing.Point(84, 254);
            this.listViewOrderOverview.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.listViewOrderOverview.MultiSelect = false;
            this.listViewOrderOverview.Name = "listViewOrderOverview";
            this.listViewOrderOverview.Size = new System.Drawing.Size(601, 390);
            this.listViewOrderOverview.TabIndex = 20;
            this.listViewOrderOverview.UseCompatibleStateImageBehavior = false;
            this.listViewOrderOverview.View = System.Windows.Forms.View.Details;
            this.listViewOrderOverview.SelectedIndexChanged += new System.EventHandler(this.listViewOrderOverview_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 233;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty.";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Qty.Width = 93;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Unit Price";
            this.UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UnitPrice.Width = 92;
            // 
            // orderStatus
            // 
            this.orderStatus.Text = "Status";
            this.orderStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orderStatus.Width = 120;
            // 
            // LblTimer
            // 
            this.LblTimer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.LblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimer.ForeColor = System.Drawing.Color.Black;
            this.LblTimer.Location = new System.Drawing.Point(485, 181);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTimer.Size = new System.Drawing.Size(205, 24);
            this.LblTimer.TabIndex = 22;
            this.LblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picChapeau
            // 
            this.picChapeau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.picChapeau.Image = ((System.Drawing.Image)(resources.GetObject("picChapeau.Image")));
            this.picChapeau.Location = new System.Drawing.Point(12, 12);
            this.picChapeau.Name = "picChapeau";
            this.picChapeau.Size = new System.Drawing.Size(120, 60);
            this.picChapeau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChapeau.TabIndex = 23;
            this.picChapeau.TabStop = false;
            // 
            // TableDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 985);
            this.Controls.Add(this.picChapeau);
            this.Controls.Add(this.LblTimer);
            this.Controls.Add(this.listViewOrderOverview);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnAddNewOrder);
            this.Controls.Add(this.btnOccupyTable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTableStatus);
            this.Controls.Add(this.lblUserFullName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBackToOverview);
            this.Controls.Add(this.pctBackground);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.ptcHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapeau - Table Details";
            this.Load += new System.EventHandler(this.TableDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChapeau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcHeader;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pctBackground;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.Label lblTableStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOccupyTable;
        private System.Windows.Forms.Button btnAddNewOrder;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnBackToOverview;
        private System.Windows.Forms.ListView listViewOrderOverview;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader orderStatus;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.PictureBox picChapeau;
    }
}