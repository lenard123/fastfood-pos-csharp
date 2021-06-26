namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormChangePassword
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
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.LinkBack = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelOldPassword = new System.Windows.Forms.Label();
            this.LabelConfirmPassword = new System.Windows.Forms.Label();
            this.LabelNewPassword = new System.Windows.Forms.Label();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.TextOldPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(219, 36);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 30);
            this.guna2VSeparator1.TabIndex = 12;
            // 
            // LinkBack
            // 
            this.LinkBack.AutoSize = true;
            this.LinkBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkBack.Location = new System.Drawing.Point(234, 42);
            this.LinkBack.Name = "LinkBack";
            this.LinkBack.Size = new System.Drawing.Size(59, 19);
            this.LinkBack.TabIndex = 11;
            this.LinkBack.TabStop = true;
            this.LinkBack.Text = "Go Back";
            this.LinkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkBack_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Change Password";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.LabelOldPassword);
            this.guna2Panel1.Controls.Add(this.LabelConfirmPassword);
            this.guna2Panel1.Controls.Add(this.LabelNewPassword);
            this.guna2Panel1.Controls.Add(this.ButtonSave);
            this.guna2Panel1.Controls.Add(this.TextOldPassword);
            this.guna2Panel1.Controls.Add(this.TextConfirmPassword);
            this.guna2Panel1.Controls.Add(this.TextNewPassword);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(41, 81);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(575, 450);
            this.guna2Panel1.TabIndex = 13;
            // 
            // LabelOldPassword
            // 
            this.LabelOldPassword.AutoSize = true;
            this.LabelOldPassword.ForeColor = System.Drawing.Color.Red;
            this.LabelOldPassword.Location = new System.Drawing.Point(31, 322);
            this.LabelOldPassword.Name = "LabelOldPassword";
            this.LabelOldPassword.Size = new System.Drawing.Size(29, 19);
            this.LabelOldPassword.TabIndex = 15;
            this.LabelOldPassword.Text = "red";
            // 
            // LabelConfirmPassword
            // 
            this.LabelConfirmPassword.AutoSize = true;
            this.LabelConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.LabelConfirmPassword.Location = new System.Drawing.Point(31, 209);
            this.LabelConfirmPassword.Name = "LabelConfirmPassword";
            this.LabelConfirmPassword.Size = new System.Drawing.Size(29, 19);
            this.LabelConfirmPassword.TabIndex = 15;
            this.LabelConfirmPassword.Text = "red";
            // 
            // LabelNewPassword
            // 
            this.LabelNewPassword.AutoSize = true;
            this.LabelNewPassword.ForeColor = System.Drawing.Color.Red;
            this.LabelNewPassword.Location = new System.Drawing.Point(31, 99);
            this.LabelNewPassword.Name = "LabelNewPassword";
            this.LabelNewPassword.Size = new System.Drawing.Size(29, 19);
            this.LabelNewPassword.TabIndex = 15;
            this.LabelNewPassword.Text = "red";
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
            this.ButtonSave.Location = new System.Drawing.Point(374, 373);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShadowDecoration.Parent = this.ButtonSave;
            this.ButtonSave.Size = new System.Drawing.Size(146, 45);
            this.ButtonSave.TabIndex = 14;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextOldPassword
            // 
            this.TextOldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextOldPassword.Animated = true;
            this.TextOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextOldPassword.DefaultText = "";
            this.TextOldPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextOldPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextOldPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextOldPassword.DisabledState.Parent = this.TextOldPassword;
            this.TextOldPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextOldPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextOldPassword.FocusedState.Parent = this.TextOldPassword;
            this.TextOldPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TextOldPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextOldPassword.HoverState.Parent = this.TextOldPassword;
            this.TextOldPassword.Location = new System.Drawing.Point(34, 284);
            this.TextOldPassword.Name = "TextOldPassword";
            this.TextOldPassword.PasswordChar = '\0';
            this.TextOldPassword.PlaceholderText = "";
            this.TextOldPassword.SelectedText = "";
            this.TextOldPassword.ShadowDecoration.Parent = this.TextOldPassword;
            this.TextOldPassword.Size = new System.Drawing.Size(486, 36);
            this.TextOldPassword.TabIndex = 10;
            this.TextOldPassword.UseSystemPasswordChar = true;
            // 
            // TextConfirmPassword
            // 
            this.TextConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextConfirmPassword.Animated = true;
            this.TextConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextConfirmPassword.DefaultText = "";
            this.TextConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextConfirmPassword.DisabledState.Parent = this.TextConfirmPassword;
            this.TextConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextConfirmPassword.FocusedState.Parent = this.TextConfirmPassword;
            this.TextConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TextConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextConfirmPassword.HoverState.Parent = this.TextConfirmPassword;
            this.TextConfirmPassword.Location = new System.Drawing.Point(34, 171);
            this.TextConfirmPassword.Name = "TextConfirmPassword";
            this.TextConfirmPassword.PasswordChar = '\0';
            this.TextConfirmPassword.PlaceholderText = "";
            this.TextConfirmPassword.SelectedText = "";
            this.TextConfirmPassword.ShadowDecoration.Parent = this.TextConfirmPassword;
            this.TextConfirmPassword.Size = new System.Drawing.Size(486, 36);
            this.TextConfirmPassword.TabIndex = 10;
            this.TextConfirmPassword.UseSystemPasswordChar = true;
            // 
            // TextNewPassword
            // 
            this.TextNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextNewPassword.Animated = true;
            this.TextNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextNewPassword.DefaultText = "";
            this.TextNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextNewPassword.DisabledState.Parent = this.TextNewPassword;
            this.TextNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextNewPassword.FocusedState.Parent = this.TextNewPassword;
            this.TextNewPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TextNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextNewPassword.HoverState.Parent = this.TextNewPassword;
            this.TextNewPassword.Location = new System.Drawing.Point(34, 60);
            this.TextNewPassword.Name = "TextNewPassword";
            this.TextNewPassword.PasswordChar = '\0';
            this.TextNewPassword.PlaceholderText = "";
            this.TextNewPassword.SelectedText = "";
            this.TextNewPassword.ShadowDecoration.Parent = this.TextNewPassword;
            this.TextNewPassword.Size = new System.Drawing.Size(486, 36);
            this.TextNewPassword.TabIndex = 10;
            this.TextNewPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Retype New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Password:";
            // 
            // FormChangePassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.LinkBack);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormChangePassword";
            this.Size = new System.Drawing.Size(891, 680);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.LinkLabel LinkBack;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label LabelConfirmPassword;
        private System.Windows.Forms.Label LabelNewPassword;
        private Guna.UI2.WinForms.Guna2Button ButtonSave;
        private Guna.UI2.WinForms.Guna2TextBox TextConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox TextNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelOldPassword;
        private Guna.UI2.WinForms.Guna2TextBox TextOldPassword;
        private System.Windows.Forms.Label label4;
    }
}
