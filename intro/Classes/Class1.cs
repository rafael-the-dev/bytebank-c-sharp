using System;

namespace MyApp.Model {
	class Car {
		public string model;
		public int year;

		public Car(string modelName, int carYear)
		{
			model = modelName;
			year = carYear;
		}
	}
}