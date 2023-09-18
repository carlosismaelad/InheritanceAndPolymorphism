namespace ExerInheritance.Entities;

public class OutsourcedEmployee : Employee
{
    public double AdditionalCharge { get; set; }

    public OutsourcedEmployee()
    {
    }

    public OutsourcedEmployee(string name, int hours, double valuePerHour, double aditionalCharge) : base(name, hours, valuePerHour)
    {
        AdditionalCharge = aditionalCharge;
    }

    public override double Payment()
    {
        return base.Payment() + 1.1 * AdditionalCharge;
        
    }
}