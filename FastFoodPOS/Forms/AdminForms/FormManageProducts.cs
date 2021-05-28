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
using FastFoodPOS.Components;
using Guna.UI2.WinForms;

namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormManageProducts : UserControl, IKeepable
    {
        List<Product> AllProducts;
        
        public FormManageProducts()
        {
            InitializeComponent();
            AllProducts = Product.GetAllProducts();
            ButtonFoods.PerformClick();
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {

            TextSearch.Text = "";

            flowLayoutPanel1.Visible = false;
            DisposePanelContent();
            Guna2Button button = (Guna2Button)sender;
            AllProducts.ForEach((Product product) =>
            {
                if (product.Category.Equals(button.Tag))
                {
                    AddProductComponent(product);
                }
            });
            flowLayoutPanel1.Visible = true;
        }

        void pcc_ButtonRemoveClick(object sender, ProductCardComponent e)
        {
            if (User.IsAdmin())
            {
                DialogResult result = Dialog.ConfirmDialogBox.ShowDialog("Are you sure to remove this product?");
                if (result == DialogResult.Yes)
                {
                    e.product.Remove();
                    AlertNotification.ShowAlertMessage("Product removed successfully", AlertNotification.AlertType.SUCCESS);
                    AllProducts.Remove(e.product);
                    e.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Only Administrator can remove a data");
            }
        }

        void pcc_ButtonUpdateClick(object sender, ProductCardComponent e)
        {
            ShouldKeepForm = true;
            FormAdminPanel.GetInstance().LoadFormControl(new FormUpdateProduct(this, e));
        }


        private void DisposePanelContent()
        {
            while (flowLayoutPanel1.Controls.Count >= 1)
            {
                flowLayoutPanel1.Controls[0].Dispose();
            }
        }


        public bool ShouldKeepForm { get; set; }

        public void OnMounted()
        {

        }

        public void OnUnMounted(ref UserControl next)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            flowLayoutPanel1.Focus();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (TextSearch.Text == "") return;

            foreach (Guna2Button menu in ButtonsMenu.Controls)
                menu.Checked = false;

            flowLayoutPanel1.SuspendLayout();
            DisposePanelContent();
            var result = SearchResult();
            result.ForEach((product) => AddProductComponent(product));
            flowLayoutPanel1.ResumeLayout();

            AlertNotification.ShowAlertMessage(result.Count + " items found", AlertNotification.AlertType.INFO);

        }

        private void AddProductComponent(Product product)
        {
            ProductCardComponent pcc = new ProductCardComponent(product);
            pcc.ButtonUpdateClick += pcc_ButtonUpdateClick;
            pcc.ButtonRemoveClick += pcc_ButtonRemoveClick;
            flowLayoutPanel1.Controls.Add(pcc);
        }

        private List<Product> SearchResult()
        {
            List<Product> result = AllProducts.FindAll((product) => product.ContainsAnd(TextSearch.Text));
            if (result.Count == 0)
                result = AllProducts.FindAll((product) => product.ContainsOr(TextSearch.Text));
            if (result.Count >= 16)
                result.RemoveRange(15, result.Count - 15);
            return result;
        }
    }
}
