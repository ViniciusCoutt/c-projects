using System;
using System.Collections.Generic;
using System.Globalization;
using static System.Console;
namespace RegistroDeFuncionários
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Write("Home many employees will be registered? ");
            int n = int.Parse(ReadLine());

            for(int i = 0; i<n; i++)
            {
                WriteLine($"\nEmployee #{n}: ");
                Write("Id: ");
                int id = int.Parse(ReadLine());
                Write("Name: ");
                string name = ReadLine();
                Write("Salary: ");
                double salary = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));
            }

            Write("\nEnter the employee id that will have salary increase: ");
            int index = int.Parse(ReadLine());

            Employee infos = list.Find(x => x.Id == index);

            if (infos != null)
            {
                Write("\nEnter the percentage: ");
                double percent = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                infos.increaseSalary(percent);
            }
            else
            {
                Write("This id does not exist!\n");
            }

            WriteLine("\nUpdated list of employees:");
            foreach (Employee item in list)
            {
                WriteLine(item);
            }


     


        }
    }
}
