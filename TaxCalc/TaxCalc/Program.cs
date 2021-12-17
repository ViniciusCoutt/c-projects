using System;
using System.Collections.Generic;
using System.Globalization;
using TaxCalc.Entities;
using static System.Console;

namespace TaxCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Write("Enter the number of tax payers:  ");
            int n = int.Parse(ReadLine());

            for(int i = 1; i <= n; i++)
            {
                WriteLine($"Tax payer #{i} data:  ");
                Write("Individual or company (i/c)?: ");
                char p = char.Parse(ReadLine());
                if (p == 'i')
                {
                    Write("Name: ");
                    string name = ReadLine();

                    Write("Anual income: ");
                    double income = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

                    Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, income, healthExpenditures));
                } 
                else
                {
                    Write("Name: ");
                    string name = ReadLine();
                    Write("Anual income: ");
                    double income = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    Write("Number of employees: ");
                    int employeesNumber = int.Parse(ReadLine());

                    list.Add(new Company(name, income, employeesNumber));
                }             
            }
            double totalTaxes = 0.0;
            WriteLine("\nTAXES PAID:");
            foreach (TaxPayer payer in list)
            {
                Console.WriteLine(payer);

                totalTaxes += payer.Taxes();
            }
            WriteLine("TOTAL TAXES: " + totalTaxes.ToString("F2"));

        }
    }
}
