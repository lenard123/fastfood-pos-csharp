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
    public partial class FormCashierPanel : BaseForm
    {

        List<Product> AllProducts;
        List<OrderItemComponent> OrderComponents;
        BindingList<Order> Orders;
        decimal Total = 0;
        public FormCashierPanel()
        {
            InitializeComponent();
            
            AllProducts = Product.GetAllProducts();
            Orders = new BindingList<Order>();
            OrderComponents = new List<OrderItemComponent>();

            Orders.ListChanged += Orders_ListChanged;

            ButtonFoods.PerformClick();
        }

        void Orders_ListChanged(object sender, ListChangedEventArgs e)
        {
            AddComponentIfNotExists();
            OrderComponents.ForEach((OrderItemComponent oc) => oc.UpdateData());
        }

        private void AddComponentIfNotExists()
        {
            Total = 0;
            foreach (Order order in Orders)
            {
                if (!OrderComponents.Any((OrderItemComponent oc) => oc._Order == order))
                {
                    OrderItemComponent oic = new OrderItemComponent(Orders, order);
                    OrderComponents.Add(oic);
                    PanelOrders.Controls.Add(oic);
                }
                Total += order.Subtotal;
            }
            LabelTotal.Text = Total + "PHP";
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
                    PanelProducts.Controls.Add(new ProductCardComponent1(Orders, product));
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
