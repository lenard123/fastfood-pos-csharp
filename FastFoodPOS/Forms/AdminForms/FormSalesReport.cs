using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using FastFoodPOS.Models;
using LiveCharts.Wpf;

namespace FastFoodPOS.Forms.AdminForms
{
    public partial class FormSalesReport : UserControl
    {
        public FormSalesReport()
        {
            InitializeComponent();

            DateTimeStart.MaxDate = DateTime.Now.Date;
            DateTimeEnd.MaxDate = DateTime.Now.Date;
            DateTimeEnd.Value = DateTime.Now.Date;

            DateTimeStart.ValueChanged += this.DateTimeRange_ValueChanged;
            DateTimeEnd.ValueChanged += this.DateTimeRange_ValueChanged;

            DateTimeStart.Value = DateTime.Now.AddDays(-6).Date;
        }

        private void FormSalesReport_Load(object sender, EventArgs e)
        {
            CartesianChartSales.Visible = false;
            CartesianChartSales.Visible = true;

            CartesianChartSales.AxisY.Add(new LiveCharts.Wpf.Axis{
                Title = "Sales",
                LabelFormatter = value => value.ToString() + "PHP"
            });
        }

        private void DateTimeRange_ValueChanged(object sender, EventArgs e)
        {
            DateTimeStart.MaxDate = DateTimeEnd.Value;
            DateTimeEnd.MinDate = DateTimeStart.Value;

            CartesianChartSales.Series.Clear();
            CartesianChartSales.AxisX.Clear();

            CartesianChartSales.AxisX.Add(new LiveCharts.Wpf.Axis{
                Title = "Date",
                Labels = Sale.GetDaysLabel(DateTimeStart.Value, DateTimeEnd.Value)
            });

            List<Sale> sales = Sale.GetSalesBetween(DateTimeStart.Value, DateTimeEnd.Value);
            List<decimal> values = new List<decimal>();
            DateTime i = DateTimeStart.Value.Date;
            while (!i.Equals(DateTimeEnd.Value.AddDays(1).Date))
            {
                decimal value = 0;
                Sale sale = sales.FirstOrDefault((isale) => isale.Date.Equals(i));
                if (sale != null) value = sale.Value;
                values.Add(value);
                i = i.AddDays(1);
            }

            CartesianChartSales.Series.Add(new LineSeries { 
                Title = "Sales",
                Values = new ChartValues<decimal>(values)
            });
        }

        private void BtnBackupData_Click(object sender, EventArgs e)
        {

        }
    }
}
