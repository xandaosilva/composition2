using Composition2.Entities;
using Composition2.Entities.Enums;
using System;

namespace Composition2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("15/03/1985");
            Client c1 = new Client("Alex Green", "alex@gmail.com", d1);
            Order o = new Order(DateTime.Now, OrderSatus.PROCESSING, c1);
            Console.WriteLine(o);

        }
    }
}
