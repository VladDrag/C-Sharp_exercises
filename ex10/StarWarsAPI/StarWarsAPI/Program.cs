using System;
using System.IO;
using System.Linq;
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

            var heroes = await controller.HeroesCreator();
            var toptext = $"There are {heroes} heroes in this document";
            
            // Write the number of heroes heroes.numberof then the name of each hero
            var namelist = heroes.Select(hero => hero.Name);
            namelist.Prepend(toptext);
            await File.WriteAllLinesAsync("WriteLines.txt", namelist);

        }
    }
}