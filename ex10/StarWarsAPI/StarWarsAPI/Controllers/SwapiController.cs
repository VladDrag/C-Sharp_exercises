using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using StarWarsAPI.Models;
using StarWarsAPI.Services;

namespace StarWarsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SwapiController
    {
        private IHeroesDownloader _heroesService;

        public SwapiController(IHeroesDownloader service) => _heroesService = service;
        
        [HttpGet]
        public async Task<IEnumerable<Hero>> HeroesCreator()
        {
            return await _heroesService.GetHeroes();
        }

        [HttpGet("{id}")]
        public async Task<Hero> HeroCreator(string id)
        {
            return await _heroesService.GetHero(int.Parse(id));
        }
    }
}

