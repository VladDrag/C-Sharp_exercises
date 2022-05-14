using Xunit;
using FluentAssertions;

namespace SWAPI.Tests
{
	public class CharacterTests
	{
		[Fact]
		public async void stores_the_json_property_name()
		{
			//arrange
			var charUrl = "https://swapi.py4e.com/api/people/1";
			//arrange
			var service = new swAPIService();
			//arrange
			var chars = await service.GetCharAsync(charUrl);

			//act
			var result = chars.character.Name;

			//assert
			result.Should().Be("Luke Skywalker");
		}
	}
}