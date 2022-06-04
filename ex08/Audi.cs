using System;

namespace FactoryExample
{
	public class Audi : Car
	{
		private int _cost;

		public Audi() => _cost = 120;
		public void PrintCost() => Console.WriteLine("Cost is: " + _cost);
	}
}