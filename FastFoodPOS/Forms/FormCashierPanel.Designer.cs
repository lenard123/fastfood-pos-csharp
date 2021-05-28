namespace FastFoodPOS.Forms
{
    partial class FormCashierPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonLogout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LinkLabelName = new System.Windows.Forms.LinkLabel();
            this.PictureUserImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonsMenu = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonDesserts = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonPackages = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSnacks = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonFoods = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonDrinks = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.TextQuery = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelOrders = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.ButtonClear = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonProccess = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCalculateChange = new Guna.UI2.WinForms.Guna2Button();
            this.LabelChange = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextPayment = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUserImage)).BeginInit();
            this.ButtonsMenu.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.ButtonLogout);
            this.panel1.Controls.Add(this.LinkLabelName);
            this.panel1.Controls.Add(this.PictureUserImage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 52);
            this.panel1.TabIndex = 0;
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLogout.CheckedState.Parent = this.ButtonLogout;
            this.ButtonLogout.HoverState.Parent = this.ButtonLogout;
            this.ButtonLogout.Image = global::FastFoodPOS.Properties.Resources.sign_out_right_white;
            this.ButtonLogout.Location = new System.Drawing.Point(965, 10);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.PressedState.Parent = this.ButtonLogout;
            this.ButtonLogout.Size = new System.Drawing.Size(31, 30);
            this.ButtonLogout.TabIndex = 7;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // LinkLabelName
            // 
            this.LinkLabelName.AutoSize = true;
            this.LinkLabelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LinkLabelName.LinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.LinkLabelName.Location = new System.Drawing.Point(128, 16);
            this.LinkLabelName.Name = "LinkLabelName";
            this.LinkLabelName.Size = new System.Drawing.Size(176, 21);
            this.LinkLabelName.TabIndex = 6;
            this.LinkLabelName.TabStop = true;
            this.LinkLabelName.Text = "Lenard Mangay-ayam";
            // 
            // PictureUserImage
            // 
            this.PictureUserImage.Image = global::FastFoodPOS.Properties.Resources.user_default;
            this.PictureUserImage.Location = new System.Drawing.Point(7, 6);
            this.PictureUserImage.Name = "PictureUserImage";
            this.PictureUserImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureUserImage.ShadowDecoration.Parent = this.PictureUserImage;
            this.PictureUserImage.Size = new System.Drawing.Size(40, 40);
            this.PictureUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureUserImage.TabIndex = 5;
            this.PictureUserImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(53, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome,";
            // 
            // ButtonsMenu
            // 
            this.ButtonsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsMenu.ColumnCount = 5;
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.Controls.Add(this.ButtonDesserts, 0, 0);
            this.ButtonsMenu.Controls.Add(this.ButtonPackages, 0, 0);
            this.ButtonsMenu.Controls.Add(this.ButtonSnacks, 0, 0);
            this.ButtonsMenu.Controls.Add(this.ButtonFoods, 0, 0);
            this.ButtonsMenu.Controls.Add(this.ButtonDrinks, 0, 0);
            this.ButtonsMenu.Location = new System.Drawing.Point(3, 3);
            this.ButtonsMenu.Name = "ButtonsMenu";
            this.ButtonsMenu.RowCount = 1;
            this.ButtonsMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsMenu.Size = new System.Drawing.Size(515, 60);
            this.ButtonsMenu.TabIndex = 7;
            // 
            // ButtonDesserts
            // 
            this.ButtonDesserts.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonDesserts.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonDesserts.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonDesserts.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.ButtonDesserts.CheckedState.Parent = this.ButtonDesserts;
            this.ButtonDesserts.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ButtonDesserts.CustomImages.Parent = this.ButtonDesserts;
            this.ButtonDesserts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDesserts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonDesserts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDesserts.ForeColor = System.Drawing.Color.DarkGray;
            this.ButtonDesserts.HoverState.Parent = this.ButtonDesserts;
            this.ButtonDesserts.Image = global::FastFoodPOS.Properties.Resources.icecream;
            this.ButtonDesserts.Location = new System.Drawing.Point(309, 0);
            this.ButtonDesserts.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDesserts.Name = "ButtonDesserts";
            this.ButtonDesserts.ShadowDecoration.Parent = this.ButtonDesserts;
            this.ButtonDesserts.Size = new System.Drawing.Size(103, 60);
            this.ButtonDesserts.TabIndex = 5;
            this.ButtonDesserts.Tag = "Dessert";
            this.ButtonDesserts.Text = "Desserts";
            this.ButtonDesserts.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // ButtonPackages
            // 
            this.ButtonPackages.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonPackages.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonPackages.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonPackages.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.ButtonPackages.CheckedState.Parent = this.ButtonPackages;
            this.ButtonPackages.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ButtonPackages.CustomImages.Parent = this.ButtonPackages;
            this.ButtonPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPackages.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonPackages.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonPackages.ForeColor = System.Drawing.Color.DarkGray;
            this.ButtonPackages.HoverState.Parent = this.ButtonPackages;
            this.ButtonPackages.Image = global::FastFoodPOS.Properties.Resources.burger_soda_black;
            this.ButtonPackages.Location = new System.Drawing.Point(412, 0);
            this.ButtonPackages.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPackages.Name = "ButtonPackages";
            this.ButtonPackages.ShadowDecoration.Parent = this.ButtonPackages;
            this.ButtonPackages.Size = new System.Drawing.Size(103, 60);
            this.ButtonPackages.TabIndex = 4;
            this.ButtonPackages.Tag = "Package";
            this.ButtonPackages.Text = "Packages";
            this.ButtonPackages.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // ButtonSnacks
            // 
            this.ButtonSnacks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonSnacks.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonSnacks.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonSnacks.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.ButtonSnacks.CheckedState.Parent = this.ButtonSnacks;
            this.ButtonSnacks.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ButtonSnacks.CustomImages.Parent = this.ButtonSnacks;
            this.ButtonSnacks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSnacks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonSnacks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSnacks.ForeColor = System.Drawing.Color.DarkGray;
            this.ButtonSnacks.HoverState.Parent = this.ButtonSnacks;
            this.ButtonSnacks.Image = global::FastFoodPOS.Properties.Resources.burger;
            this.ButtonSnacks.Location = new System.Drawing.Point(206, 0);
            this.ButtonSnacks.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSnacks.Name = "ButtonSnacks";
            this.ButtonSnacks.ShadowDecoration.Parent = this.ButtonSnacks;
            this.ButtonSnacks.Size = new System.Drawing.Size(103, 60);
            this.ButtonSnacks.TabIndex = 3;
            this.ButtonSnacks.Tag = "Snack";
            this.ButtonSnacks.Text = "Snacks";
            this.ButtonSnacks.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // ButtonFoods
            // 
            this.ButtonFoods.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonFoods.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonFoods.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonFoods.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.ButtonFoods.CheckedState.Parent = this.ButtonFoods;
            this.ButtonFoods.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ButtonFoods.CustomImages.Parent = this.ButtonFoods;
            this.ButtonFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonFoods.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonFoods.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonFoods.ForeColor = System.Drawing.Color.DarkGray;
            this.ButtonFoods.HoverState.Parent = this.ButtonFoods;
            this.ButtonFoods.Image = global::FastFoodPOS.Properties.Resources.soup;
            this.ButtonFoods.Location = new System.Drawing.Point(0, 0);
            this.ButtonFoods.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonFoods.Name = "ButtonFoods";
            this.ButtonFoods.ShadowDecoration.Parent = this.ButtonFoods;
            this.ButtonFoods.Size = new System.Drawing.Size(103, 60);
            this.ButtonFoods.TabIndex = 2;
            this.ButtonFoods.Tag = "Food";
            this.ButtonFoods.Text = "Foods";
            this.ButtonFoods.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // ButtonDrinks
            // 
            this.ButtonDrinks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonDrinks.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonDrinks.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonDrinks.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.ButtonDrinks.CheckedState.Parent = this.ButtonDrinks;
            this.ButtonDrinks.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ButtonDrinks.CustomImages.Parent = this.ButtonDrinks;
            this.ButtonDrinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDrinks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonDrinks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDrinks.ForeColor = System.Drawing.Color.DarkGray;
            this.ButtonDrinks.HoverState.Parent = this.ButtonDrinks;
            this.ButtonDrinks.Image = global::FastFoodPOS.Properties.Resources.glass;
            this.ButtonDrinks.Location = new System.Drawing.Point(103, 0);
            this.ButtonDrinks.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDrinks.Name = "ButtonDrinks";
            this.ButtonDrinks.ShadowDecoration.Parent = this.ButtonDrinks;
            this.ButtonDrinks.Size = new System.Drawing.Size(103, 60);
            this.ButtonDrinks.TabIndex = 1;
            this.ButtonDrinks.Tag = "Drink";
            this.ButtonDrinks.Text = "Drinks";
            this.ButtonDrinks.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.ButtonsMenu);
            this.guna2Panel1.Location = new System.Drawing.Point(7, 58);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(521, 451);
            this.guna2Panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.PanelProducts);
            this.panel3.Location = new System.Drawing.Point(13, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 321);
            this.panel3.TabIndex = 9;
            // 
            // PanelProducts
            // 
            this.PanelProducts.AutoSize = true;
            this.PanelProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProducts.Location = new System.Drawing.Point(0, 0);
            this.PanelProducts.MinimumSize = new System.Drawing.Size(500, 0);
            this.PanelProducts.Name = "PanelProducts";
            this.PanelProducts.Size = new System.Drawing.Size(500, 0);
            this.PanelProducts.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.AutoRoundedCorners = true;
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel3.BorderRadius = 19;
            this.guna2Panel3.Controls.Add(this.TextQuery);
            this.guna2Panel3.Controls.Add(this.ButtonSearch);
            this.guna2Panel3.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.guna2Panel3.Location = new System.Drawing.Point(13, 73);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(494, 40);
            this.guna2Panel3.TabIndex = 8;
            // 
            // TextQuery
            // 
            this.TextQuery.Animated = true;
            this.TextQuery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextQuery.DefaultText = "";
            this.TextQuery.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextQuery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextQuery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextQuery.DisabledState.Parent = this.TextQuery;
            this.TextQuery.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextQuery.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextQuery.FocusedState.Parent = this.TextQuery;
            this.TextQuery.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextQuery.HoverState.Parent = this.TextQuery;
            this.TextQuery.Location = new System.Drawing.Point(0, 0);
            this.TextQuery.Margin = new System.Windows.Forms.Padding(0);
            this.TextQuery.Name = "TextQuery";
            this.TextQuery.PasswordChar = '\0';
            this.TextQuery.PlaceholderText = "Search for menu";
            this.TextQuery.SelectedText = "";
            this.TextQuery.ShadowDecoration.Parent = this.TextQuery;
            this.TextQuery.Size = new System.Drawing.Size(417, 40);
            this.TextQuery.TabIndex = 3;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.CheckedState.Parent = this.ButtonSearch;
            this.ButtonSearch.CustomImages.Parent = this.ButtonSearch;
            this.ButtonSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSearch.ForeColor = System.Drawing.Color.Black;
            this.ButtonSearch.HoverState.Parent = this.ButtonSearch;
            this.ButtonSearch.Location = new System.Drawing.Point(417, 0);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.ShadowDecoration.Parent = this.ButtonSearch;
            this.ButtonSearch.Size = new System.Drawing.Size(77, 40);
            this.ButtonSearch.TabIndex = 4;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.panel4);
            this.guna2Panel2.Controls.Add(this.guna2Separator1);
            this.guna2Panel2.Controls.Add(this.ButtonClear);
            this.guna2Panel2.Controls.Add(this.panel2);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Location = new System.Drawing.Point(534, 58);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(462, 451);
            this.guna2Panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.AutoScroll = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.PanelOrders);
            this.panel4.Location = new System.Drawing.Point(10, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(436, 156);
            this.panel4.TabIndex = 7;
            // 
            // PanelOrders
            // 
            this.PanelOrders.AutoSize = true;
            this.PanelOrders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelOrders.Location = new System.Drawing.Point(0, 0);
            this.PanelOrders.Name = "PanelOrders";
            this.PanelOrders.Size = new System.Drawing.Size(436, 0);
            this.PanelOrders.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(14, 54);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(429, 10);
            this.guna2Separator1.TabIndex = 6;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonClear.CheckedState.Parent = this.ButtonClear;
            this.ButtonClear.CustomImages.Parent = this.ButtonClear;
            this.ButtonClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonClear.ForeColor = System.Drawing.Color.Black;
            this.ButtonClear.HoverState.Parent = this.ButtonClear;
            this.ButtonClear.Location = new System.Drawing.Point(10, 244);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.ShadowDecoration.Parent = this.ButtonClear;
            this.ButtonClear.Size = new System.Drawing.Size(439, 40);
            this.ButtonClear.TabIndex = 5;
            this.ButtonClear.Text = "Clear Order";
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.ButtonProccess);
            this.panel2.Controls.Add(this.ButtonCalculateChange);
            this.panel2.Controls.Add(this.LabelChange);
            this.panel2.Controls.Add(this.LabelTotal);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TextPayment);
            this.panel2.Location = new System.Drawing.Point(10, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 153);
            this.panel2.TabIndex = 2;
            // 
            // ButtonProccess
            // 
            this.ButtonProccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonProccess.CheckedState.Parent = this.ButtonProccess;
            this.ButtonProccess.CustomImages.Parent = this.ButtonProccess;
            this.ButtonProccess.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ButtonProccess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonProccess.ForeColor = System.Drawing.Color.White;
            this.ButtonProccess.HoverState.Parent = this.ButtonProccess;
            this.ButtonProccess.Location = new System.Drawing.Point(0, 113);
            this.ButtonProccess.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonProccess.Name = "ButtonProccess";
            this.ButtonProccess.ShadowDecoration.Parent = this.ButtonProccess;
            this.ButtonProccess.Size = new System.Drawing.Size(439, 40);
            this.ButtonProccess.TabIndex = 6;
            this.ButtonProccess.Text = "Process Order";
            this.ButtonProccess.Click += new System.EventHandler(this.ButtonProccess_Click);
            // 
            // ButtonCalculateChange
            // 
            this.ButtonCalculateChange.Animated = true;
            this.ButtonCalculateChange.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCalculateChange.BorderThickness = 1;
            this.ButtonCalculateChange.CheckedState.Parent = this.ButtonCalculateChange;
            this.ButtonCalculateChange.CustomImages.Parent = this.ButtonCalculateChange;
            this.ButtonCalculateChange.FillColor = System.Drawing.Color.White;
            this.ButtonCalculateChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCalculateChange.ForeColor = System.Drawing.Color.DimGray;
            this.ButtonCalculateChange.HoverState.Parent = this.ButtonCalculateChange;
            this.ButtonCalculateChange.Location = new System.Drawing.Point(314, 37);
            this.ButtonCalculateChange.Name = "ButtonCalculateChange";
            this.ButtonCalculateChange.ShadowDecoration.Parent = this.ButtonCalculateChange;
            this.ButtonCalculateChange.Size = new System.Drawing.Size(122, 36);
            this.ButtonCalculateChange.TabIndex = 2;
            this.ButtonCalculateChange.Text = "Calculate Change";
            this.ButtonCalculateChange.Click += new System.EventHandler(this.ButtonCalculateChange_Click);
            // 
            // LabelChange
            // 
            this.LabelChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelChange.AutoSize = true;
            this.LabelChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelChange.ForeColor = System.Drawing.Color.Red;
            this.LabelChange.Location = new System.Drawing.Point(91, 80);
            this.LabelChange.Name = "LabelChange";
            this.LabelChange.Size = new System.Drawing.Size(51, 21);
            this.LabelChange.TabIndex = 0;
            this.LabelChange.Text = "0PHP";
            // 
            // LabelTotal
            // 
            this.LabelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelTotal.ForeColor = System.Drawing.Color.Red;
            this.LabelTotal.Location = new System.Drawing.Point(91, 10);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(91, 21);
            this.LabelTotal.TabIndex = 0;
            this.LabelTotal.Text = "200.25PHP";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(3, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Change: ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(3, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Payment: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Price: ";
            // 
            // TextPayment
            // 
            this.TextPayment.BackColor = System.Drawing.Color.Transparent;
            this.TextPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextPayment.DecimalPlaces = 2;
            this.TextPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPayment.DisabledState.Parent = this.TextPayment;
            this.TextPayment.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.TextPayment.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.TextPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPayment.FocusedState.Parent = this.TextPayment;
            this.TextPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TextPayment.ForeColor = System.Drawing.Color.Red;
            this.TextPayment.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.TextPayment.Location = new System.Drawing.Point(95, 37);
            this.TextPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextPayment.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.TextPayment.Name = "TextPayment";
            this.TextPayment.ShadowDecoration.Parent = this.TextPayment;
            this.TextPayment.Size = new System.Drawing.Size(213, 36);
            this.TextPayment.TabIndex = 1;
            this.TextPayment.ThousandsSeparator = true;
            this.TextPayment.UpDownButtonBorderVisible = false;
            this.TextPayment.UpDownButtonFillColor = System.Drawing.Color.LightGray;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::FastFoodPOS.Properties.Resources.mcdonalds;
            this.guna2PictureBox1.Location = new System.Drawing.Point(14, 21);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Order";
            // 
            // FormCashierPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormCashierPanel";
            this.Size = new System.Drawing.Size(1010, 520);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUserImage)).EndInit();
            this.ButtonsMenu.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureUserImage;
        private System.Windows.Forms.LinkLabel LinkLabelName;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonLogout;
        private System.Windows.Forms.TableLayoutPanel ButtonsMenu;
        private Guna.UI2.WinForms.Guna2Button ButtonDesserts;
        private Guna.UI2.WinForms.Guna2Button ButtonPackages;
        private Guna.UI2.WinForms.Guna2Button ButtonSnacks;
        private Guna.UI2.WinForms.Guna2Button ButtonFoods;
        private Guna.UI2.WinForms.Guna2Button ButtonDrinks;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2TextBox TextQuery;
        private Guna.UI2.WinForms.Guna2Button ButtonSearch;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button ButtonClear;
        private Guna.UI2.WinForms.Guna2Button ButtonCalculateChange;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button ButtonProccess;
        private System.Windows.Forms.Label LabelChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel PanelProducts;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PanelOrders;
        private Guna.UI2.WinForms.Guna2NumericUpDown TextPayment;
    }
}
