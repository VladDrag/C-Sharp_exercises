using System.Text.Json.Serialization;

namespace StarWarsHeroes.Models
{
    public class Film
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        
        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }
    }
}