
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.lblTableStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.btnOccupyTable = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBackToOverview = new System.Windows.Forms.Button();
            this.pctBackground = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.ptcHeader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(50, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 48);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Chapeau";
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblUserFullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserFullName.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.ForeColor = System.Drawing.Color.White;
            this.lblUserFullName.Location = new System.Drawing.Point(393, 31);
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
            this.lblTableStatus.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableStatus.ForeColor = System.Drawing.Color.Black;
            this.lblTableStatus.Location = new System.Drawing.Point(486, 215);
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
            this.label1.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 48);
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
            // TableDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 985);
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
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.ptcHeader);
            this.Name = "TableDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapeau - Table Details";
            this.Load += new System.EventHandler(this.TableDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pctBackground;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.Label lblTableStatus;
        private System.Windows.Forms.Button btnBackToOverview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOccupyTable;
        private System.Windows.Forms.Button btnAddNewOrder;
        private System.Windows.Forms.Button btnCheckout;
    }
}