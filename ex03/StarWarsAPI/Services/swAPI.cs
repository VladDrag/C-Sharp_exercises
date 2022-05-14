using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace SWAPI
{
	public class swAPIService
	{
		HttpClient client = new HttpClient();
		public async Task<CharacterResponse> GetCharAsync(string url)
		{
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			// var url = $"https://swapi.py4e.com/api/people/{id}";

			var character = client.GetStreamAsync(url);
			return await JsonSerializer.DeserializeAsync<CharacterResponse>(await character);
		}
	}
}