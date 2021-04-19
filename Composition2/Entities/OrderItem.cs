using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Composition2.Entities
{
    class OrderItem
    {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name + ", $");
            sb.Append(Price.ToString("F2", CI) + ", ");
            sb.Append("Quantity: " + Quantity + ", ");
            sb.Append("Subtotal: " + SubTotal().ToString("F2", CI));
            return sb.ToString();
        }
    }
}
