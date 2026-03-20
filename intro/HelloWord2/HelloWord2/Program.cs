using System;
using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args) {
			Console.Write("Entre com seu nome completo: ");
			string name = Console.ReadLine();

			Console.Write("Quantos quartos tem na sua casa? ");
			sbyte bedrooms = sbyte.Parse(Console.ReadLine());

			Console.Write("Entre com o preço de um produto: ");
			double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Entre seu último nome, idade e altura: ");
			string details = Console.ReadLine();

			Console.WriteLine();
			Console.WriteLine("Você digitou: ");

			Console.WriteLine(name);
			Console.WriteLine(bedrooms);
			Console.WriteLine(price);

			foreach (string token in details.Split(" "))
			{
				Console.WriteLine(token);
			}

		}
	}
}