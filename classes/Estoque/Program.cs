using System;

namespace Estoque {
	class Program
	{
		static void Main(string[] args)
		{
			Produto caderno = new Produto();

			Console.Write("Insere o nome do produto: ");
			caderno.Nome = Console.ReadLine();

			Console.Write("Insere o preço: ");
			caderno.Preco = double.Parse(Console.ReadLine());

			Console.Write("Insere a quantidade inicial: ");
			caderno.Quantidade = double.Parse(Console.ReadLine());

			caderno.Imprimir();

			double quantidade;
			sbyte controller;

			do
			{
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine("Pressione 1 para adicionar quanatidade");
				Console.WriteLine("Presione -1 para remover quantidade");
				Console.WriteLine("Pressione zero para terminar");
				controller = sbyte.Parse(Console.ReadLine());

				if (controller == 1 || controller == -1)
				{
					Console.WriteLine();
					Console.Write("Insira a quantidade: ");
					quantidade = double.Parse(Console.ReadLine());

					if (controller == 1)
					{
						caderno.AdicionarProdutos(quantidade);
					}
					else
					{
						caderno.RemoverProdutos(quantidade);
					}

					Console.WriteLine();
					Console.WriteLine();
					caderno.Imprimir();
				}
				else if (controller != 0)
				{
					controller = 1;
				}

				quantidade = 0;

			} while (controller == 1 || controller == -1);
		}
	}
}