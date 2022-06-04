using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using StarWarsAPI.Models;
using StarWarsAPI.Services;

namespace StarWarsAPI.Controllers
{
    public class SwapiController
    {
        private IHeroesDownloader _heroesService;

        public SwapiController(IHeroesDownloader service) => _heroesService = service;

        public async Task<Heroes> HeroesCreator()
        {
            return await _heroesService.GetHeroes();
        }

        public async Task<Hero> HeroCreator(int id)
        {
            return await _heroesService.GetHero(id);
        }
    }
}

