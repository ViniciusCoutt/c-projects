using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalc.Entities
{
    class Company : TaxPayer
    {
        public int EmployeesNumber { get; set; }

        public Company(string name, double anualIncome, int employeesNumber) : base(name, anualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double Taxes()
        {
            double tax = EmployeesNumber > 10 ? 0.14 : 0.16;

            return AnualIncome * tax;
        }
    }
}
