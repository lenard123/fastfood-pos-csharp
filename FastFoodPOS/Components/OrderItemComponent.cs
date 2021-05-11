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
    partial class OrderItemComponent : UserControl
    {

        public Order _Order;

        private BindingList<Order> Orders;

        public OrderItemComponent(BindingList<Order> Orders, Order order)
        {
            InitializeComponent();
            _Order = order;
            this.Orders = Orders;
            LabelName.Text = order.GetProduct().Name;
        }

        public void UpdateData()
        {
            LabelQuantity.Text = _Order.Quantity.ToString();
            LabelSubtotal.Text = _Order.Subtotal.ToString() + "PHP";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            _Order.Quantity++;
            Orders.ResetBindings();
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (_Order.Quantity > 1)
            {
                _Order.Quantity--;
                Orders.ResetBindings();
            }
            else
            {
                Orders.Remove(_Order);
                Dispose();
            }
        }

    }
}
