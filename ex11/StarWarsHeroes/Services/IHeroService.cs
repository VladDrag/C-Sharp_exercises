using System.Threading.Tasks;
using StarWarsHeroes.Models;

namespace StarWarsHeroes.Services
{
    public interface IHeroService
    {
        public Task<Hero> GetHero(int id);
        public Task<Heroes> GetHeroes();
    }
}