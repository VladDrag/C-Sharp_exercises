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
        // "all" / "id=1"
        static async Task Main(string[] args)
        {
            Console.WriteLine(args[0]);
            if (args[0] == "all") await PrintAllHeroes();
            // var service = new HeroesDownloader();
            // var controller = new SwapiController(service);
            //
            // var id = "1";
            //
            // var heroResponse = await controller.HeroCreator(id);
            // File.WriteAllText("Result.txt",$"{heroResponse.Name} is of the gender {heroResponse.Gender}, " +
            //                                $"and is {heroResponse.HeightInCm} centimeters tall.");

        }
    }
}