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
    public partial class FormManageProducts : UserControl
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
            DisposePanelContent();
            Guna2Button button = (Guna2Button)sender;
            AllProducts.ForEach((Product product) =>
            {
                if (product.Category.Equals(button.Tag))
                    flowLayoutPanel1.Controls.Add(new ProductCardComponent(product));
            });
        }

        private void DisposePanelContent()
        {
            while (flowLayoutPanel1.Controls.Count >= 1)
            {
                flowLayoutPanel1.Controls[0].Dispose();
            }
        }

    }
}
