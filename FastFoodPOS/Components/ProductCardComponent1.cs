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
        FormCashierPanel context;
        public ProductCardComponent1(FormCashierPanel context, Product product)
        {
            InitializeComponent();
            LabelName.Text = product.Name;
            LabelPrice.Text = product.Price + "PHP";
            this.context = context;
            this.product = product;
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            OrderItemComponent nOrder = context.OrderComponents.FirstOrDefault((OrderItemComponent oic) => oic._Order.ProductId == product.Id);

            if (nOrder == null)
            {
                context.AddOrderComponent(product);
            }
            else
            {
                nOrder._Order.Quantity++;
                context.OrderComponents.ResetBindings();
            }
        }
    }
}
