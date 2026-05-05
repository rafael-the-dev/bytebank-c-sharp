using System;
using System.Collections.Generic;

using ByteBank.Entities;

namespace ByteBank.Entities
{
    class Account : IComparable {
        public double Amount { get; private set; }
        public Client Holder { get; private set; }
        public string Id { get; private set; }

        public Account(Client holder, string id, double amount)
        {
            this.Holder = holder;
            this.Amount = amount;
            this.Id = id;
        }

        public void AdicionarValor(double valor)
        {
            if(valor > 0)
            {
                this.Amount += valor;
            }
        }

        public void RemoverValor(double valor)
        {
            if (valor > 0 && this.Amount >= valor)
            {
                this.Amount -= valor;
            }
        }

        public int CompareTo(object? obj)
        {
            if (obj == null || !(obj is Account)) return -1;

            Account account = (Account)obj;

            return this.Amount.CompareTo(account.Amount);
        }



        public override string ToString()
        {
            return this.Holder + ", Saldo: " + this.Amount;
        }
    }
}