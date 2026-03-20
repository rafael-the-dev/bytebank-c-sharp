using System;
using System.Globalization;

namespace Factorial {
	class Program
	{
		static int calculaFactorial(int value) {
			int total = 1;

			for (int i = value; value > 1; value--) {
				total *= value;
			}

			return total;
		}
		static void Main(string[] args)
		{
			int number = 0;

			do
			{
				Console.Write("Insere um número maior que 1: ");
				number = int.Parse(Console.ReadLine());
			} while (number <= 0);

			Console.WriteLine($"Factorial de {number} é: {calculaFactorial(number)}");

		}
	}
}