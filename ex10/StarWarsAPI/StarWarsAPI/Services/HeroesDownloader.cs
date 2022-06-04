using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using StarWarsAPI.Models;

namespace StarWarsAPI.Services
{
    public class HeroesDownloader : IHeroesDownloader
    {
        public async Task<Hero> GetHero(string id)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var url = $"https://swapi.py4e.com/api/people/{id}";
            var heroTask = client.GetStreamAsync(url);

        
            return  await JsonSerializer.DeserializeAsync<Hero>(await heroTask);
        }
        
        public async Task<Hero> GetHeroes()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var url = "https://swapi.py4e.com/api/people/";
            var heroesTask = client.GetStreamAsync(url);

        
            return  await JsonSerializer.DeserializeAsync<Hero>(await heroesTask);
        }

    }
}