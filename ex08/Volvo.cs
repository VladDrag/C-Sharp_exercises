using System;

namespace FactoryExample
{
	public class Volvo : Car
	{
		private int _cost;

		public Volvo() => _cost = 150;
		public void PrintCost() => Console.WriteLine("Cost is: " + _cost);
	}
}