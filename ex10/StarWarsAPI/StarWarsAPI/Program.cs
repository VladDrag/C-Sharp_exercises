using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using StarWarsAPI.Controllers;
using StarWarsAPI.Services;

namespace StarWarsAPI
{
    class Program
    {
        static async Task PrintAllHeroes()
        {
            var service = new HeroesDownloader();
            var controller = new SwapiController(service);

            var heroesResponse = await controller.HeroesCreator();
            var heroes = heroesResponse.HeroList;
            
            File.WriteAllText("Result.txt", "Count is = " + heroesResponse.NumberOfHeroes + "\n");
            foreach (var hero in heroes)
            {
                File.AppendAllText("Result.txt", "Hero name is :" + hero.Name + "\n");
            }
        }
        static async Task Main(string[] args)
        {
            Console.WriteLine(args[0]);
            if (args[0] == "all") await PrintAllHeroes();


            var input = args[0].Split("=");
            Console.WriteLine(input[0]);
            Console.WriteLine(input[1]);
            if (input[0] =="id" && int.TryParse(input[1], out var id))
            {
                Console.WriteLine("if statement passed");
                var heroResponse = await controller.HeroCreator(input[1]);
                Console.WriteLine(heroResponse.Name);
                File.WriteAllText("Result.txt",$"{heroResponse.Name} is of the gender {heroResponse.Gender}, " +
                                               $"and is {heroResponse.HeightInCm} centimeters tall.");
            }



        }
    }
}