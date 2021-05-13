namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormUsers
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
            this.ButtonAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelUsers = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Users";
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddUser.CheckedState.Parent = this.ButtonAddUser;
            this.ButtonAddUser.CustomImages.Parent = this.ButtonAddUser;
            this.ButtonAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ButtonAddUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ButtonAddUser.ForeColor = System.Drawing.Color.White;
            this.ButtonAddUser.HoverState.Parent = this.ButtonAddUser;
            this.ButtonAddUser.Location = new System.Drawing.Point(35, 457);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.ShadowDecoration.Parent = this.ButtonAddUser;
            this.ButtonAddUser.Size = new System.Drawing.Size(180, 45);
            this.ButtonAddUser.TabIndex = 8;
            this.ButtonAddUser.Text = "Add New User";
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.PanelUsers);
            this.guna2Panel1.Location = new System.Drawing.Point(35, 74);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(652, 365);
            this.guna2Panel1.TabIndex = 9;
            // 
            // PanelUsers
            // 
            this.PanelUsers.AutoSize = true;
            this.PanelUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelUsers.BackColor = System.Drawing.Color.Transparent;
            this.PanelUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUsers.Location = new System.Drawing.Point(0, 0);
            this.PanelUsers.MinimumSize = new System.Drawing.Size(625, 0);
            this.PanelUsers.Name = "PanelUsers";
            this.PanelUsers.Size = new System.Drawing.Size(652, 0);
            this.PanelUsers.TabIndex = 0;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ButtonAddUser);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormUsers";
            this.Size = new System.Drawing.Size(731, 528);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ButtonAddUser;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel PanelUsers;
    }
}
