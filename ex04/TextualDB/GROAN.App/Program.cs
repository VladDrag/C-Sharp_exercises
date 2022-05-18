using System;
using System.Linq;
using System.IO;
using GROAN.Business;

namespace GROAN.App
{
	class Program
	{
		static bool ArgChecker(string[] args)
		{
			if (!args.Any())
			{
				Console.WriteLine("Please write the desired data input");
				return false;
			}
			if (!args[1].Contains("-name:"))
			{
				Console.WriteLine("Please use the correct input format.");
				return false;
			}
			return true;
		}
		static void Main(string[] args)
		{
			var infoPrinter = new AddressHandler();
			if (!ArgChecker(args)) Environment.Exit(1);
			var directoryPath = Directory.GetCurrentDirectory() + "./data";
			var lastNameFilter = args[1]
								.Split(":")[1];
			var result = infoPrinter.PrintAddress(directoryPath, lastNameFilter);
			Console.WriteLine(result);

		}
	}
}
