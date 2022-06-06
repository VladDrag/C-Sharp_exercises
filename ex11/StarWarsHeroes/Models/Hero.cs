using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace StarWarsHeroes.Models
{
    public class Hero
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("hair_color")]
        public string HairColor { get; set; }
        
        [JsonPropertyName("skin_color")]
        public string SkinColor { get; set; }
        
        [JsonPropertyName("gender")]
        public string Gender { get; set; }
        
        // [JsonPropertyName("films")]
        // public List<Film> Films { get; set; }
    }
}