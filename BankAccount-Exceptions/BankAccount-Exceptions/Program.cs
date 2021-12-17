using BankAccount_Exceptions.Entities;
using BankAccount_Exceptions.Entities.Exceptions;
using System;
using System.Globalization;
using static System.Console;

namespace BankAccount_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Enter account data: ");
            Write("Number: ");
            int number = int.Parse(ReadLine());
            Write("Holder: ");
            string holder = ReadLine();
            Write("Initial balance: ");
            double initialBalance = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            Account account = new Account(number, holder, initialBalance, withdrawLimit);

            Write("\nEnter amount for withdraw: ");
            double withdrawAmount = double.Parse(ReadLine(), , CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(withdrawAmount);

                Write(account);
            }
            catch (DomainException e)
            {
                WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
