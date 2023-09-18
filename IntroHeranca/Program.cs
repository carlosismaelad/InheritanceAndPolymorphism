using IntroHeranca.Entities;

namespace IntroHeranca
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Account acc = new Account(1001, "Alex", 0.00);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.00, 500.00);
            
            
            // UPCASTING - Relação "é um". BusinessAccount é um Account, então uma variável Account pode receber uma variável de BusinessAccount
            // A variável do tipo Account recebe, naturalmente, um objeto de qualquer tipo de subclasse dela, isso é Upcasting.
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.00, 200.00) ;
            Account acc3 = new SavingsAccount(1004, "Ana", 0.00, 0.01);
            
            
            // DOWNCASTING - aconversão da superclasse para subclasse
            // Uma subclasse pode receber uma superclasse, mas para isso precisamos fazero casting de superclasse para subclasse
            BusinessAccount bacc1 = (BusinessAccount)acc2;
            bacc1.Loan(100.00);
            
            
            // tentando fazer o downcasting de uma subclasse para outra subclasse em vez de usar uma superclasse:
            // BusinessAccount acc5 = acc3;
            
            // podemos fazer um teste antes de tentar o casting:
            if (acc3 is BusinessAccount) // se acc3 é uma instância de BusinnesAccount
            {
                BusinessAccount acc5 = (BusinessAccount)acc3; // Vai falhar porque acc3 é instancia de SavingsAccount e só podemos fazer downcasting de superclasse para subclasse
                acc5.Loan(100.00);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                // SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount; // outra forma de fazer o downcasting
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }



        }
    }
}