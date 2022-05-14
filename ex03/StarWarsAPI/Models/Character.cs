using System;
using System.Text.Json.Serialization;

namespace SWAPI
{
	public class Character
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }
	}
}