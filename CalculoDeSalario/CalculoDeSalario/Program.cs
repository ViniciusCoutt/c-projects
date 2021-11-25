using System;
using System.Globalization;

namespace CalculoDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Dados do funcionário");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            Console.Write($"Funcionário: {func}");
            
            Console.WriteLine("");

            Console.Write("Digite uma porcentagem de aumento: ");
            func.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("");


            Console.Write($"Dados atualizados: {func}");


        }
    }
}
