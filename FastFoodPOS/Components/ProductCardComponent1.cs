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

namespace FastFoodPOS.Components
{
    partial class ProductCardComponent1 : UserControl
    {
        Product product;
        BindingList<Order> Orders;
        public ProductCardComponent1(BindingList<Order> Orders, Product product)
        {
            InitializeComponent();
            LabelName.Text = product.Name;
            LabelPrice.Text = product.Price + "PHP";
            this.product = product;
            this.Orders = Orders;
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            Order nOrder = Orders.FirstOrDefault((Order order) => order.ProductId == product.Id);
         
            if (nOrder == null)
            {
                Orders.Add(new Order(product));
            }
            else
            {
                nOrder.Quantity++;
                Orders.ResetBindings();
            }
        }
    }
}
