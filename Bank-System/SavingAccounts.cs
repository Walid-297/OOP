namespace Bank_System
{
    public class SavingAccounts : Account
    {
        private decimal InterestRate;

        public SavingAccounts(string accountNumber , decimal InterestRate , decimal InitialBalance) : base(accountNumber)
        {
            this.InterestRate = InterestRate ;
            SetBalance(InitialBalance); // that doesn't appear int he parent class in the original code 
        }

        public override decimal CalculateInterest() // POLYMORPHISM: Different implementation than CurrentAccount
        {
            return GetBalance() * InterestRate;
           
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Savings Account Info:");

            base.DisplayInfo();  // Call parent's displayinfo , why ?

            Console.WriteLine($"Interest Rate: {InterestRate}");
            Console.WriteLine($"Calculated Interest: {CalculateInterest()}");
        }


    }
}
