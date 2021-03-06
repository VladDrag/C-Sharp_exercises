using System.Text.Json.Serialization;

namespace StarWarsAPI.Models
{
    public class Hero
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("gender")]
        public string Gender { get; set; }
        
        [JsonPropertyName("height")]
        public string HeightInCm { get; set; }

        public string HeightInMm
        {
            get
            {
                if (string.IsNullOrEmpty(HeightInCm)) return "0";
                if (!int.TryParse(HeightInCm, out var result)) return "0";

                return (result * 10).ToString();
            }
        }
    }
}