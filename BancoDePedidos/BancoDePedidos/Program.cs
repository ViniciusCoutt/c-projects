using BancoDePedidos.Entities;
using BancoDePedidos.Entities.Enums;
using System;
using System.Globalization;
using static System.Console;
namespace BancoDePedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter cliente data: ");
            Write("Name: ");
            string clientName = ReadLine();
            Write("Email: ");
            string email = ReadLine();
            Write("Birth date(DD / MM / YYYY): ");
            DateTime birthDate = DateTime.Parse(ReadLine());
            WriteLine("\nEnter order data: ");

            Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(ReadLine());

            Write("How many items to this order? ");
            int n = int.Parse(ReadLine());

            Client client = new Client(clientName, email, birthDate);
            DateTime moment = DateTime.Now;

            Order order = new Order(moment, status, client);

            for (int i = 1; i<=n; i++)
            {
                WriteLine($"\nEnter #{i} item data: ");
                Write("Product name: ");
                string pname = ReadLine();

                Write("Product price: ");
                double price = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

                Write("Quantity: ");
                int qnt = int.Parse(ReadLine());

                Product product = new Product(pname, price);
                OrderItem item = new OrderItem(qnt, price, product);
                order.AddItem(item);
            }

            Write(order);
        }
    }
}
