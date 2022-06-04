using System;

namespace FactoryExample
{
	public class Saab : Car
	{
		private int _cost;

		public Saab() => _cost = 110;
		public void PrintCost() => Console.WriteLine("Cost is: " + _cost);
	}
}