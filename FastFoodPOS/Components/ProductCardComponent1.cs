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
using FastFoodPOS.Forms;

namespace FastFoodPOS.Components
{
    partial class ProductCardComponent1 : UserControl
    {
        Product product;

        public event EventHandler<Product> ButtonAddProductClick;

        public ProductCardComponent1(Product product)
        {
            InitializeComponent();
            this.product = product;

            ButtonAddProduct.Visible = product.IsAvailable;
            ButtonUnavailable.Visible = !product.IsAvailable;

        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            if (ButtonAddProductClick != null) ButtonAddProductClick(sender, product);
        }

        private void ProductCardComponent1_Load(object sender, EventArgs e)
        {
            LabelName.Text = product.Name;
            LabelPrice.Text = product.Price + "PHP";
            PictureProductImage.ImageLocation = product.Image;
        }
    }
}
