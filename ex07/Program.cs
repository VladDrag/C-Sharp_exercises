using System;

namespace Testt
{
	public class Tesstt
	{
		public enum OperationType
		{
			Add = 0,
			Subtract = 1
		}
		public static void Printer(System.Enum id)
		{
			Console.WriteLine(id.ToString());
		}
		public static void Main()
		{
			Printer(OperationType.Add);
		}
	}
}