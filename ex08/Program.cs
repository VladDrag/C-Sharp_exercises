using System;
// using AudiFactory; 

namespace FactoryExample
{
	public class FactoryExample
	{
		public static void Main(string[] args)
		{
			Console.WriteLine((new AudiFactory()).ProductionList.Count);
		}
	}
}