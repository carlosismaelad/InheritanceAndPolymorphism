using IntroHeranca.Entities;

namespace IntroHeranca
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            BusinessAccount businessAccount = new BusinessAccount(8010, "Carlos", 400.00, 500.00);
            
            Console.WriteLine(businessAccount.Balance);
            
            // Não será permitido:
            // businessAccount.Balance = 800.00;
        }
    }
}