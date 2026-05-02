namespace Bank_System
{
    public class CurrentAccount : Account
    {
        private decimal MonthlyFee;

        public CurrentAccount(string accountNumber , decimal monthlyFee , decimal initialBalance ) : base(accountNumber)
        {
            MonthlyFee = monthlyFee;
            SetBalance(initialBalance);
        }

        public override decimal CalculateInterest() // POLYMORPHISM: Different implementation
        {
            return 0; // No interest for current accounts
        }

        public void DeductMonthlyFee(decimal monthlyFee)
        {
            Withdraw(monthlyFee);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Current Account Info:");
            base.DisplayInfo(); // why base 
            Console.WriteLine($"Monthly Fee: {MonthlyFee}");
            Console.WriteLine($"Calculated Interest: {CalculateInterest()}");
        }
    }
}
