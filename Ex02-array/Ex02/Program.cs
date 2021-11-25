using System;
using System.Globalization;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
 
            double sum = 0.0;

            Console.Write("Informe o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Produto: ");
                string nome = Console.ReadLine();
                Console.Write("Valor: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto ( nome, preco );

                sum += vet[i].Preco;
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2"));

        }
    }
}
