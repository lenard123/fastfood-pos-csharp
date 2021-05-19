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
            flowLayoutPanel1.Visible = false;
            DisposePanelContent();
            Guna2Button button = (Guna2Button)sender;
            AllProducts.ForEach((Product product) =>
            {
                if (product.Category.Equals(button.Tag))
                {
                    ProductCardComponent pcc = new ProductCardComponent(product);
                    pcc.ButtonUpdateClick += pcc_ButtonUpdateClick;
                    pcc.ButtonRemoveClick += pcc_ButtonRemoveClick;
                    flowLayoutPanel1.Controls.Add(pcc);
                }
            });
            flowLayoutPanel1.Visible = true;
        }

        void pcc_ButtonRemoveClick(object sender, ProductCardComponent e)
        {
            if (User.IsAdmin())
            {
                DialogResult result = MessageBox.Show("Are you sure to remove this product?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    e.product.Remove();
                    MessageBox.Show("Product removed successfully");
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
            FormAdminPanel.Instance.LoadFormControl(new FormUpdateProduct(this, e));
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
    }
}
