using Ex_ProdutoEmEstoque;
using System;
using System.Globalization;

namespace Ex_ProdutoEmEstoqueConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Produto p = new Produto(nome, preco, quantidade);


            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("--------------------------------------------------------------------");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine(" ");

            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine("---------------------------------------------------------------------");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine(" ");

            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine("---------------------------------------------------------------------");


        }
    }
}
