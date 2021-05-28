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
    public partial class FormProductArchive : UserControl
    {
        List<Product> deleted;

        public FormProductArchive()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            deleted = Product.GetAllDeleted();
            DataGridViewProducts.Rows.Clear();
            deleted.ForEach(item =>
            {
                DataGridViewProducts.Rows.Add(
                    item.Id,
                    item.Name,
                    item.Category,
                    item.Price
                );
            });
            if(deleted.Count == 0) DataGridViewProducts.Rows.Add("No deleted products");
        }

        private void DataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (deleted.Count == 0) return;
            Product selected = deleted[e.RowIndex];
            DialogResult result = Dialog.ConfirmDialogBox.ShowDialog("Are you sure to recover this product " + selected.Name);
            if (result == DialogResult.Yes)
            {
                selected.Recover();
                MessageBox.Show("Product recovered successfully");
                RefreshData();
            }
        }

        private void LinkUserArchive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAdminPanel.GetInstance().LoadFormControl(new FormUsersArchive());
        }
    }
}
