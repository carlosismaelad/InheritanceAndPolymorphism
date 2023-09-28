using System.Globalization;
using FinalExerTAxpayer.Entities;

namespace FinalExerTAxpayer
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            List<Taxpayer> list = new List<Taxpayer>();
            
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Taxpayer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'i' || type == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (Taxpayer payer in list)
            {
                Console.WriteLine(
                        payer.Name
                        + ": $ "
                        + payer.Tax().ToString("F2", CultureInfo.InvariantCulture)
                    );
            }
        }
    }
}

