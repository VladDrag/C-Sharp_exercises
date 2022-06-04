using System;

namespace FactoryExample
{
	public class Volkwagen : Car
	{
		private int _cost;

		public Volkwagen() => _cost = 100;
		public void PrintCost() => Console.WriteLine("Cost is: " + _cost);
	}
}