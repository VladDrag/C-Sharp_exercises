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

            var heroreses = await controller.HeroesCreator();
            var heroes = heroreses.HeroList;
            var writer = new StreamWriter(Directory.GetCurrentDirectory() + "//Results");
            Console.WriteLine(Directory.GetCurrentDirectory() + "//Results");
            writer.WriteLine("There are " + heroes.Count + " heroes in this list");
            for (var i = 0; i < heroes.Count; i++)
            {
                writer.WriteLine("For hero number " + i + "the name is " + heroes[i].Name);
            }
        }
    }
}