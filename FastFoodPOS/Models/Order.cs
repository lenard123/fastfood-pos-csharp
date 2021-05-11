using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Models
{
    class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public decimal Subtotal {
            get{
                return Quantity * GetProduct().Price;
            }
        }

        Product product = null;

        public Order(Product product)
        {
            this.product = product;
            this.ProductId = product.Id;
            this.Quantity = 1;
        }

        public Product GetProduct()
        {
            if (product == null)
            {
                product = Product.Find(Id);
            }
            return product;
        }

    }
}
