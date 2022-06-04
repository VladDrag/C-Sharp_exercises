using StarWarsAPI.Models;

namespace StarWarsAPI.Services
{
    interface IHeroesDownloader
    {
        Hero GetHero();
    }
}