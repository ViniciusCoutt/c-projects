using System;
using System.Globalization;

namespace SistemaDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();

            Console.WriteLine("Dados do aluno: ");
            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Nota 01: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 02: ");
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 03: ");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nota final: {aluno.NotaFinal()}");
            Console.WriteLine(aluno.Situacao());


        }
    }
}
