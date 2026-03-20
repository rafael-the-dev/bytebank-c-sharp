using System;

namespace Soma {
	class Program
	{
		static void Main(string[] args)
		{
			int number = 0;
			do
			{
				Console.Write("Insira um número maior que 1: ");

				number = int.Parse(Console.ReadLine());
			} while (number <= 1);


			int sum = 0;

			for (int i = 1; i <= number; i++)
			{
				sum += i;
			}

			Console.WriteLine($"O somatório dos 1 até {number} é: {sum}");
		}
	}
}