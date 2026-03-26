using System;

namespace Module.Entities
{
    class SavingAccount : Account
    {
        public double InterestRate { get; private set; }

        public SavingAccount(): base() { }

        public SavingAccount(int number, string holder, double balance, double interestRate): base(number, holder, balance) {
            this.InterestRate = interestRate;
        }

        public void updateBalance(double rate)
        {
            this.Balance += this.Balance * rate;
        }

        public sealed override void Withdraw(double amount)
        {
            double totalAmount = amount + 2;

            if(Balance >= totalAmount)
            {
                base.Withdraw(amount);

                Balance -= 2;
            }
        }
    }
}
