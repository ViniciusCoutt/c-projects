using System;
using static System.Console;

namespace Alugueis
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro[] quartos = new Cadastro[10];

            Write("Quantos quarto serão alugados ? ");
            int n = int.Parse(ReadLine());


            for (int i = 0;  i<n; i++)
            {
                Write("\nNome: ");
                string nome = ReadLine();
                Write("Email: ");
                string email = ReadLine();
                Write("Número do quarto: ");
                int numero = int.Parse(ReadLine());
                quartos[numero] = new Cadastro(nome, email);              
            }

            WriteLine("\nQuartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null ){
                    WriteLine(i + ": " + quartos[i]);
                }
            }
        }
    }
}
