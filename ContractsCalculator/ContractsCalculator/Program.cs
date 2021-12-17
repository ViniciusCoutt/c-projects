using ContractsCalculator.Entities;
using ContractsCalculator.Entities.Enums;
using System;
using System.Collections.Generic;
using static System.Console;

namespace ContractsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();

            Write("Enter department's name: ");
            department.Name = ReadLine();

            WriteLine("Enter worker data: ");
            Write("Name: ");
            string name = ReadLine();

            Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(ReadLine());

            Write("Base salary: ");
            double salary = double.Parse(ReadLine());

            Worker worker = new Worker(name, level, salary, department);

            Write("How many contracts to this worker?: ");
            int n = int.Parse(ReadLine());


            DateTime date;

            for (int i=1; i<=n; i++)
            {
                WriteLine($"Enter #{i} contract data: ");
                Write("Date (DD/MM/YYYY): ");
                date = DateTime.Parse(ReadLine());
                Write("Value per hour: ");
                double valueperhour = double.Parse(ReadLine());
                Write("Duration (hours): ");
                int hour = int.Parse(ReadLine());

                worker.AddContract(new HourContract(date, valueperhour, hour));
            }


            Write("Enter month and year to calculate income (MM/YYYY): ");
            date = DateTime.Parse(ReadLine());
            Double income = worker.Income(date.Year, date.Month);

            Write(worker);
            Write($"\nIncome for {date.Month}/{date.Year}: {income}");
        }
    }
}
