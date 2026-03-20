using System;
using System.Globalization;

namespace InvertArray
{
	class Program
	{
		static void Main(string[] args)
		{
			sbyte[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

			sbyte[] inverted = new sbyte[data.Length];

			for (sbyte i = (sbyte)(data.Length - 1); i >= 0; i--) {
				sbyte index = (sbyte)(data.Length - 1 - i);
				inverted[index] = data[i];
			}

			Console.Write("Inverted array: ");
			foreach (sbyte number in inverted) Console.Write($"{number}, ");
		}
	}
}