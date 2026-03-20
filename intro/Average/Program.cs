using System;
using System.Globalization;

namespace Average
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			int max = 0;
			int min = 0;

			for (sbyte counter = 0; counter < 10; counter++)
			{
				Console.Write("Insere um número: ");
				int numero = int.Parse(Console.ReadLine());

				if (numero > max) max = numero;
				if (numero < min) min = numero;

				sum += numero;
			}

			double average = 0;

			if (sum > 0) average = (double)(sum / 10);

			Console.WriteLine($"A soma total dos 10 números é: { sum }");
			Console.WriteLine($"A média dos 10 números é: { average }");
			Console.WriteLine($"O maior número é: { max }");
			Console.WriteLine($"O menor número é: { min }");
		}
	}
}