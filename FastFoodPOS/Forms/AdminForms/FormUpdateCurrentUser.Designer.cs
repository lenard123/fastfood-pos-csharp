namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormUpdateCurrentUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateCurrentUser));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonReset = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.TextEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonChangeImage = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureUserImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.OpenFileDialogChangeImage = new System.Windows.Forms.OpenFileDialog();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Update Info";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.LabelEmail);
            this.guna2Panel1.Controls.Add(this.LabelName);
            this.guna2Panel1.Controls.Add(this.ButtonSave);
            this.guna2Panel1.Controls.Add(this.ButtonReset);
            this.guna2Panel1.Controls.Add(this.ButtonChangePassword);
            this.guna2Panel1.Controls.Add(this.TextEmail);
            this.guna2Panel1.Controls.Add(this.TextName);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.ButtonChangeImage);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.PictureUserImage);
            this.guna2Panel1.Location = new System.Drawing.Point(34, 76);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(575, 576);
            this.guna2Panel1.TabIndex = 5;
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.ForeColor = System.Drawing.Color.Red;
            this.LabelEmail.Location = new System.Drawing.Point(51, 465);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(24, 13);
            this.LabelEmail.TabIndex = 15;
            this.LabelEmail.Text = "red";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.ForeColor = System.Drawing.Color.Red;
            this.LabelName.Location = new System.Drawing.Point(51, 366);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(24, 13);
            this.LabelName.TabIndex = 15;
            this.LabelName.Text = "red";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSave.CheckedState.Parent = this.ButtonSave;
            this.ButtonSave.CustomImages.Parent = this.ButtonSave;
            this.ButtonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.HoverState.Parent = this.ButtonSave;
            this.ButtonSave.Location = new System.Drawing.Point(394, 505);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShadowDecoration.Parent = this.ButtonSave;
            this.ButtonSave.Size = new System.Drawing.Size(146, 45);
            this.ButtonSave.TabIndex = 14;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonReset.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonReset.BorderThickness = 1;
            this.ButtonReset.CheckedState.Parent = this.ButtonReset;
            this.ButtonReset.CustomImages.Parent = this.ButtonReset;
            this.ButtonReset.FillColor = System.Drawing.Color.White;
            this.ButtonReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonReset.HoverState.Parent = this.ButtonReset;
            this.ButtonReset.Location = new System.Drawing.Point(54, 505);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.ShadowDecoration.Parent = this.ButtonReset;
            this.ButtonReset.Size = new System.Drawing.Size(146, 45);
            this.ButtonReset.TabIndex = 13;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonChangePassword
            // 
            this.ButtonChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonChangePassword.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonChangePassword.BorderThickness = 1;
            this.ButtonChangePassword.CheckedState.Parent = this.ButtonChangePassword;
            this.ButtonChangePassword.CustomImages.Parent = this.ButtonChangePassword;
            this.ButtonChangePassword.FillColor = System.Drawing.Color.White;
            this.ButtonChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonChangePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonChangePassword.HoverState.Parent = this.ButtonChangePassword;
            this.ButtonChangePassword.Location = new System.Drawing.Point(224, 505);
            this.ButtonChangePassword.Name = "ButtonChangePassword";
            this.ButtonChangePassword.ShadowDecoration.Parent = this.ButtonChangePassword;
            this.ButtonChangePassword.Size = new System.Drawing.Size(146, 45);
            this.ButtonChangePassword.TabIndex = 13;
            this.ButtonChangePassword.Text = "Change Password";
            this.ButtonChangePassword.Click += new System.EventHandler(this.ButtonChangePassword_Click);
            // 
            // TextEmail
            // 
            this.TextEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextEmail.Animated = true;
            this.TextEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextEmail.DefaultText = "";
            this.TextEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextEmail.DisabledState.Parent = this.TextEmail;
            this.TextEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextEmail.FocusedState.Parent = this.TextEmail;
            this.TextEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextEmail.HoverState.Parent = this.TextEmail;
            this.TextEmail.Location = new System.Drawing.Point(54, 426);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.PasswordChar = '\0';
            this.TextEmail.PlaceholderText = "(e.g. johndoe@domain.com)";
            this.TextEmail.SelectedText = "";
            this.TextEmail.ShadowDecoration.Parent = this.TextEmail;
            this.TextEmail.Size = new System.Drawing.Size(486, 36);
            this.TextEmail.TabIndex = 10;
            // 
            // TextName
            // 
            this.TextName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextName.Animated = true;
            this.TextName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextName.DefaultText = "";
            this.TextName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextName.DisabledState.Parent = this.TextName;
            this.TextName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextName.FocusedState.Parent = this.TextName;
            this.TextName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextName.HoverState.Parent = this.TextName;
            this.TextName.Location = new System.Drawing.Point(54, 327);
            this.TextName.Name = "TextName";
            this.TextName.PasswordChar = '\0';
            this.TextName.PlaceholderText = "(e.g. John Doe)";
            this.TextName.SelectedText = "";
            this.TextName.ShadowDecoration.Parent = this.TextName;
            this.TextName.Size = new System.Drawing.Size(486, 36);
            this.TextName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // ButtonChangeImage
            // 
            this.ButtonChangeImage.Animated = true;
            this.ButtonChangeImage.BorderColor = System.Drawing.Color.LightGray;
            this.ButtonChangeImage.BorderThickness = 1;
            this.ButtonChangeImage.CheckedState.Parent = this.ButtonChangeImage;
            this.ButtonChangeImage.CustomImages.Parent = this.ButtonChangeImage;
            this.ButtonChangeImage.FillColor = System.Drawing.Color.White;
            this.ButtonChangeImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonChangeImage.ForeColor = System.Drawing.Color.Gray;
            this.ButtonChangeImage.HoverState.Parent = this.ButtonChangeImage;
            this.ButtonChangeImage.Location = new System.Drawing.Point(155, 228);
            this.ButtonChangeImage.Name = "ButtonChangeImage";
            this.ButtonChangeImage.ShadowDecoration.Parent = this.ButtonChangeImage;
            this.ButtonChangeImage.Size = new System.Drawing.Size(239, 36);
            this.ButtonChangeImage.TabIndex = 9;
            this.ButtonChangeImage.Text = "Change Image";
            this.ButtonChangeImage.Click += new System.EventHandler(this.ButtonChangeImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fullname";
            // 
            // PictureUserImage
            // 
            this.PictureUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureUserImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PictureUserImage.ImageLocation = "";
            this.PictureUserImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureUserImage.InitialImage")));
            this.PictureUserImage.Location = new System.Drawing.Point(155, 37);
            this.PictureUserImage.Name = "PictureUserImage";
            this.PictureUserImage.ShadowDecoration.Parent = this.PictureUserImage;
            this.PictureUserImage.Size = new System.Drawing.Size(239, 185);
            this.PictureUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureUserImage.TabIndex = 8;
            this.PictureUserImage.TabStop = false;
            // 
            // OpenFileDialogChangeImage
            // 
            this.OpenFileDialogChangeImage.Filter = "Image Files|*.jpg;*.png;*.jpeg";
            this.OpenFileDialogChangeImage.RestoreDirectory = true;
            // 
            // FormUpdateCurrentUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormUpdateCurrentUser";
            this.Size = new System.Drawing.Size(813, 720);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelName;
        private Guna.UI2.WinForms.Guna2Button ButtonSave;
        private Guna.UI2.WinForms.Guna2Button ButtonReset;
        private Guna.UI2.WinForms.Guna2Button ButtonChangePassword;
        private Guna.UI2.WinForms.Guna2TextBox TextEmail;
        private Guna.UI2.WinForms.Guna2TextBox TextName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button ButtonChangeImage;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox PictureUserImage;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogChangeImage;
    }
}
