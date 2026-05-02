using Microsoft.VisualBasic;

namespace Bank_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create accounts (polymorphism - both are different Account type)

            SavingAccounts Saving = new SavingAccounts("SA-001", 10000, 0.05m);
            CurrentAccount Current = new CurrentAccount("CA-001", 5000, 100);

            // Perform operations

            Saving.Deposite(2000);
            Current.Withdraw(500);

            // Display info (each shows differently - polymorphism)

            Saving.DisplayInfo();
            Current.DisplayInfo();

            // Test interest calculation (different for each type)

            Console.WriteLine($"Savings Interest: {Saving.CalculateInterest()}");
            Console.WriteLine($"Current Interest: {Current.CalculateInterest()}");

        }
    }
}
