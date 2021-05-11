﻿namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormAddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonReset = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonChangeImage = new Guna.UI2.WinForms.Guna2Button();
            this.PictureProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ToggleAvailability = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.ComboBoxType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New Product";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.ButtonReset);
            this.guna2Panel1.Controls.Add(this.ButtonSave);
            this.guna2Panel1.Controls.Add(this.ButtonChangeImage);
            this.guna2Panel1.Controls.Add(this.PictureProductImage);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.ToggleAvailability);
            this.guna2Panel1.Controls.Add(this.ComboBoxType);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.TextPrice);
            this.guna2Panel1.Controls.Add(this.TextName);
            this.guna2Panel1.Location = new System.Drawing.Point(35, 85);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(712, 418);
            this.guna2Panel1.TabIndex = 3;
            // 
            // ButtonReset
            // 
            this.ButtonReset.Animated = true;
            this.ButtonReset.BorderColor = System.Drawing.Color.LightGray;
            this.ButtonReset.BorderThickness = 1;
            this.ButtonReset.CheckedState.Parent = this.ButtonReset;
            this.ButtonReset.CustomImages.Parent = this.ButtonReset;
            this.ButtonReset.FillColor = System.Drawing.Color.White;
            this.ButtonReset.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ButtonReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonReset.HoverState.Parent = this.ButtonReset;
            this.ButtonReset.Location = new System.Drawing.Point(303, 355);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.ShadowDecoration.Parent = this.ButtonReset;
            this.ButtonReset.Size = new System.Drawing.Size(180, 45);
            this.ButtonReset.TabIndex = 7;
            this.ButtonReset.Text = "Reset";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Animated = true;
            this.ButtonSave.CheckedState.Parent = this.ButtonSave;
            this.ButtonSave.CustomImages.Parent = this.ButtonSave;
            this.ButtonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.HoverState.Parent = this.ButtonSave;
            this.ButtonSave.Location = new System.Drawing.Point(507, 355);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShadowDecoration.Parent = this.ButtonSave;
            this.ButtonSave.Size = new System.Drawing.Size(180, 45);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
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
            this.ButtonChangeImage.Location = new System.Drawing.Point(18, 240);
            this.ButtonChangeImage.Name = "ButtonChangeImage";
            this.ButtonChangeImage.ShadowDecoration.Parent = this.ButtonChangeImage;
            this.ButtonChangeImage.Size = new System.Drawing.Size(239, 27);
            this.ButtonChangeImage.TabIndex = 6;
            this.ButtonChangeImage.Text = "Change Image";
            // 
            // PictureProductImage
            // 
            this.PictureProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureProductImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PictureProductImage.Image = global::FastFoodPOS.Properties.Resources.icon_placeholder;
            this.PictureProductImage.Location = new System.Drawing.Point(18, 52);
            this.PictureProductImage.Name = "PictureProductImage";
            this.PictureProductImage.ShadowDecoration.Parent = this.PictureProductImage;
            this.PictureProductImage.Size = new System.Drawing.Size(239, 185);
            this.PictureProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureProductImage.TabIndex = 5;
            this.PictureProductImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Image Preview";
            // 
            // ToggleAvailability
            // 
            this.ToggleAvailability.Animated = true;
            this.ToggleAvailability.Checked = true;
            this.ToggleAvailability.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleAvailability.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleAvailability.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleAvailability.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleAvailability.CheckedState.Parent = this.ToggleAvailability;
            this.ToggleAvailability.Location = new System.Drawing.Point(400, 307);
            this.ToggleAvailability.Name = "ToggleAvailability";
            this.ToggleAvailability.ShadowDecoration.Parent = this.ToggleAvailability;
            this.ToggleAvailability.Size = new System.Drawing.Size(35, 20);
            this.ToggleAvailability.TabIndex = 3;
            this.ToggleAvailability.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleAvailability.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleAvailability.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleAvailability.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleAvailability.UncheckedState.Parent = this.ToggleAvailability;
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxType.Animated = true;
            this.ComboBoxType.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxType.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxType.FocusedState.Parent = this.ComboBoxType;
            this.ComboBoxType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.HoverState.Parent = this.ComboBoxType;
            this.ComboBoxType.ItemHeight = 30;
            this.ComboBoxType.Items.AddRange(new object[] {
            "Food",
            "Drink",
            "Dessert",
            "Snack",
            "Package"});
            this.ComboBoxType.ItemsAppearance.Parent = this.ComboBoxType;
            this.ComboBoxType.Location = new System.Drawing.Point(303, 149);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.ShadowDecoration.Parent = this.ComboBoxType;
            this.ComboBoxType.Size = new System.Drawing.Size(384, 36);
            this.ComboBoxType.StartIndex = 0;
            this.ComboBoxType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ComboBoxType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Is Available?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product Name:";
            // 
            // TextPrice
            // 
            this.TextPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPrice.Animated = true;
            this.TextPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextPrice.DefaultText = "";
            this.TextPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPrice.DisabledState.Parent = this.TextPrice;
            this.TextPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPrice.FocusedState.Parent = this.TextPrice;
            this.TextPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPrice.HoverState.Parent = this.TextPrice;
            this.TextPrice.Location = new System.Drawing.Point(303, 240);
            this.TextPrice.Name = "TextPrice";
            this.TextPrice.PasswordChar = '\0';
            this.TextPrice.PlaceholderText = "";
            this.TextPrice.SelectedText = "";
            this.TextPrice.ShadowDecoration.Parent = this.TextPrice;
            this.TextPrice.Size = new System.Drawing.Size(384, 36);
            this.TextPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextPrice.TabIndex = 0;
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
            this.TextName.Location = new System.Drawing.Point(303, 52);
            this.TextName.Name = "TextName";
            this.TextName.PasswordChar = '\0';
            this.TextName.PlaceholderText = "(e.g. Hamburger)";
            this.TextName.SelectedText = "";
            this.TextName.ShadowDecoration.Parent = this.TextName;
            this.TextName.Size = new System.Drawing.Size(384, 36);
            this.TextName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextName.TabIndex = 0;
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAddProduct";
            this.Size = new System.Drawing.Size(786, 740);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextPrice;
        private Guna.UI2.WinForms.Guna2PictureBox PictureProductImage;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleAvailability;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TextName;
        private Guna.UI2.WinForms.Guna2Button ButtonChangeImage;
        private Guna.UI2.WinForms.Guna2Button ButtonSave;
        private Guna.UI2.WinForms.Guna2Button ButtonReset;
    }
}