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
using System.Drawing.Printing;

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
            PrintForm printForm1 = new PrintForm(this);
            printForm1.Show();
        }

        class PrintForm : Form
        {

            PrintPreviewDialog printDialog1;
            PrintDocument printDocument1;
            ProcessOrder parent;
            Point oldPosition;
            Guna.UI2.WinForms.Guna2HtmlLabel content;

            public PrintForm(ProcessOrder parent)
            {
                content = parent.guna2HtmlLabel1;

                this.parent = parent;
                this.oldPosition = new Point(content.Location.X, content.Location.Y);

                this.BackColor = Color.White;
                ShowInTaskbar = false;
                FormBorderStyle = FormBorderStyle.None;
                StartPosition = FormStartPosition.CenterScreen;
                Size = new Size(content.Size.Width + 15, content.Size.Height + 30);
                Controls.Add(content);
                content.Location = new Point(15, 15);

                printDialog1 = new PrintPreviewDialog();
                printDocument1 = new PrintDocument();

                printDialog1.Document = printDocument1;
                printDocument1.PrintPage += printDocument1_PrintPage;

                this.Load += PrintForm_Load;

                //printDialog1.ShowDialog();
            }

            void PrintForm_Load(object sender, EventArgs e)
            {
                printDialog1.ShowDialog();

                parent.guna2Panel1.Controls.Add(content);

                content.Location = oldPosition;

                Dispose();

            }

            void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
            {
                Bitmap img = new Bitmap(this.Size.Width, this.Size.Height);
                this.DrawToBitmap(img, this.DisplayRectangle);
                e.Graphics.DrawImage(img, new Point(100, 100));
            }
        }

    }
}
