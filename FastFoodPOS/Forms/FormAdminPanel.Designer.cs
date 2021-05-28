namespace FastFoodPOS.Forms
{
    partial class FormAdminPanel
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonsMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonManageProduct = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonTransaction = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSales = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonUsers = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonArchives = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonLogout = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonUpdateInfo = new Guna.UI2.WinForms.Guna2Button();
            this.LabelUserRole = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.PictureUserImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.ButtonsMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(340, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(476, 521);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.panel4.Controls.Add(this.guna2ControlBox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(340, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(476, 50);
            this.panel4.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(436, 9);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "WcDonald\'s POS System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FastFoodPOS.Properties.Resources.mcdonalds;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.ButtonsMenuPanel);
            this.panel1.Controls.Add(this.ButtonUpdateInfo);
            this.panel1.Controls.Add(this.LabelUserRole);
            this.panel1.Controls.Add(this.LabelUserName);
            this.panel1.Controls.Add(this.PictureUserImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 571);
            this.panel1.TabIndex = 0;
            // 
            // ButtonsMenuPanel
            // 
            this.ButtonsMenuPanel.Controls.Add(this.ButtonDashboard);
            this.ButtonsMenuPanel.Controls.Add(this.ButtonAddProduct);
            this.ButtonsMenuPanel.Controls.Add(this.ButtonManageProduct);
            this.ButtonsMenuPanel.Controls.Add(this.ButtonTransaction);
            this.ButtonsMenuPanel.Controls.Add(this.ButtonSales);
            this.ButtonsMenuPanel.Controls.Add(this.ButtonUsers);
            this.ButtonsMenuPanel.Controls.Add(this.ButtonArchives);
            this.ButtonsMenuPanel.Controls.Add(this.ButtonLogout);
            this.ButtonsMenuPanel.Location = new System.Drawing.Point(0, 150);
            this.ButtonsMenuPanel.Name = "ButtonsMenuPanel";
            this.ButtonsMenuPanel.Size = new System.Drawing.Size(340, 417);
            this.ButtonsMenuPanel.TabIndex = 0;
            // 
            // ButtonDashboard
            // 
            this.ButtonDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonDashboard.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.ButtonDashboard.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ButtonDashboard.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ButtonDashboard.CheckedState.Image = global::FastFoodPOS.Properties.Resources.home_white;
            this.ButtonDashboard.CheckedState.Parent = this.ButtonDashboard;
            this.ButtonDashboard.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonDashboard.CustomImages.Parent = this.ButtonDashboard;
            this.ButtonDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonDashboard.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonDashboard.ForeColor = System.Drawing.Color.Gray;
            this.ButtonDashboard.HoverState.Parent = this.ButtonDashboard;
            this.ButtonDashboard.Image = global::FastFoodPOS.Properties.Resources.home_gray;
            this.ButtonDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonDashboard.ImageOffset = new System.Drawing.Point(20, 0);
            this.ButtonDashboard.Location = new System.Drawing.Point(0, 0);
            this.ButtonDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDashboard.Name = "ButtonDashboard";
            this.ButtonDashboard.ShadowDecoration.Parent = this.ButtonDashboard;
            this.ButtonDashboard.Size = new System.Drawing.Size(340, 45);
            this.ButtonDashboard.TabIndex = 9;
            this.ButtonDashboard.Tag = "1";
            this.ButtonDashboard.Text = "Dashboard";
            this.ButtonDashboard.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonAddProduct.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.ButtonAddProduct.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ButtonAddProduct.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ButtonAddProduct.CheckedState.Image = global::FastFoodPOS.Properties.Resources.burger_soda_plus_white;
            this.ButtonAddProduct.CheckedState.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonAddProduct.CustomImages.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonAddProduct.ForeColor = System.Drawing.Color.Gray;
            this.ButtonAddProduct.HoverState.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.Image = global::FastFoodPOS.Properties.Resources.burger_soda_plus_gray;
            this.ButtonAddProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonAddProduct.ImageOffset = new System.Drawing.Point(20, 0);
            this.ButtonAddProduct.Location = new System.Drawing.Point(0, 45);
            this.ButtonAddProduct.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.ShadowDecoration.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.Size = new System.Drawing.Size(340, 45);
            this.ButtonAddProduct.TabIndex = 10;
            this.ButtonAddProduct.Tag = "2";
            this.ButtonAddProduct.Text = "Add Product";
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // ButtonManageProduct
            // 
            this.ButtonManageProduct.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonManageProduct.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.ButtonManageProduct.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ButtonManageProduct.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ButtonManageProduct.CheckedState.Image = global::FastFoodPOS.Properties.Resources.burger_soda_white;
            this.ButtonManageProduct.CheckedState.Parent = this.ButtonManageProduct;
            this.ButtonManageProduct.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonManageProduct.CustomImages.Parent = this.ButtonManageProduct;
            this.ButtonManageProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonManageProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonManageProduct.ForeColor = System.Drawing.Color.Gray;
            this.ButtonManageProduct.HoverState.Parent = this.ButtonManageProduct;
            this.ButtonManageProduct.Image = global::FastFoodPOS.Properties.Resources.burger_soda_gray;
            this.ButtonManageProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonManageProduct.ImageOffset = new System.Drawing.Point(20, 0);
            this.ButtonManageProduct.Location = new System.Drawing.Point(0, 90);
            this.ButtonManageProduct.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonManageProduct.Name = "ButtonManageProduct";
            this.ButtonManageProduct.ShadowDecoration.Parent = this.ButtonManageProduct;
            this.ButtonManageProduct.Size = new System.Drawing.Size(340, 45);
            this.ButtonManageProduct.TabIndex = 8;
            this.ButtonManageProduct.Tag = "3";
            this.ButtonManageProduct.Text = "Manage Products";
            this.ButtonManageProduct.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // ButtonTransaction
            // 
            this.ButtonTransaction.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonTransaction.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.ButtonTransaction.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ButtonTransaction.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ButtonTransaction.CheckedState.Image = global::FastFoodPOS.Properties.Resources.receipt_white;
            this.ButtonTransaction.CheckedState.Parent = this.ButtonTransaction;
            this.ButtonTransaction.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonTransaction.CustomImages.Parent = this.ButtonTransaction;
            this.ButtonTransaction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonTransaction.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonTransaction.ForeColor = System.Drawing.Color.Gray;
            this.ButtonTransaction.HoverState.Parent = this.ButtonTransaction;
            this.ButtonTransaction.Image = global::FastFoodPOS.Properties.Resources.receipt_gray;
            this.ButtonTransaction.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonTransaction.ImageOffset = new System.Drawing.Point(20, 0);
            this.ButtonTransaction.Location = new System.Drawing.Point(0, 135);
            this.ButtonTransaction.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTransaction.Name = "ButtonTransaction";
            this.ButtonTransaction.ShadowDecoration.Parent = this.ButtonTransaction;
            this.ButtonTransaction.Size = new System.Drawing.Size(340, 45);
            this.ButtonTransaction.TabIndex = 11;
            this.ButtonTransaction.Tag = "4";
            this.ButtonTransaction.Text = "Transactions History";
            this.ButtonTransaction.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // ButtonSales
            // 
            this.ButtonSales.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonSales.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.ButtonSales.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ButtonSales.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ButtonSales.CheckedState.Image = global::FastFoodPOS.Properties.Resources.sales_white;
            this.ButtonSales.CheckedState.Parent = this.ButtonSales;
            this.ButtonSales.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonSales.CustomImages.Parent = this.ButtonSales;
            this.ButtonSales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonSales.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonSales.ForeColor = System.Drawing.Color.Gray;
            this.ButtonSales.HoverState.Parent = this.ButtonSales;
            this.ButtonSales.Image = global::FastFoodPOS.Properties.Resources.sales_gray;
            this.ButtonSales.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonSales.ImageOffset = new System.Drawing.Point(20, 0);
            this.ButtonSales.Location = new System.Drawing.Point(0, 180);
            this.ButtonSales.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSales.Name = "ButtonSales";
            this.ButtonSales.ShadowDecoration.Parent = this.ButtonSales;
            this.ButtonSales.Size = new System.Drawing.Size(340, 45);
            this.ButtonSales.TabIndex = 12;
            this.ButtonSales.Tag = "5";
            this.ButtonSales.Text = "Sales Report";
            this.ButtonSales.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // ButtonUsers
            // 
            this.ButtonUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonUsers.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.ButtonUsers.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ButtonUsers.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ButtonUsers.CheckedState.Image = global::FastFoodPOS.Properties.Resources.users_white;
            this.ButtonUsers.CheckedState.Parent = this.ButtonUsers;
            this.ButtonUsers.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonUsers.CustomImages.Parent = this.ButtonUsers;
            this.ButtonUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonUsers.ForeColor = System.Drawing.Color.Gray;
            this.ButtonUsers.HoverState.Parent = this.ButtonUsers;
            this.ButtonUsers.Image = global::FastFoodPOS.Properties.Resources.users_gray;
            this.ButtonUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonUsers.ImageOffset = new System.Drawing.Point(20, 0);
            this.ButtonUsers.Location = new System.Drawing.Point(0, 225);
            this.ButtonUsers.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUsers.Name = "ButtonUsers";
            this.ButtonUsers.ShadowDecoration.Parent = this.ButtonUsers;
            this.ButtonUsers.Size = new System.Drawing.Size(340, 45);
            this.ButtonUsers.TabIndex = 13;
            this.ButtonUsers.Tag = "6";
            this.ButtonUsers.Text = "Users";
            this.ButtonUsers.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // ButtonArchives
            // 
            this.ButtonArchives.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonArchives.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.ButtonArchives.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ButtonArchives.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ButtonArchives.CheckedState.Image = global::FastFoodPOS.Properties.Resources.archive_white;
            this.ButtonArchives.CheckedState.Parent = this.ButtonArchives;
            this.ButtonArchives.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonArchives.CustomImages.Parent = this.ButtonArchives;
            this.ButtonArchives.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonArchives.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonArchives.ForeColor = System.Drawing.Color.Gray;
            this.ButtonArchives.HoverState.Parent = this.ButtonArchives;
            this.ButtonArchives.Image = global::FastFoodPOS.Properties.Resources.archive_gray;
            this.ButtonArchives.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonArchives.ImageOffset = new System.Drawing.Point(20, 0);
            this.ButtonArchives.Location = new System.Drawing.Point(0, 270);
            this.ButtonArchives.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonArchives.Name = "ButtonArchives";
            this.ButtonArchives.ShadowDecoration.Parent = this.ButtonArchives;
            this.ButtonArchives.Size = new System.Drawing.Size(340, 45);
            this.ButtonArchives.TabIndex = 14;
            this.ButtonArchives.Tag = "7";
            this.ButtonArchives.Text = "Archives";
            this.ButtonArchives.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonLogout.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ButtonLogout.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ButtonLogout.CheckedState.Parent = this.ButtonLogout;
            this.ButtonLogout.CustomImages.Parent = this.ButtonLogout;
            this.ButtonLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonLogout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonLogout.ForeColor = System.Drawing.Color.Gray;
            this.ButtonLogout.HoverState.Parent = this.ButtonLogout;
            this.ButtonLogout.Image = global::FastFoodPOS.Properties.Resources.sign_out_gray;
            this.ButtonLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonLogout.ImageOffset = new System.Drawing.Point(20, 0);
            this.ButtonLogout.Location = new System.Drawing.Point(0, 315);
            this.ButtonLogout.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.ShadowDecoration.Parent = this.ButtonLogout;
            this.ButtonLogout.Size = new System.Drawing.Size(340, 45);
            this.ButtonLogout.TabIndex = 15;
            this.ButtonLogout.Text = "Logout";
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // ButtonUpdateInfo
            // 
            this.ButtonUpdateInfo.Animated = true;
            this.ButtonUpdateInfo.CheckedState.Parent = this.ButtonUpdateInfo;
            this.ButtonUpdateInfo.CustomImages.Parent = this.ButtonUpdateInfo;
            this.ButtonUpdateInfo.FillColor = System.Drawing.Color.Empty;
            this.ButtonUpdateInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonUpdateInfo.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdateInfo.HoverState.Parent = this.ButtonUpdateInfo;
            this.ButtonUpdateInfo.Location = new System.Drawing.Point(127, 82);
            this.ButtonUpdateInfo.Name = "ButtonUpdateInfo";
            this.ButtonUpdateInfo.ShadowDecoration.Parent = this.ButtonUpdateInfo;
            this.ButtonUpdateInfo.Size = new System.Drawing.Size(191, 20);
            this.ButtonUpdateInfo.TabIndex = 4;
            this.ButtonUpdateInfo.Text = "Update Info";
            this.ButtonUpdateInfo.Click += new System.EventHandler(this.ButtonUpdateInfo_Click);
            // 
            // LabelUserRole
            // 
            this.LabelUserRole.AutoSize = true;
            this.LabelUserRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserRole.ForeColor = System.Drawing.Color.LightGray;
            this.LabelUserRole.Location = new System.Drawing.Point(127, 54);
            this.LabelUserRole.Name = "LabelUserRole";
            this.LabelUserRole.Size = new System.Drawing.Size(106, 21);
            this.LabelUserRole.TabIndex = 1;
            this.LabelUserRole.Text = "Administrator";
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoEllipsis = true;
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserName.ForeColor = System.Drawing.Color.White;
            this.LabelUserName.Location = new System.Drawing.Point(127, 25);
            this.LabelUserName.MaximumSize = new System.Drawing.Size(196, 25);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(196, 25);
            this.LabelUserName.TabIndex = 1;
            this.LabelUserName.Text = "Lenard Mangay-ayam";
            // 
            // PictureUserImage
            // 
            this.PictureUserImage.Image = global::FastFoodPOS.Properties.Resources.user_default;
            this.PictureUserImage.Location = new System.Drawing.Point(21, 25);
            this.PictureUserImage.Name = "PictureUserImage";
            this.PictureUserImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureUserImage.ShadowDecoration.Parent = this.PictureUserImage;
            this.PictureUserImage.Size = new System.Drawing.Size(100, 100);
            this.PictureUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureUserImage.TabIndex = 0;
            this.PictureUserImage.TabStop = false;
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAdminPanel";
            this.Size = new System.Drawing.Size(816, 571);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ButtonsMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureUserImage;
        private System.Windows.Forms.Label LabelUserRole;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button ButtonUpdateInfo;
        private System.Windows.Forms.FlowLayoutPanel ButtonsMenuPanel;
        private Guna.UI2.WinForms.Guna2Button ButtonDashboard;
        private Guna.UI2.WinForms.Guna2Button ButtonAddProduct;
        private Guna.UI2.WinForms.Guna2Button ButtonManageProduct;
        private Guna.UI2.WinForms.Guna2Button ButtonTransaction;
        private Guna.UI2.WinForms.Guna2Button ButtonSales;
        private Guna.UI2.WinForms.Guna2Button ButtonUsers;
        private Guna.UI2.WinForms.Guna2Button ButtonArchives;
        private Guna.UI2.WinForms.Guna2Button ButtonLogout;
    }
}
