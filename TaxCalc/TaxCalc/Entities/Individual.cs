using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalc.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        { 
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            double tax = AnualIncome < 20000 ? 0.15 : 0.25;
          
            return AnualIncome * tax - HealthExpenditures * 0.5;
        }
    }
}
