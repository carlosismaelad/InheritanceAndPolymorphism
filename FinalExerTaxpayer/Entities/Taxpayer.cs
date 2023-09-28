namespace FinalExerTAxpayer.Entities;

public abstract class Taxpayer
{
    public string Name { get; set; }
    public double AnualIncome { get; set; }

    protected Taxpayer(string name, double anualIncome)
    {
        Name = name;
        AnualIncome = anualIncome;
    }

    public abstract double Tax();
}