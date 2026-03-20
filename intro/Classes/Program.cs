using System;
using MyApp.Model;
//using MyApp.Human;

namespace MyApp {
	class Program {
		static void Main(string[] args) {
			Car mazda = new Car("Mazda Demio", 2018);

			Console.WriteLine($"Model: {mazda.model}");
			Console.WriteLine($"Year: {mazda.year} ");
		}
	}
}