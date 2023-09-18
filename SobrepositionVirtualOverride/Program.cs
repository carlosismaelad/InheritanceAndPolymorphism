using SobrepositionVirtualOverride.Entities;

namespace SobrepositionVirtualOverride
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Account acc1 = new Account(1001, "Alex", 500.00);
            Account acc2 = new SavingsAccount(1002, "Ana", 500.00, 0.01);
            
            // Testando nossa regra de saques:
            acc1.Withdraw(10.00);
            acc2.Withdraw(10.00);

            Console.WriteLine(acc1.Balance); // Descontou 10,00 + 2,00 de taxa
            Console.WriteLine(acc2.Balance); // Descontou 10,00 + 5,00 de taxa
        }



        
    }
}