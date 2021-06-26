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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUserImage)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            this.LinkLabelName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelName_LinkClicked);
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
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 468);
            this.panel2.TabIndex = 2;
            // 
            // FormCashierPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormCashierPanel";
            this.Size = new System.Drawing.Size(1010, 520);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonLogout;
        private System.Windows.Forms.LinkLabel LinkLabelName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureUserImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}
