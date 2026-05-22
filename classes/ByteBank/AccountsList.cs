using System;
using System.Collections.Generic;
using System.IO;

using ByteBank.Repositories;

namespace ByteBank.Entities
{
    class AccountsList
    {
        private List<Account> list;
        private AccountRepository repo;

        public AccountsList()
        {
            this.list = new List<Account>();
            this.repo = new AccountRepository();
        }

        public int Length {  get { return this.list.Count(); } }

        public void Reload()
        {
            List<Account> newList = this.repo.GetMany();

            this.list = newList;

        }

        public Account? get(string id)
        {
            Account? account = this
                .list
                .Find(acc => acc.Id == id);

            return account;
        }

        public List<Account> GetAll() {  return this.list; }

        public void Add(Account account)
        {
            if (account != null)
            {
                this.repo.Save(account);

                this.Reload();
            }

        }

        public void Remove(string id) { 
            Account? account = this.get(id);

            if (account != null) {
                this.repo.Delete(id);

                this.Reload();
            } else {
                Console.WriteLine("Conta não encontrada");
            }
        }

        public Account? MaxAccount()
        {
            Account? max = this.list.Max();

            return max;
        }

        public Account? MinAccount()
        {
            Account? min = this.list.Min();

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