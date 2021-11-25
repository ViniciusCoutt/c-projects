using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");

            foreach (string item in list)
            {
                Console.WriteLine(item); // Vai jogar para o console os itens da lista
            }
            Console.WriteLine("List count: " + list.Count);// quantidade de itens na lista: 5


            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position(indice) where has 'A': " + pos1);


            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
