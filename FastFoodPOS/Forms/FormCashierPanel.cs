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

namespace FastFoodPOS.Forms
{
    partial class FormCashierPanel : BaseForm
    {

        List<Product> AllProducts;
        public BindingList<OrderItemComponent> OrderComponents;
        //public BindingList<Order> Orders;

        public FormCashierPanel()
        {
            InitializeComponent();
            
            AllProducts = Product.GetAllProducts();
            //Orders = new BindingList<Order>();
            OrderComponents = new BindingList<OrderItemComponent>();

            OrderComponents.ListChanged += Orders_ListChanged;

            ButtonFoods.PerformClick();
        }

        void Orders_ListChanged(object sender, ListChangedEventArgs e)
        {
            decimal Total = 0;
            foreach (OrderItemComponent oc in OrderComponents)
            {
                oc.UpdateData();
                Total += oc._Order.Subtotal;
            }
            LabelTotal.Text = Total.ToString() + "PHP";
        }

        public void AddOrderComponent(Product item)
        {
            Order order = new Order(item);
            OrderItemComponent oic = new OrderItemComponent(OrderComponents, order);
            OrderComponents.Add(oic);
            PanelOrders.Controls.Add(oic);
            //Orders.Add(order);
        }


        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new FormAdminLogin());
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            DisposeProductsPanel();
            string filter = ((Guna2Button)sender).Tag.ToString();
            AllProducts.ForEach((Product product) =>
            {
                if (product.Category.Equals(filter))
                    PanelProducts.Controls.Add(new ProductCardComponent1(this, product));
            });
        }

        private void DisposeProductsPanel()
        {
            while (PanelProducts.Controls.Count >= 1)
            {
                PanelProducts.Controls[0].Dispose();
            }
        }
    }
}
