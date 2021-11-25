using Ex_ProdutoEmEstoque;
using System;
using System.Globalization;

namespace Ex_ProdutoEmEstoque_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 5000.00, 10);
            
            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

        }
    }
}
