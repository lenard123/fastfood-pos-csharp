using ClosedXML.Excel;
using FastFoodPOS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodPOS.Dialog
{
    public partial class BackupDialogBox : Form
    {
        

        public BackupDialogBox()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            panelButton.Visible = false;
            panelLoading.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            DataTable usersTable, productsTable, transactionsTable, ordersTable;
            
            usersTable = new DataTable();
            usersTable.Columns.Add("id");
            usersTable.Columns.Add("fullname");
            usersTable.Columns.Add("email");
            usersTable.Columns.Add("password");
            usersTable.Columns.Add("role");
            usersTable.Columns.Add("is_deleted");

            productsTable = new DataTable();
            productsTable.Columns.Add("id");
            productsTable.Columns.Add("name");
            productsTable.Columns.Add("category");
            productsTable.Columns.Add("price");
            productsTable.Columns.Add("is_available");
            productsTable.Columns.Add("is_deleted");

            transactionsTable = new DataTable();
            transactionsTable.Columns.Add("id");
            transactionsTable.Columns.Add("user_id");
            transactionsTable.Columns.Add("date_created");
            transactionsTable.Columns.Add("cash");

            ordersTable = new DataTable();
            ordersTable.Columns.Add("id");
            ordersTable.Columns.Add("product_id");
            ordersTable.Columns.Add("transaction_id");
            ordersTable.Columns.Add("quantity");
            ordersTable.Columns.Add("price");

            List<User> users = User.GetAll(true);
            List<Transaction> transactions = Transaction.GetAllTransactions();
            List<Order> orders = Order.GetAll();
            List<Product> products = new List<Product>();
                products.AddRange(Product.GetAllProducts());
                products.AddRange(Product.GetAllDeleted());

            users.ForEach(user => usersTable.Rows.Add(user.Id, user.Fullname,user.Email, user.Password ,user.Role, user.IsDeleted));
            transactions.ForEach(transaction => transactionsTable.Rows.Add(transaction.Id, transaction.CashierId, transaction.Date, transaction.Cash));
            orders.ForEach(order => ordersTable.Rows.Add(order.Id, order.ProductId, order.TransactionId, order.Quantity, order.Price));
            products.ForEach(product => productsTable.Rows.Add(product.Id, product.Name, product.Category, product.Price, product.IsAvailable, product.IsDeleted));

            string filename = GetFileName();
            //string filenamedb = filename + ".accdb";

            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(usersTable, "users");
            wb.Worksheets.Add(productsTable, "products");
            wb.Worksheets.Add(transactionsTable, "transactions");
            wb.Worksheets.Add(ordersTable, "orders");
            wb.SaveAs(filename);

            e.Result = filename;
        }


        string GetFileName()
        {
            string name = DateTime.Now.ToString("yyyy_MM_dd_hhmmss") + ".xlsx";
            if (!Directory.Exists("backup")) Directory.CreateDirectory("backup");
            return Path.Combine("backup", name);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panelLoading.Visible = false;
            panelSuccess.Visible = true;
            lblFilename.Text = e.Result.ToString();
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
