using System;
using System.Globalization;

namespace InformaçõesDeUmRetângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Informe os valores do retângulo: ");
            Console.Write("Largura: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area: " + ret.Area().ToString("F2"));
            Console.WriteLine("Perímetro: " + ret.Perimetro().ToString("F2"));
            Console.WriteLine("Diagonal: " + ret.Diagonal().ToString("F2"));

        }
    }
}
