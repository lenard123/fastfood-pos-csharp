namespace FastFoodPOS.Dialog
{
    partial class ConfirmDialogBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonYes = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonNo = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirm";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 77);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // ButtonYes
            // 
            this.ButtonYes.CheckedState.Parent = this.ButtonYes;
            this.ButtonYes.CustomImages.Parent = this.ButtonYes;
            this.ButtonYes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ButtonYes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonYes.ForeColor = System.Drawing.Color.White;
            this.ButtonYes.HoverState.Parent = this.ButtonYes;
            this.ButtonYes.Location = new System.Drawing.Point(240, 171);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.ShadowDecoration.Parent = this.ButtonYes;
            this.ButtonYes.Size = new System.Drawing.Size(125, 38);
            this.ButtonYes.TabIndex = 2;
            this.ButtonYes.Text = "YES";
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // ButtonNo
            // 
            this.ButtonNo.BorderColor = System.Drawing.Color.Gray;
            this.ButtonNo.BorderThickness = 1;
            this.ButtonNo.CheckedState.Parent = this.ButtonNo;
            this.ButtonNo.CustomImages.Parent = this.ButtonNo;
            this.ButtonNo.FillColor = System.Drawing.Color.White;
            this.ButtonNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonNo.ForeColor = System.Drawing.Color.Gray;
            this.ButtonNo.HoverState.Parent = this.ButtonNo;
            this.ButtonNo.Location = new System.Drawing.Point(109, 171);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.ShadowDecoration.Parent = this.ButtonNo;
            this.ButtonNo.Size = new System.Drawing.Size(125, 38);
            this.ButtonNo.TabIndex = 2;
            this.ButtonNo.Text = "NO";
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // ConfirmDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 231);
            this.Controls.Add(this.ButtonNo);
            this.Controls.Add(this.ButtonYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmDialogBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button ButtonYes;
        private Guna.UI2.WinForms.Guna2Button ButtonNo;

    }
}