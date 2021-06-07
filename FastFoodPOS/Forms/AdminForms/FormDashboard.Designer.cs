namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelOrderCount = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelTotalSales = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelCustomerCount = new System.Windows.Forms.Label();
            this.CartesianChartWeekSales = new LiveCharts.WinForms.CartesianChart();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnBackupData = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(71)))));
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.LabelOrderCount);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(71)))));
            this.guna2Panel1.Location = new System.Drawing.Point(32, 30);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(298, 137);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Foods Sold Today";
            // 
            // LabelOrderCount
            // 
            this.LabelOrderCount.AutoSize = true;
            this.LabelOrderCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOrderCount.ForeColor = System.Drawing.Color.White;
            this.LabelOrderCount.Location = new System.Drawing.Point(19, 42);
            this.LabelOrderCount.Name = "LabelOrderCount";
            this.LabelOrderCount.Size = new System.Drawing.Size(74, 45);
            this.LabelOrderCount.TabIndex = 0;
            this.LabelOrderCount.Text = "234";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Brown;
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.LabelTotalSales);
            this.guna2Panel2.FillColor = System.Drawing.Color.Brown;
            this.guna2Panel2.Location = new System.Drawing.Point(365, 30);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(298, 137);
            this.guna2Panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(23, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Today\'s Total Sale";
            // 
            // LabelTotalSales
            // 
            this.LabelTotalSales.AutoSize = true;
            this.LabelTotalSales.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalSales.ForeColor = System.Drawing.Color.White;
            this.LabelTotalSales.Location = new System.Drawing.Point(19, 42);
            this.LabelTotalSales.Name = "LabelTotalSales";
            this.LabelTotalSales.Size = new System.Drawing.Size(121, 45);
            this.LabelTotalSales.TabIndex = 0;
            this.LabelTotalSales.Text = "P7,430";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.guna2Panel3.Controls.Add(this.label7);
            this.guna2Panel3.Controls.Add(this.label8);
            this.guna2Panel3.Controls.Add(this.LabelCustomerCount);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.guna2Panel3.Location = new System.Drawing.Point(702, 30);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(298, 137);
            this.guna2Panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Customers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(23, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "No. of customers visited";
            // 
            // LabelCustomerCount
            // 
            this.LabelCustomerCount.AutoSize = true;
            this.LabelCustomerCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomerCount.ForeColor = System.Drawing.Color.White;
            this.LabelCustomerCount.Location = new System.Drawing.Point(19, 42);
            this.LabelCustomerCount.Name = "LabelCustomerCount";
            this.LabelCustomerCount.Size = new System.Drawing.Size(121, 45);
            this.LabelCustomerCount.TabIndex = 0;
            this.LabelCustomerCount.Text = "P7,430";
            // 
            // CartesianChartWeekSales
            // 
            this.CartesianChartWeekSales.BackColor = System.Drawing.Color.Transparent;
            this.CartesianChartWeekSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartesianChartWeekSales.Location = new System.Drawing.Point(0, 0);
            this.CartesianChartWeekSales.Name = "CartesianChartWeekSales";
            this.CartesianChartWeekSales.Size = new System.Drawing.Size(968, 280);
            this.CartesianChartWeekSales.TabIndex = 3;
            this.CartesianChartWeekSales.Text = "cartesianChart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(353, 45);
            this.label10.TabIndex = 5;
            this.label10.Text = "Sales for the last 7 days";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.AutoScroll = true;
            this.guna2Panel4.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.guna2Panel4.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.CartesianChartWeekSales);
            this.guna2Panel4.Location = new System.Drawing.Point(32, 250);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(968, 280);
            this.guna2Panel4.TabIndex = 4;
            // 
            // BtnBackupData
            // 
            this.BtnBackupData.CheckedState.Parent = this.BtnBackupData;
            this.BtnBackupData.CustomImages.Parent = this.BtnBackupData;
            this.BtnBackupData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.BtnBackupData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnBackupData.ForeColor = System.Drawing.Color.White;
            this.BtnBackupData.HoverState.Parent = this.BtnBackupData;
            this.BtnBackupData.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackupData.Image")));
            this.BtnBackupData.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnBackupData.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnBackupData.Location = new System.Drawing.Point(32, 556);
            this.BtnBackupData.Name = "BtnBackupData";
            this.BtnBackupData.ShadowDecoration.Parent = this.BtnBackupData;
            this.BtnBackupData.Size = new System.Drawing.Size(180, 41);
            this.BtnBackupData.TabIndex = 14;
            this.BtnBackupData.Text = "Backup Data";
            this.BtnBackupData.Click += new System.EventHandler(this.BtnBackupData_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnBackupData);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDashboard";
            this.Size = new System.Drawing.Size(1091, 839);
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label LabelOrderCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelTotalSales;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LabelCustomerCount;
        private LiveCharts.WinForms.CartesianChart CartesianChartWeekSales;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button BtnBackupData;
    }
}
