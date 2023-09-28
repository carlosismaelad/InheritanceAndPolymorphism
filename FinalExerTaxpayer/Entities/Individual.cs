namespace FinalExerTAxpayer.Entities;

public class Individual : Taxpayer
{
    public double HelphExpenditures { get; set; }

    public Individual(string name, double anualIncome) : base(name, anualIncome)
    {
    }

    public Individual(string name, double anualIncome, double helphExpenditures) : base(name, anualIncome)
    {
        HelphExpenditures = helphExpenditures;
    }

    public override double Tax()
    {
        if (AnualIncome < 20000.00)
        {
            return AnualIncome * 0.15 - HelphExpenditures * 0.5;
        }
        else
        {
            return AnualIncome * 0.25 - HelphExpenditures * 0.5;
        }
    }
}