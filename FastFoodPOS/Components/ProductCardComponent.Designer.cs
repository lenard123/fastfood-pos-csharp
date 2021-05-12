namespace FastFoodPOS.Components
{
    partial class ProductCardComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonSetAvailability = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonRemove = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.PictureProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.ButtonSetAvailability);
            this.guna2Panel1.Controls.Add(this.ButtonRemove);
            this.guna2Panel1.Controls.Add(this.ButtonUpdate);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(247, 287);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ButtonSetAvailability
            // 
            this.ButtonSetAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSetAvailability.BorderColor = System.Drawing.Color.LightGray;
            this.ButtonSetAvailability.BorderThickness = 1;
            this.ButtonSetAvailability.CheckedState.Parent = this.ButtonSetAvailability;
            this.ButtonSetAvailability.CustomImages.Parent = this.ButtonSetAvailability;
            this.ButtonSetAvailability.FillColor = System.Drawing.Color.Gray;
            this.ButtonSetAvailability.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSetAvailability.ForeColor = System.Drawing.Color.White;
            this.ButtonSetAvailability.HoverState.Parent = this.ButtonSetAvailability;
            this.ButtonSetAvailability.Location = new System.Drawing.Point(21, 231);
            this.ButtonSetAvailability.Name = "ButtonSetAvailability";
            this.ButtonSetAvailability.ShadowDecoration.Parent = this.ButtonSetAvailability;
            this.ButtonSetAvailability.Size = new System.Drawing.Size(204, 37);
            this.ButtonSetAvailability.TabIndex = 1;
            this.ButtonSetAvailability.Text = "Availability: Available";
            this.ButtonSetAvailability.Click += new System.EventHandler(this.ButtonSetAvailability_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.BorderColor = System.Drawing.Color.LightGray;
            this.ButtonRemove.BorderThickness = 1;
            this.ButtonRemove.CheckedState.Parent = this.ButtonRemove;
            this.ButtonRemove.CustomImages.Parent = this.ButtonRemove;
            this.ButtonRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRemove.ForeColor = System.Drawing.Color.Black;
            this.ButtonRemove.HoverState.Parent = this.ButtonRemove;
            this.ButtonRemove.Location = new System.Drawing.Point(133, 181);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.ShadowDecoration.Parent = this.ButtonRemove;
            this.ButtonRemove.Size = new System.Drawing.Size(92, 37);
            this.ButtonRemove.TabIndex = 1;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BorderColor = System.Drawing.Color.LightGray;
            this.ButtonUpdate.BorderThickness = 1;
            this.ButtonUpdate.CheckedState.Parent = this.ButtonUpdate;
            this.ButtonUpdate.CustomImages.Parent = this.ButtonUpdate;
            this.ButtonUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonUpdate.ForeColor = System.Drawing.Color.Black;
            this.ButtonUpdate.HoverState.Parent = this.ButtonUpdate;
            this.ButtonUpdate.Location = new System.Drawing.Point(21, 181);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.ShadowDecoration.Parent = this.ButtonUpdate;
            this.ButtonUpdate.Size = new System.Drawing.Size(92, 37);
            this.ButtonUpdate.TabIndex = 1;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.LabelPrice);
            this.panel1.Controls.Add(this.LabelProductName);
            this.panel1.Controls.Add(this.PictureProductImage);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 174);
            this.panel1.TabIndex = 0;
            // 
            // LabelPrice
            // 
            this.LabelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.Location = new System.Drawing.Point(133, 134);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(91, 21);
            this.LabelPrice.TabIndex = 1;
            this.LabelPrice.Text = "500.00PHP";
            this.LabelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelProductName
            // 
            this.LabelProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelProductName.Location = new System.Drawing.Point(18, 128);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(109, 37);
            this.LabelProductName.TabIndex = 1;
            this.LabelProductName.Text = "ABCD EFGH HUGH LMNK";
            this.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureProductImage
            // 
            this.PictureProductImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureProductImage.Image = global::FastFoodPOS.Properties.Resources.icon_placeholder;
            this.PictureProductImage.Location = new System.Drawing.Point(22, 13);
            this.PictureProductImage.Name = "PictureProductImage";
            this.PictureProductImage.ShadowDecoration.Parent = this.PictureProductImage;
            this.PictureProductImage.Size = new System.Drawing.Size(203, 100);
            this.PictureProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureProductImage.TabIndex = 0;
            this.PictureProductImage.TabStop = false;
            // 
            // ProductCardComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductCardComponent";
            this.Size = new System.Drawing.Size(247, 287);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox PictureProductImage;
        private Guna.UI2.WinForms.Guna2Button ButtonUpdate;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelProductName;
        private Guna.UI2.WinForms.Guna2Button ButtonSetAvailability;
        private Guna.UI2.WinForms.Guna2Button ButtonRemove;
    }
}
