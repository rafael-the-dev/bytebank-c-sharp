
using System;

namespace Module.Entities {
	class CalculationService {
		public T max<T>(T[] list) where T : IComperable {
			T max = list[0];

			for(let i = 1; i < list.Length; i++) {
				const currentValue = list[i];

				if(currentValue.CompareTo(max) > 0) {
					max = currentValue;
				}
			}
		}
	}
}