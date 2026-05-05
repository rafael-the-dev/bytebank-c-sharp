using System;
using System.Collections.Generic;
using System.IO;

using ByteBank.Repositories;

namespace ByteBank.Entities
{
    class AccountsList
    {
        private List<Account> list;
        private string path;

        public AccountsList()
        {
            this.list = new List<Account>();
            this.path = @"C:\salc\C#\classes\ByteBank\data.txt";
        }

        public int Length {  get { return this.list.Count(); } }

        public void Reload()
        {
            List<Account> newList = AccountRepository.getMany();

            this.list = newList;

        }

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
                using (StreamWriter sw = File.AppendText(this.path))
                {
                    sw.WriteLine($"{account.Id},{account.Holder.Name},{account.Amount}");
                }

                this.list.Add(account);
            }

            this.Reload();
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

            AccountRepository.getMany();

            return "Número de contas: " + this.Length + "\n"
                + "Saldo total: " + this.SaldoTotal() + "\n"
                + "Conta com maior saldo: " + ( max == null ? "N/A" : max) + "\n"
                + "Conta com menor saldo: " + ( min == null ? "N/A" : min)
                ;
        }
    }
}