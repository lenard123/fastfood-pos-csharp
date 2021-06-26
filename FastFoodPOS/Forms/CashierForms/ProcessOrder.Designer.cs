namespace FastFoodPOS.Forms.CashierForms
{
    partial class ProcessOrder
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonClose = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonPrint = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Successful Transaction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(17, 121);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(357, 373);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(14, 15);
            this.guna2HtmlLabel1.MaximumSize = new System.Drawing.Size(330, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = null;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.ButtonClose);
            this.guna2Panel2.Controls.Add(this.ButtonPrint);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(394, 586);
            this.guna2Panel2.TabIndex = 2;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BorderColor = System.Drawing.Color.Silver;
            this.ButtonClose.BorderThickness = 1;
            this.ButtonClose.CheckedState.Parent = this.ButtonClose;
            this.ButtonClose.CustomImages.Parent = this.ButtonClose;
            this.ButtonClose.FillColor = System.Drawing.Color.White;
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonClose.HoverState.Parent = this.ButtonClose;
            this.ButtonClose.Location = new System.Drawing.Point(203, 512);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.ShadowDecoration.Parent = this.ButtonClose;
            this.ButtonClose.Size = new System.Drawing.Size(171, 45);
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.Text = "Close Window";
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.CheckedState.Parent = this.ButtonPrint;
            this.ButtonPrint.CustomImages.Parent = this.ButtonPrint;
            this.ButtonPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ButtonPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonPrint.ForeColor = System.Drawing.Color.White;
            this.ButtonPrint.HoverState.Parent = this.ButtonPrint;
            this.ButtonPrint.Location = new System.Drawing.Point(17, 512);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.ShadowDecoration.Parent = this.ButtonPrint;
            this.ButtonPrint.Size = new System.Drawing.Size(171, 45);
            this.ButtonPrint.TabIndex = 3;
            this.ButtonPrint.Text = "Print Receipt";
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2Panel3.CustomBorderThickness = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(394, 100);
            this.guna2Panel3.TabIndex = 2;
            // 
            // ProcessOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProcessOrder";
            this.Size = new System.Drawing.Size(394, 586);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button ButtonClose;
        private Guna.UI2.WinForms.Guna2Button ButtonPrint;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;

    }
}
