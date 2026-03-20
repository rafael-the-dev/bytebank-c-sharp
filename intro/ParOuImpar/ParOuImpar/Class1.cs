
using System;
using System.Globalization;

namespace ParOuImpar
{
    public class Class1
    {
        static void Main(string[] args) {
            Console.Write("Insira um número: ");
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (number % 2 == 0) Console.WriteLine("Você inseriu um número par.");
            else Console.WriteLine("Você inseriu um número ímpar.");
        }
    }
}
