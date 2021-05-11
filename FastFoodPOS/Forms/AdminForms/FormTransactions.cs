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

namespace FastFoodPOS.Forms.AdminForms
{
    public partial class FormTransactions : UserControl
    {
        BindingList<TransactionModel> list;
        public FormTransactions()
        {
            InitializeComponent();
            list = new BindingList<TransactionModel>();
            Transaction.fakeData().ForEach((Transaction t) => { list.Add(new TransactionModel(t)); });
            transactionModelBindingSource.DataSource = list;
        }
    }

    class TransactionModel
    {
        public string TransactionId
        {
            get;
            set;
        }

        public string Date
        {
            get;
            set;
        }

        public string Total
        {
            get;
            set;
        }

        public TransactionModel(Transaction t)
        {
            TransactionId = "#" + t.Id;
            Date = t.Date.ToString();
            Total = t.Total + "PHP";
        }
    }
}
