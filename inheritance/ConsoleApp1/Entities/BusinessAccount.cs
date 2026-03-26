
using System;

namespace Module.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loadLimit) : base(number, holder, balance)
        {
            LoanLimit = loadLimit;
        }

        public void Load(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
