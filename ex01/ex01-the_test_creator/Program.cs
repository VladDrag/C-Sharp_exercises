// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace tester_program
{
	public class Solution
	{
		public int get_age(string age)
		{
			return int.Parse(age);
		}

		public int add(int x, int y)
		{
			return x + y;
		}

		public string is_even_odd(int x)
		{
			return (x % 2 == 0) ? "even" : "odd";
		}
	}
}
