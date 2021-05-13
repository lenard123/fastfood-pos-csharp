using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodPOS.Components;
using FastFoodPOS.Models;

namespace FastFoodPOS.Forms.CashierForms
{
    partial class ProcessOrder : UserControl
    {
        Form formDialog;
        Transaction transaction;

        public ProcessOrder(Transaction transaction)
        {
            InitializeComponent();
            this.transaction = transaction;
            Dock = DockStyle.Fill;
            printDocument1.PrintPage +=printDocument1_PrintPage;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            formDialog.Dispose();
        }

        public void ShowDialog()
        {
            formDialog = new Form();
            formDialog.Size = Size;
            formDialog.Controls.Add(this);
            formDialog.ShowInTaskbar = false;
            formDialog.FormBorderStyle = FormBorderStyle.None;
            formDialog.StartPosition = FormStartPosition.CenterScreen;
            guna2HtmlLabel1.Text = ReceiptTemplate.GetReceipt(transaction);
            formDialog.ShowDialog();

        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap img = new Bitmap(guna2Panel1.Size.Width, guna2Panel1.Size.Height);
            guna2Panel1.DrawToBitmap(img, guna2Panel1.DisplayRectangle);
            e.Graphics.DrawImage(img, new Point(100, 100));
        }
    }
}
