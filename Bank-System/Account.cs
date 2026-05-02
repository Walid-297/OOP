namespace Bank_System
{
    abstract public class Account // ABSTRACTION: Can't create Account directly
    {
        private decimal Balance;  // ENCAPSULATION: Hidden from outside

        public string AccountNumber // Properties (controlled access)
        {
            get;
            private set;
        }

        protected Account(string accountNumber) // Constructor (initialization) , Protected: Members declared as protected can be accessed within the same class and by derived classes.
        {
            AccountNumber = accountNumber;

            Balance = 0;
        }

        // Common methods for all accounts
        public void SetBalance(decimal balance)
        {
            Balance = balance;
        }
        public decimal GetBalance()
        {
            return Balance;
        }

        public void Deposite(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public abstract decimal CalculateInterest(); // Abstract method - MUST be implemented by child classes

        public virtual void DisplayInfo() // Virtual method - Can be overridden
        {

        }
    }
}
