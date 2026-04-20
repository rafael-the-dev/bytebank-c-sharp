using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace Module
{
    class AccountsList
    {
        private sbyte _currentFilledIndex; 
        private List<Account> list;

        public AccountsList()
        {
            this._currentFilledIndex = -1;
            this.list = new List<Account>();
        }

        public int Length {  get { return this.list.Count(); } }

        public Account? get(string id)
        {
            Account? account = this
                .list
                .Find(acc => acc.Id == id);

            return account;
        }

        public void Add(Account account)
        {
            if (account != null)
            {
                this.list.Add(account);
            }
        }

        public Account? MaxAccount()
        {
            Account max = this.list.Max();

            return max;
        }

        public Account? MinAccount()
        {
            Account min = this.list.Min();

            return min;
        }
        private double SaldoTotal()
        {
            double total = 0;

            foreach(Account acc in this.list) { 
                total += acc.Amount;
            }

            return total;
        }

        public override string ToString()
        {
            Account? max = this.MaxAccount();
            Account? min = this.MinAccount();

            return "Número de contas: " + this.Length + "\n"
                + "Saldo total: " + this.SaldoTotal() + "\n"
                + "Conta com maior saldo: " + ( max == null ? "N/A" : max) + "\n"
                + "Conta com menor saldo: " + ( min == null ? "N/A" : min)
                ;
        }
    }
}