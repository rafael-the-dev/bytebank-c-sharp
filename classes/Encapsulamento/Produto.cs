using System;
using System.Globalization;

namespace Module
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public double Quantidade{ get; private set; }

        public Produto()
        {
            this.Quantidade = 5;
        }

        public Produto(string nome, double preco): this()
        {
            this._nome = nome;
            this.Preco = preco;
        }

        public Produto(string nome, double preco, double quantidade): this(nome, preco)
        {
            this.Quantidade = quantidade;
        }

        public string Nome
        {
            get { return this._nome; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    this._nome = value;
                }
            }
        }


        public string FormatNumber(double value)
        {
            return value.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AumentarQuantidade(double quantidade)
        {
            this.Quantidade += quantidade;
        }

        public void DiminuirQuantidade(double quantidade)
        {
            this.Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return "Nome: " + this._nome + ", Preço: " + FormatNumber(this.Preco) + ", Quantidade: " + FormatNumber(this.Quantidade);
        }
    }
}