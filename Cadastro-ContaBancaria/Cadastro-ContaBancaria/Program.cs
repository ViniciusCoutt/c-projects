using System;
using System.Globalization;
using static System.Console;

namespace Cadastro_ContaBancaria
{
    class Program
    {

        static void Main(string[] args)
        {
            

            Write("Entre com o número da conta: ");
            int numero = int.Parse(ReadLine());

            Write("Nome do títular da conta: ");
            string nome = ReadLine();

            ContaBancaria conta = new ContaBancaria(numero, nome);

            Write("Haverá depósito inicial (s/n)? ");
            char haveraDeposito = char.Parse(ReadLine());
            if (haveraDeposito == 's' || haveraDeposito == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                conta.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }

            WriteLine("\nDados da conta: " + conta);
            WriteLine("--------------------------------------------------------------------");

            Write("Entre um valor para depósito: ");
            conta.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            WriteLine("\nDados da conta atualizados: " + conta);
            WriteLine("--------------------------------------------------------------------");

            Write("Entre um valor para saque: ");
            conta.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            WriteLine("\nDados da conta atualizados: " + conta);
            WriteLine("--------------------------------------------------------------------");
           
        }
    }
}
