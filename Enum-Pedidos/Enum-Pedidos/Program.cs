using Enum_Pedidos.Entities;
using Enum_Pedidos.Entities.Enums;
using System;

namespace Enum_Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 10,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            string str = "Delivered";

            OrderStatus status = Enum.Parse<OrderStatus>(str);

            Console.WriteLine(status);
        }
    }
}
