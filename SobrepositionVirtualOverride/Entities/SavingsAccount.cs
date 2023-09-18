namespace SobrepositionVirtualOverride.Entities;


class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public SavingsAccount()
    {
        
    }

    public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
    {
        InterestRate = interestRate;
    }

    public void UpdateBalance()
    {
        Balance += Balance * InterestRate;
    }

    public sealed override void Withdraw(double amount) // evitando que o método seja sobreposto novamente
    {
        base.Withdraw(amount);
        Balance -= 3.0;
    }
}