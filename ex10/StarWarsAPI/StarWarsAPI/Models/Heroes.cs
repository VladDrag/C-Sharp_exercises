using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace StarWarsAPI.Models
{
    public class Heroes
    {
        [JsonPropertyName("results")]
        public List<Hero> HeroList { get; set; }

        public int NumberOfHeroes => HeroList.Count;
    }
}