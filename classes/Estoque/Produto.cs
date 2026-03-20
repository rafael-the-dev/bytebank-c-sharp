using System;
using System.Globalization;

namespace Estoque
{
	class Produto
	{
		public string Nome;
		public double Preco;
		public double Quantidade;

		public void AdicionarProdutos(double quantidade)
		{
			Quantidade += quantidade;
		}

		public void RemoverProdutos(double quantidade)
		{
			Quantidade -= quantidade;
		}

		public double ValorTotalEmEstoque()
		{
			return Quantidade * Preco;
		}

		public void Imprimir() {
			Console.WriteLine($"Nome: { Nome }");
			Console.WriteLine($"Preço: { Preco }");
			Console.WriteLine($"Quantidade: { Quantidade }");
			Console.WriteLine($"Valor total no estoque: { ValorTotalEmEstoque() }");
		}

        public override string ToString()
        {
			return Nome + ", $ " + Preco.ToString("f2", CultureInfo.InvariantCulture);
        }
	}
}