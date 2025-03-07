using Day04_InheritanceAndPolymorphism.BankOperations;
using Day04_InheritanceAndPolymorphism.Staff;

namespace Day04_InheritanceAndPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Staff
            Manager manager = new Manager(1, "Atlas", 50000, "Electronics", 5);
            manager.DisplayInfo();
            Console.WriteLine($"Bonus: {manager.CalculateBonus()} TL\n");

            Developer developer = new Developer(2, "Mehmet", 40000, "Software", ".NET & Angular Developer");
            developer.DisplayInfo();
            Console.WriteLine($"Bonus: {developer.CalculateBonus()} TL\n");

            // BankOperations
            SavingsAccount savings = new SavingsAccount("Ensar", 10000);
            savings.DisplayInfo();
            savings.CalculateInterest();
            Console.WriteLine();

            CheckingAccount checking = new CheckingAccount("Semih", 5000);
            checking.DisplayInfo();
            checking.CalculateInterest();
        }
    }
}
