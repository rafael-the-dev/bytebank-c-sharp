using System;
using System.Data;
using System.Globalization;

namespace ExercicioSemOO {
	class Prograam
	{
		static double CalculaP(double a, double b, double c) {
			double p = (a + b + c) / 2.0;

			return p;
		}

		static double CalculaArea(double a, double b, double c) { 
			double p = CalculaP(a, b, c);

			double area = Math.Sqrt(
				p * (p -a )* (p -b) * (p -c)
			);

			return area;
		}

		static void Main(String[] args)
		{
			double[] sidesX = new double[3];

			for (sbyte i = 0; i < sidesX.Length; i++)
			{
				Console.Write("Insere um número: ");
				sidesX[i] = double.Parse(Console.ReadLine());
			}

			double areaX = CalculaArea(sidesX[0], sidesX[1], sidesX[2]);

			double[] sidesY = new double[3];

			for (sbyte i = 0; i < sidesY.Length; i++)
			{
				Console.Write("Insere um número: ");
				sidesY[i] = double.Parse(Console.ReadLine());
			}

			double areaY = CalculaArea(sidesY[0], sidesY[1], sidesY[2]);
			string maiorArea = areaX == areaY ? "São Iguais" : ( areaX > areaY ? "X" : "Y");

			Console.WriteLine($"Area X: {areaX}");
			Console.WriteLine($"Area Y: {areaY}");
			Console.WriteLine($"A maior area é: {maiorArea}");
		}
	}
}