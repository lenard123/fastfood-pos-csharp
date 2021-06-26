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
using FastFoodPOS.ErrorHandler;
using FastFoodPOS.Forms.CashierForms;

namespace FastFoodPOS.Forms.CashierForms
{
    partial class FormPOS : BaseForm
    {
        decimal Total;
        List<Product> AllProducts;
        public BindingList<OrderItemComponent> OrderComponents;
        User cashier_user = null;

        public FormPOS(User logged_in)
        {
            InitializeComponent();
            
            //Fetch All Products
            AllProducts = Product.GetAllProducts();
            
            //Initialized  Binding Source
            OrderComponents = new BindingList<OrderItemComponent>();
            OrderComponents.ListChanged += Orders_ListChanged;

            cashier_user = logged_in;

            //Reset Order
            Reset();

            //Select Food
            ButtonFoods.PerformClick();
        }

        void Orders_ListChanged(object sender, ListChangedEventArgs e)
        {
            Total = 0;
            foreach (OrderItemComponent oc in OrderComponents)
            {
                Total += oc._Order.Subtotal;
            }
            LabelTotal.Text = Total.ToString() + "PHP";
            LabelChange.Text = "--";
        }

        public OrderItemComponent AddOrderComponent(Product item)
        {
            Order order = new Order(item);
            OrderItemComponent oic = new OrderItemComponent(OrderComponents, order);
            oic.OnOrderIncrement += pcc_IncrementOrder;
            OrderComponents.Add(oic);
            PanelOrders.Controls.Add(oic);
            oic.BringToFront();
            //Orders.Add(order);
            return oic;
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            TextQuery.Text = "";
            PanelProducts.SuspendLayout();
            DisposeProductsPanel();
            string filter = ((Guna2Button)sender).Tag.ToString();
            AllProducts.ForEach((Product product) =>
            {
                if (product.Category.Equals(filter))
                {
                    AddProductComponent(product);
                }
            });
            PanelProducts.ResumeLayout();
        }

        void AddProductComponent(Product product)
        {
            var pcc = new ProductCardComponent1(product);
            pcc.ButtonAddProductClick += pcc_ButtonAddProductClick;
            PanelProducts.Controls.Add(pcc);
        }

        void pcc_ButtonAddProductClick(object sender, Product e)
        {
            var oic = OrderComponents.FirstOrDefault((OrderItemComponent item) => item._Order.ProductId == e.Id);
            if (oic == null)
            {
                oic = AddOrderComponent(e);
                oic.UpdateData();
            }
            else
            {
                pcc_IncrementOrder(1, oic);
            }
        }

        void pcc_IncrementOrder(object sender, OrderItemComponent e)
        {
            e._Order.Quantity += Convert.ToInt32(sender);
            if (e._Order.Quantity < 1)
            {
                OrderComponents.Remove(e);
                e.Dispose();
            }
            else
            {
                e.UpdateData();
                OrderComponents.ResetBindings();
            }
        }

        private void DisposeProductsPanel()
        {
            while (PanelProducts.Controls.Count >= 1)
            {
                PanelProducts.Controls[0].Dispose();
            }
        }

        private void Reset()
        {
            foreach (var item in OrderComponents)
            {
                item.Dispose();
            }
            OrderComponents.Clear();
            TextPayment.Text = "";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            if (OrderComponents.Count == 0) return;
            var result = Dialog.ConfirmDialogBox.ShowDialog("Are you sure to clear order?");
            //var result = MessageBox.Show("Are you sure to clear order?", "Confirm", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Yes)
                Reset();
        }

        private decimal GetChange()
        {
            decimal change = TextPayment.Value - Total;
            if (change < 0) throw new Level1Exception("Your payment is "+ Math.Abs(change) + "PHP short");
            return change;
        }

        private void ButtonCalculateChange_Click(object sender, EventArgs e)
        {
            try
            {
                LabelChange.Text = GetChange().ToString() + "PHP";
            }
            catch (Level1Exception ex)
            {
                ex.DisplayMessage();
            }
        }

        private void ButtonProccess_Click(object sender, EventArgs e)
        {
            if (OrderComponents.Count == 0) return;
            try
            {
                GetChange();
                var transaction = new Transaction(GetOrders(), User.CurrentUser)
                {
                    Date = DateTime.Now,
                    Cash = TextPayment.Value
                };
                transaction.Save();

                var po = new ProcessOrder(transaction);
                po.ShowDialog();

                Reset();
            } catch(Level1Exception ex)
            {
                ex.DisplayMessage();
            }
        }

        private List<Order> GetOrders()
        {
            var orders = new List<Order>();
            foreach (var item in OrderComponents)
                orders.Add(item._Order);
            return orders;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (TextQuery.Text.Equals("")) return;

            foreach (Guna2Button menu in ButtonsMenu.Controls)
                menu.Checked = false;

            PanelProducts.SuspendLayout();
            DisposeProductsPanel();
            SearchResult().ForEach((product) => AddProductComponent(product));
            PanelProducts.ResumeLayout();
        }

        private List<Product> SearchResult()
        {
            List<Product> result = AllProducts.FindAll((product) => product.ContainsAnd(TextQuery.Text));
            if (result.Count == 0)
                result = AllProducts.FindAll((product) => product.ContainsOr(TextQuery.Text));
            return result;
        }

    }
}
