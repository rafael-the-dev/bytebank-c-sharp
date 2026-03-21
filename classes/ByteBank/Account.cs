
namespace Module
{
    class Account {
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

        public override string ToString()
        {
            return this.Holder + ", Saldo: " + this.Amount;
        }
    }
}