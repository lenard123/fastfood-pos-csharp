namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormSalesReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimeStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimeEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.CartesianChartSales = new LiveCharts.WinForms.CartesianChart();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sales Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(39, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Date:";
            // 
            // DateTimeStart
            // 
            this.DateTimeStart.AutoRoundedCorners = true;
            this.DateTimeStart.BorderRadius = 12;
            this.DateTimeStart.CheckedState.Parent = this.DateTimeStart;
            this.DateTimeStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.DateTimeStart.ForeColor = System.Drawing.Color.Black;
            this.DateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimeStart.HoverState.Parent = this.DateTimeStart;
            this.DateTimeStart.Location = new System.Drawing.Point(119, 83);
            this.DateTimeStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimeStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimeStart.Name = "DateTimeStart";
            this.DateTimeStart.ShadowDecoration.Parent = this.DateTimeStart;
            this.DateTimeStart.Size = new System.Drawing.Size(175, 27);
            this.DateTimeStart.TabIndex = 8;
            this.DateTimeStart.Value = new System.DateTime(2021, 5, 14, 8, 41, 33, 985);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(35, 63);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(946, 10);
            this.guna2Separator1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(726, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Date:";
            // 
            // DateTimeEnd
            // 
            this.DateTimeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimeEnd.AutoRoundedCorners = true;
            this.DateTimeEnd.BorderRadius = 12;
            this.DateTimeEnd.CheckedState.Parent = this.DateTimeEnd;
            this.DateTimeEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.DateTimeEnd.ForeColor = System.Drawing.Color.Black;
            this.DateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimeEnd.HoverState.Parent = this.DateTimeEnd;
            this.DateTimeEnd.Location = new System.Drawing.Point(806, 83);
            this.DateTimeEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimeEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimeEnd.Name = "DateTimeEnd";
            this.DateTimeEnd.ShadowDecoration.Parent = this.DateTimeEnd;
            this.DateTimeEnd.Size = new System.Drawing.Size(175, 27);
            this.DateTimeEnd.TabIndex = 8;
            this.DateTimeEnd.Value = new System.DateTime(2021, 5, 14, 8, 41, 33, 985);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.AutoScroll = true;
            this.guna2Panel4.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.guna2Panel4.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.CartesianChartSales);
            this.guna2Panel4.Location = new System.Drawing.Point(35, 136);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(946, 268);
            this.guna2Panel4.TabIndex = 10;
            // 
            // CartesianChartSales
            // 
            this.CartesianChartSales.BackColor = System.Drawing.Color.Transparent;
            this.CartesianChartSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartesianChartSales.Location = new System.Drawing.Point(0, 0);
            this.CartesianChartSales.Name = "CartesianChartSales";
            this.CartesianChartSales.Size = new System.Drawing.Size(946, 268);
            this.CartesianChartSales.TabIndex = 3;
            this.CartesianChartSales.Text = "cartesianChart1";
            // 
            // FormSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.DateTimeEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTimeStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormSalesReport";
            this.Size = new System.Drawing.Size(1037, 528);
            this.Load += new System.EventHandler(this.FormSalesReport_Load);
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeStart;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeEnd;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private LiveCharts.WinForms.CartesianChart CartesianChartSales;
    }
}
