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
        static async Task Main(string[] args)
        {
            var service = new HeroesDownloader();
            var controller = new SwapiController(service);

            // var heroesResponse = await controller.HeroesCreator();
            // var heroes = heroesResponse.HeroList;
            //
            // File.WriteAllText("Result.txt", "Count is = " + heroes.Count + "\n");
            // foreach (var hero in heroes)
            // {
            //     File.AppendAllText("Result.txt", "Hero name is :" + hero.Name + "\n");
            // }

            var id = "1";

            var heroResponse = await controller.HeroCreator(id);
            File.WriteAllText("Result.txt",$"{heroResponse.Name} is of the gender {heroResponse.Gender}, " +
                                           $"and is {heroResponse.HeightInCm} centimeters tall.");

        }
    }
}