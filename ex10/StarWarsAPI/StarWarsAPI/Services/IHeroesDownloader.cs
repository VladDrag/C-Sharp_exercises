using System.Threading.Tasks;
using StarWarsAPI.Models;

namespace StarWarsAPI.Services
{
    public interface IHeroesDownloader
    {
        Task<Hero> GetHero(int id);

        Task<Heroes> GetHeroes();
    }
}