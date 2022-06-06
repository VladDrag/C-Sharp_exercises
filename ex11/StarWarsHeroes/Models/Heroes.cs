using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace StarWarsHeroes.Models
{
    public class Heroes
    {
        [JsonPropertyName("results")]
        public List<Hero> HeroesList { get; set; }

        public int NumberOfHeroes => HeroesList.Count;
    }
}