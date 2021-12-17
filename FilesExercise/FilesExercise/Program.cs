using FilesExercise.Entities;
using System;
using System.Globalization;
using System.IO;

namespace FilesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"";
                string sourcePath = @"Source.csv";
                string targetPath = @"out\summary.csv";

                Directory.CreateDirectory(path + @"\out");

                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        string[] str = line.Split(',');

                        string name = str[0];
                        double price = double.Parse(str[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(str[2]);
                        Product product = new Product(name, price, quantity);

                        sw.WriteLine(product);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
