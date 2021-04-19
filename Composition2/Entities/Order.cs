using Composition2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Composition2.Entities
{
    class Order
    {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public DateTime Moment { get; set; }
        public OrderSatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderSatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem i in Itens)
            {
                sum += i.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client : " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CI));
            return sb.ToString();
        }
    }
}
