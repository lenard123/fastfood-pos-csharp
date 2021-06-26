namespace FastFoodPOS.Forms
{
    partial class FormAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminLogin));
            this.ButtonHelp = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ButtonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.VisibilityToggler = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TextPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHelp.CheckedState.Parent = this.ButtonHelp;
            this.ButtonHelp.CustomImages.Parent = this.ButtonHelp;
            this.ButtonHelp.FillColor = System.Drawing.Color.Transparent;
            this.ButtonHelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonHelp.ForeColor = System.Drawing.Color.White;
            this.ButtonHelp.HoverState.Parent = this.ButtonHelp;
            this.ButtonHelp.Image = global::FastFoodPOS.Properties.Resources.question_circle_gray;
            this.ButtonHelp.ImageSize = new System.Drawing.Size(15, 15);
            this.ButtonHelp.Location = new System.Drawing.Point(797, 0);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.ShadowDecoration.Parent = this.ButtonHelp;
            this.ButtonHelp.Size = new System.Drawing.Size(23, 23);
            this.ButtonHelp.TabIndex = 8;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(826, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(23, 23);
            this.guna2ControlBox1.TabIndex = 7;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BorderRadius = 20;
            this.ButtonLogin.CheckedState.Parent = this.ButtonLogin;
            this.ButtonLogin.CustomImages.Parent = this.ButtonLogin;
            this.ButtonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ButtonLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.HoverState.Parent = this.ButtonLogin;
            this.ButtonLogin.Location = new System.Drawing.Point(406, 391);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.ShadowDecoration.Parent = this.ButtonLogin;
            this.ButtonLogin.Size = new System.Drawing.Size(402, 45);
            this.ButtonLogin.TabIndex = 2;
            this.ButtonLogin.Text = "LOGIN";
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.VisibilityToggler);
            this.guna2Panel2.Controls.Add(this.pictureBox2);
            this.guna2Panel2.Controls.Add(this.TextPassword);
            this.guna2Panel2.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.Location = new System.Drawing.Point(406, 319);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(402, 43);
            this.guna2Panel2.TabIndex = 1;
            // 
            // VisibilityToggler
            // 
            this.VisibilityToggler.BackColor = System.Drawing.SystemColors.Control;
            this.VisibilityToggler.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.VisibilityToggler.CheckedState.Image = global::FastFoodPOS.Properties.Resources.hide;
            this.VisibilityToggler.CheckedState.Parent = this.VisibilityToggler;
            this.VisibilityToggler.CustomImages.Parent = this.VisibilityToggler;
            this.VisibilityToggler.FillColor = System.Drawing.SystemColors.Control;
            this.VisibilityToggler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VisibilityToggler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.VisibilityToggler.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.VisibilityToggler.HoverState.ForeColor = System.Drawing.SystemColors.Control;
            this.VisibilityToggler.HoverState.Parent = this.VisibilityToggler;
            this.VisibilityToggler.Image = global::FastFoodPOS.Properties.Resources.show;
            this.VisibilityToggler.Location = new System.Drawing.Point(367, 12);
            this.VisibilityToggler.Name = "VisibilityToggler";
            this.VisibilityToggler.PressedColor = System.Drawing.Color.Transparent;
            this.VisibilityToggler.PressedDepth = 0;
            this.VisibilityToggler.ShadowDecoration.Parent = this.VisibilityToggler;
            this.VisibilityToggler.Size = new System.Drawing.Size(20, 20);
            this.VisibilityToggler.TabIndex = 5;
            this.VisibilityToggler.Click += new System.EventHandler(this.VisibilityToggler_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::FastFoodPOS.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(17, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // TextPassword
            // 
            this.TextPassword.BorderThickness = 0;
            this.TextPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextPassword.DefaultText = "";
            this.TextPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPassword.DisabledState.Parent = this.TextPassword;
            this.TextPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPassword.FillColor = System.Drawing.SystemColors.Control;
            this.TextPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPassword.FocusedState.Parent = this.TextPassword;
            this.TextPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPassword.HoverState.Parent = this.TextPassword;
            this.TextPassword.Location = new System.Drawing.Point(43, 7);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '\0';
            this.TextPassword.PlaceholderText = "Enter your password here";
            this.TextPassword.SelectedText = "";
            this.TextPassword.ShadowDecoration.Parent = this.TextPassword;
            this.TextPassword.Size = new System.Drawing.Size(318, 33);
            this.TextPassword.TabIndex = 0;
            this.TextPassword.UseSystemPasswordChar = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.TextEmail);
            this.guna2Panel1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.Location = new System.Drawing.Point(406, 261);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(402, 43);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::FastFoodPOS.Properties.Resources.email;
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TextEmail
            // 
            this.TextEmail.BorderThickness = 0;
            this.TextEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextEmail.DefaultText = "";
            this.TextEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextEmail.DisabledState.Parent = this.TextEmail;
            this.TextEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextEmail.FillColor = System.Drawing.SystemColors.Control;
            this.TextEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextEmail.FocusedState.Parent = this.TextEmail;
            this.TextEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextEmail.HoverState.Parent = this.TextEmail;
            this.TextEmail.Location = new System.Drawing.Point(43, 5);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.PasswordChar = '\0';
            this.TextEmail.PlaceholderText = "Enter your email here";
            this.TextEmail.SelectedText = "";
            this.TextEmail.ShadowDecoration.Parent = this.TextEmail;
            this.TextEmail.Size = new System.Drawing.Size(344, 33);
            this.TextEmail.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(552, 97);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(125, 118);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 523);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(167, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "WcDonald\'s POS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FastFoodPOS.Properties.Resources.mcdonalds;
            this.pictureBox4.Location = new System.Drawing.Point(86, 73);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(178, 158);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // FormAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAdminLogin";
            this.Size = new System.Drawing.Size(850, 523);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox TextEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox TextPassword;
        private Guna.UI2.WinForms.Guna2Button ButtonLogin;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button VisibilityToggler;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button ButtonHelp;
    }
}
