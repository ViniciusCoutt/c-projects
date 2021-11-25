
using System;
using System.Globalization;
using static System.Console;

namespace ConversaoDeMoeda_static
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Informe a cotação do dolar: ");
            double cotacao = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            WriteLine("Quantos dólares você vai converter?: ");
            double dolar = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

            WriteLine("Valor em reais: " + ConversorDeMoeda.Conversao(cotacao, dolar));
        }
    }
}
