namespace DefiningClasses
{
    class BankAccount
    {
        public BankAccount()
        {
            
        }

        public int Id { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdrow(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}
