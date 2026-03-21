

using System.Security.Principal;

namespace Module
{
    class AccountsList
    {
        private sbyte _currentFilledIndex; 
        public Account[] List { get; private set; }

        public AccountsList()
        {
            this._currentFilledIndex = -1;
            this.List = new Account[100];
        }

        public sbyte Length {  get { return (sbyte)(this._currentFilledIndex + 1); } }

        public Account? get(string id)
        {
            Account? account = null;

            for(sbyte i = 0;  i < this._currentFilledIndex + 1; i++)
            {
                if (this.List[i].Id == id)
                {
                    account = this.List[i];
                    break;
                }
            }

            return account;
        }

        public void Add(Account account)
        {
            sbyte index = this._currentFilledIndex += 1;

            if(account != null && index < this.List.Length)
            {
                this._currentFilledIndex = index;
                this.List[index] = account;
            }
        }

        public Account? MaxAccount()
        {
            Account max = this.List[0];

            if (max == null) return null;

            for(sbyte i = 0; i < this._currentFilledIndex + 1; i++)
            {
                Account account = this.List[i];

                if (account.Amount > max.Amount) { max = account; }
            }

            return max;
        }

        public Account? MinAccount()
        {
            Account min = this.List[0];

            if (min == null) return null;

            for (sbyte i = 0; i < this._currentFilledIndex + 1; i++)
            {
                Account account = this.List[i];

                if (account.Amount < min.Amount) { min = account; }
            }

            return min;
        }
        private double SaldoTotal()
        {
            if (this._currentFilledIndex < 0) return 0;

            double total = 0;

            for (sbyte i = 0; i < this._currentFilledIndex + 1; i++)
            {
                double amount = this.List[i].Amount;

                if (amount > 0) total += amount;
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