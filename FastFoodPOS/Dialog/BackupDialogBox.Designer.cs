namespace FastFoodPOS.Dialog
{
    partial class BackupDialogBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupDialogBox));
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStart = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonNo = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSuccess = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelLoading.SuspendLayout();
            this.panelSuccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 54);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup Data";
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnStart.CheckedState.Parent = this.BtnStart;
            this.BtnStart.CustomImages.Parent = this.BtnStart;
            this.BtnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.BtnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.HoverState.Parent = this.BtnStart;
            this.BtnStart.Image = ((System.Drawing.Image)(resources.GetObject("BtnStart.Image")));
            this.BtnStart.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnStart.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnStart.Location = new System.Drawing.Point(164, 73);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.ShadowDecoration.Parent = this.BtnStart;
            this.BtnStart.Size = new System.Drawing.Size(180, 41);
            this.BtnStart.TabIndex = 14;
            this.BtnStart.Text = "Start Backup";
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(26, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Backup database to excel file?";
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
            this.ButtonNo.Location = new System.Drawing.Point(33, 73);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.ShadowDecoration.Parent = this.ButtonNo;
            this.ButtonNo.Size = new System.Drawing.Size(125, 41);
            this.ButtonNo.TabIndex = 16;
            this.ButtonNo.Text = "Cancel";
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelButton);
            this.panel2.Controls.Add(this.panelSuccess);
            this.panel2.Controls.Add(this.panelLoading);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 136);
            this.panel2.TabIndex = 17;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.label2);
            this.panelButton.Controls.Add(this.ButtonNo);
            this.panelButton.Controls.Add(this.BtnStart);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(369, 136);
            this.panelButton.TabIndex = 17;
            // 
            // panelLoading
            // 
            this.panelLoading.Controls.Add(this.guna2WinProgressIndicator1);
            this.panelLoading.Controls.Add(this.label3);
            this.panelLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoading.Location = new System.Drawing.Point(0, 0);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(369, 136);
            this.panelLoading.TabIndex = 17;
            this.panelLoading.Visible = false;
            // 
            // guna2WinProgressIndicator1
            // 
            this.guna2WinProgressIndicator1.AutoStart = true;
            this.guna2WinProgressIndicator1.CircleSize = 1F;
            this.guna2WinProgressIndicator1.Location = new System.Drawing.Point(30, 35);
            this.guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            this.guna2WinProgressIndicator1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.guna2WinProgressIndicator1.Size = new System.Drawing.Size(50, 50);
            this.guna2WinProgressIndicator1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(102, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Backing up data please wait...";
            // 
            // panelSuccess
            // 
            this.panelSuccess.Controls.Add(this.guna2Button1);
            this.panelSuccess.Controls.Add(this.lblFilename);
            this.panelSuccess.Controls.Add(this.label5);
            this.panelSuccess.Controls.Add(this.label4);
            this.panelSuccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSuccess.Location = new System.Drawing.Point(0, 0);
            this.panelSuccess.Name = "panelSuccess";
            this.panelSuccess.Size = new System.Drawing.Size(369, 136);
            this.panelSuccess.TabIndex = 17;
            this.panelSuccess.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.label4.Location = new System.Drawing.Point(26, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Backup Created Successfully";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(26, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Filename: ";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFilename.ForeColor = System.Drawing.Color.Gray;
            this.lblFilename.Location = new System.Drawing.Point(108, 50);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(76, 20);
            this.lblFilename.TabIndex = 17;
            this.lblFilename.Text = "Filename: ";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button1.BorderRadius = 19;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(106, 83);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(146, 41);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Close";
            this.guna2Button1.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // BackupDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 190);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackupDialogBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackupDialogBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.panelLoading.ResumeLayout(false);
            this.panelLoading.PerformLayout();
            this.panelSuccess.ResumeLayout(false);
            this.panelSuccess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button ButtonNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelSuccess;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}