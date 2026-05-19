using System;

using ByteBank.Entities;
using ByteBank.Interfaces;

namespace ByteBank.Commands
{
    class WithdrawCommand : ICommand
    {
        public Account ClientAccount { get; private set; }
        public double Amount { get; private set; }
        public double PreviousBalance { get; private set; }
        private bool withdrawn;

        public WithdrawCommand(Account account, double amount, double previousBalance)
        {
            this.ClientAccount = account;
            Amount = amount;
            withdrawn = false;
            PreviousBalance = previousBalance;
        }

        public void Execute()
        {
            this.ClientAccount.RemoverValor(this.Amount);

            withdrawn = true;
        }

        public void Undo()
        {
            if (!withdrawn) return;

            this.ClientAccount.AdicionarValor(Amount);

            withdrawn = false;
        }
    }
}