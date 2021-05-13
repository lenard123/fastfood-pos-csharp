namespace FastFoodPOS.Components
{
    partial class OrderItemComponent
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
            this.LabelSubtotal = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelQuantity = new System.Windows.Forms.Label();
            this.ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonMinus = new Guna.UI2.WinForms.Guna2Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel6.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelSubtotal
            // 
            this.LabelSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LabelSubtotal.ForeColor = System.Drawing.Color.Maroon;
            this.LabelSubtotal.Location = new System.Drawing.Point(292, 3);
            this.LabelSubtotal.Name = "LabelSubtotal";
            this.LabelSubtotal.Size = new System.Drawing.Size(105, 33);
            this.LabelSubtotal.TabIndex = 3;
            this.LabelSubtotal.Text = "5000.00PHP";
            this.LabelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.guna2Panel1);
            this.panel6.Controls.Add(this.ButtonAdd);
            this.panel6.Controls.Add(this.ButtonMinus);
            this.panel6.Location = new System.Drawing.Point(170, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(118, 31);
            this.panel6.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.Controls.Add(this.LabelQuantity);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(39, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(42, 31);
            this.guna2Panel1.TabIndex = 2;
            // 
            // LabelQuantity
            // 
            this.LabelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.LabelQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelQuantity.Location = new System.Drawing.Point(0, 0);
            this.LabelQuantity.Name = "LabelQuantity";
            this.LabelQuantity.Size = new System.Drawing.Size(42, 31);
            this.LabelQuantity.TabIndex = 0;
            this.LabelQuantity.Text = "3";
            this.LabelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BorderColor = System.Drawing.Color.Gray;
            this.ButtonAdd.CheckedState.Parent = this.ButtonAdd;
            this.ButtonAdd.CustomBorderColor = System.Drawing.Color.LightGray;
            this.ButtonAdd.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.ButtonAdd.CustomImages.Parent = this.ButtonAdd;
            this.ButtonAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonAdd.FillColor = System.Drawing.Color.White;
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAdd.ForeColor = System.Drawing.Color.Black;
            this.ButtonAdd.HoverState.Parent = this.ButtonAdd;
            this.ButtonAdd.Location = new System.Drawing.Point(81, 0);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.ShadowDecoration.Parent = this.ButtonAdd;
            this.ButtonAdd.Size = new System.Drawing.Size(37, 31);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            this.ButtonAdd.DoubleClick += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.BorderColor = System.Drawing.Color.Gray;
            this.ButtonMinus.CheckedState.Parent = this.ButtonMinus;
            this.ButtonMinus.CustomBorderColor = System.Drawing.Color.LightGray;
            this.ButtonMinus.CustomBorderThickness = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.ButtonMinus.CustomImages.Parent = this.ButtonMinus;
            this.ButtonMinus.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonMinus.FillColor = System.Drawing.Color.White;
            this.ButtonMinus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonMinus.ForeColor = System.Drawing.Color.Black;
            this.ButtonMinus.HoverState.Parent = this.ButtonMinus;
            this.ButtonMinus.Location = new System.Drawing.Point(0, 0);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.ShadowDecoration.Parent = this.ButtonMinus;
            this.ButtonMinus.Size = new System.Drawing.Size(39, 31);
            this.ButtonMinus.TabIndex = 0;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            this.ButtonMinus.DoubleClick += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // LabelName
            // 
            this.LabelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelName.Location = new System.Drawing.Point(3, 5);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(161, 31);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Customer Order";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Separator2.Location = new System.Drawing.Point(7, 39);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(390, 10);
            this.guna2Separator2.TabIndex = 8;
            // 
            // OrderItemComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.LabelSubtotal);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OrderItemComponent";
            this.Size = new System.Drawing.Size(400, 48);
            this.panel6.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelSubtotal;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button ButtonAdd;
        private Guna.UI2.WinForms.Guna2Button ButtonMinus;
        private System.Windows.Forms.Label LabelName;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label LabelQuantity;
    }
}
