using System.Globalization;
using ExerInheritance.Entities;

namespace ExerInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            List<Employee> emp = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee number #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (resp == 'y' || resp == 'Y')
                {
                    Console.Write("Aditional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    emp.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee employee in emp)
            {
                Console.WriteLine($"{employee.Name} - ${employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}" );
            }
            
            


        }
    }
}