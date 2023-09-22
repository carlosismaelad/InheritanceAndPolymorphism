using System.Globalization;
using AbstractClass.Entities;
namespace AbstractClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            List<Account> list = new List<Account>();
            
            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
            list.Add(new SavingsAccount(1003, "BOb", 500.00, 0.01));
            list.Add(new BusinessAccount(1004, "Ana", 500.00, 500.00));
            
            // Vamos supor que nós queremos totalizar o saldo de todas as contas:
            // Como temos uma lista genérica, vamos simplesmente percorrer esta lista
            // obtendo o saldo de cada um. Se a classe Acocunt não existisse nós não poderíamos
            // criar uma lista e misturar tipos diferentes na mesma lista. Isso só é posśivel
            // porque temos a classe genérica Account.

            double sum = 0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine($"Total balance: R${sum.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0); // chamadas polimórficas
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                                  + acc.Number
                                  + ": "
                                  + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

