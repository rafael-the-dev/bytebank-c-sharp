using System;
using System.Globalization;

namespace RemoveDuplicateds
{
	class Program
	{
		static void Main(string[] args) {
			int[] numbers = { 1, 2, 2, 3, 3, 3, 1, 7, 8, 2, 7 };
			int[] uniqueValues = new int[numbers.Length];

			for (sbyte i = 0; i < uniqueValues.Length; i++) {
				foreach(int number in numbers) {
					bool hasValue = false;

					for (int j = 0; j < uniqueValues.Length; j++) {
						if (uniqueValues[j] == number) {
							hasValue = true;
							break;
						}
					}

					if (!hasValue) {
						uniqueValues[i] = number;
					}
				}
			}

			//foreach (int number in numbers)
			//{
			//	bool hasValue = false;

			//	foreach (int uniqueValue in uniqueValues) {
			//		if (uniqueValue == number) hasValue = true;
			//	}

			//	if(!hasValue) uniqueValues.Append(number);
			//}

			Console.WriteLine($"Array size: { uniqueValues.Length }");
			Console.Write("Unique values: ");
			foreach(int value in uniqueValues) Console.Write($"{ value } ");
		}
	}
}