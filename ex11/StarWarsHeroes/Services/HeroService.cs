using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using StarWarsHeroes.Models;

namespace StarWarsHeroes.Services
{
    public class HeroService : IHeroService
    {
        public async Task<Hero> GetHero(int id)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            var url = $"https://swapi.py4e.com/api/people/{id}";
            var response = client.GetStreamAsync(url);
            return await JsonSerializer.DeserializeAsync<Hero>(await response);
        }


        public async Task<Heroes> GetHeroes()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            var url = $"https://swapi.py4e.com/api/people";
            var response = client.GetStreamAsync(url);
            return await JsonSerializer.DeserializeAsync<Heroes>(await response);
        }
    }
}