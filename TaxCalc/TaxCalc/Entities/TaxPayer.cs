namespace TaxCalc.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes();

        public override string ToString()
        {
            return $"{Name}: $ {Taxes().ToString("F2")}";
        }
    }
}
