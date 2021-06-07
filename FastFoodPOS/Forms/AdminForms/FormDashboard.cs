using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodPOS.Models;
using LiveCharts;
using LiveCharts.Wpf;

namespace FastFoodPOS.Forms.AdminForms
{
    public partial class FormDashboard : UserControl
    {
        List<Sale> sales;
        public FormDashboard()
        {
            InitializeComponent();
            RefreshWeekSales();
            RefreshCardData();
        }

        private void RefreshCardData()
        {
            Sale today_sale = sales.FirstOrDefault((sale) => sale.Date.Date.Equals(DateTime.Now.Date));
            if (today_sale == null) today_sale = Sale.GetSale(DateTime.Now);
            LabelOrderCount.Text = today_sale.OrderCount.ToString();
            LabelTotalSales.Text = today_sale.Value.ToString() + "PHP";
            LabelCustomerCount.Text = today_sale.CustomerCount.ToString();
        }

        private void RefreshWeekSales()
        {
            CartesianChartWeekSales.Series.Clear();
            sales = Sale.GetSalesFromLastWeek();
            SeriesCollection series = new SeriesCollection();
            List<decimal> values = new List<decimal>();
            DateTime today = DateTime.Now;
            for (int i = 6; i >= 0; i--)
            {
                decimal value = 0;
                Sale iSale = sales.FirstOrDefault((sale) => sale.Date.Date.Equals(today.AddDays(-i).Date));
                if (iSale != null) value = iSale.Value;
                values.Add(value);
            }
            series.Add(new LineSeries()
            {
                Title = "Total Sales",
                Values = new ChartValues<decimal>(values)
            });
            CartesianChartWeekSales.Series = series;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            /**
             *  the chart turns into black and why
             *  and this fixed it.
             *  I don't understand why
             */
            CartesianChartWeekSales.Visible = false;
            CartesianChartWeekSales.Visible = true;

            CartesianChartWeekSales.AxisX.ToString();
            CartesianChartWeekSales.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Days",
                Labels = Sale.GetDaysLabelFromLastWeek()
            });
            CartesianChartWeekSales.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Sales",
                LabelFormatter = value => value.ToString() + "PHP"
            });
        }

        private void BtnBackupData_Click(object sender, EventArgs e)
        {
            (new Dialog.BackupDialogBox()).ShowDialog();
        }
    }
}
