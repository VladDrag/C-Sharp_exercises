using System;

namespace FactoryExample
{
	public class Volkswagen : Car
	{
		private int _cost;

		public Volkswagen() => _cost = 100;
		public void PrintCost() => Console.WriteLine("Cost is: " + _cost);
	}
}
