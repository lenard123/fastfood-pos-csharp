namespace FastFoodPOS.Forms
{
    partial class FormLoading
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FastFoodPOS.Properties.Resources.mcdonalds;
            this.pictureBox4.Location = new System.Drawing.Point(100, 90);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(178, 158);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fast Food Restaurant \r\nPOS System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2WinProgressIndicator1
            // 
            this.guna2WinProgressIndicator1.AutoStart = true;
            this.guna2WinProgressIndicator1.CircleSize = 1F;
            this.guna2WinProgressIndicator1.Location = new System.Drawing.Point(158, 417);
            this.guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            this.guna2WinProgressIndicator1.ProgressColor = System.Drawing.Color.White;
            this.guna2WinProgressIndicator1.Size = new System.Drawing.Size(56, 56);
            this.guna2WinProgressIndicator1.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2WinProgressIndicator1);
            this.guna2GradientPanel1.Controls.Add(this.pictureBox4);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(2)))), ((int)(((byte)(18)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(389, 501);
            this.guna2GradientPanel1.TabIndex = 4;
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "FormLoading";
            this.Size = new System.Drawing.Size(389, 501);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;

    }
}
