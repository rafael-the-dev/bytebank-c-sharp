using System;

using ByteBank.Entities;
using ByteBank.Interfaces;

namespace ByteBank.Commands { 
    class DepositCommand : ICommand { 
        public Account ClientAccount {  get; private set; }
        public double Amount { get; private set; }
        public double PreviousBalance { get; private set; }
        private bool Deposited;

        public DepositCommand(Account account, double amount, double previousBalance) { 
            this.ClientAccount = account;
            Amount = amount;
            Deposited = false;
            PreviousBalance = previousBalance;
        }

        public void Execute() {
            this.ClientAccount.AdicionarValor(Amount);

            Deposited = true;
        }

        public void Undo() {
            if (!Deposited) return;

            this.ClientAccount.RemoverValor(this.Amount);

            this.Deposited = false;
        }
    }
}