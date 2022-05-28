using System;
using System.Reflection;

namespace Sorcery
{
	public class Program
	{
		interface ISorc
		{
			void Smile();
		}
		public class Sorcerer : ISorc
		{
			private string _name;
			private string _class;
			public int Mana {get; set; }
			public int HitPoints {get; set; }
			public string Pet;
			public Sorcerer(){}
			public Sorcerer(string name, string klass, string pet)
			{
				Mana = 30;
				HitPoints = 10;
				_name = name;
				_class = klass;
				Pet = pet;
			}

			public void CastSpell(int spellCost)
			{
				if (Mana == 0) Console.WriteLine("No mana lol!");
				else
				{
					Mana -= spellCost;
				}
				return;
			}
			public void Smile()
			{
				Console.WriteLine("lmao! kek");
			}
		}
		public static void Main(string[] args)
		{
			var sorcerer = new Sorcerer("Oliver", "Warlock", "Idea");
			// var sorcerer = new Sorcerer();
			var info = sorcerer.GetType().Assembly;
			var types = info.GetTypes();
			foreach (var type in types)
			{
				System.Console.WriteLine($"{type}");
				foreach(var method in type.GetMethods())
				{
					Console.WriteLine("Method: " + method);
				}
				foreach(var field in type.GetFields())
				{
					Console.WriteLine($"Field: {field}" );
				}
				foreach(var property in type.GetProperties())
				{
					Console.WriteLine($"Property: {property}" );
				}
				foreach(var constructor in type.GetConstructors())
				{
					Console.WriteLine($"Constructor: {constructor}");
				}
			}

			// Console.WriteLine(type);

		}
	}
}