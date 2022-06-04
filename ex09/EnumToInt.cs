using System;

namespace Testing
{
	public class Program
	{
		public enum OperationType
		{
			Add,
			Subtract,
			Lol,
			kek
		}
		public static void Main(string[] args)
		{
			var optype = OperationType.Add;
			var optype2 = OperationType.Subtract;
			var optype3 = OperationType.Lol;
			var optype4 = OperationType.kek;

			Console.WriteLine(0 == (int)optype);
			Console.WriteLine(1 == (int)optype2);
			Console.WriteLine(2 == (int)optype3);
			Console.WriteLine(3 == (int)optype4);
		
		}
	}
}