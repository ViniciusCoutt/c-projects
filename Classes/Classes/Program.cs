using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario pessoaA = new Funcionario();
            Funcionario pessoaB = new Funcionario();
            Funcionario salario = new Funcionario();


            Console.WriteLine("Dados do primeiro funcinário: ");
            Console.Write("Nome");
            pessoaA.nome = Console.ReadLine();
            Console.WriteLine("Salario");
            pessoaA.salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcinário: ");
            Console.Write("Nome");
            pessoaB.nome = Console.ReadLine();
            Console.WriteLine("Salario");
            pessoaB.salario = float.Parse(Console.ReadLine());

            Console.WriteLine(salario.salMedio(pessoaA.salario, pessoaB.salario));


        }

    }
}
