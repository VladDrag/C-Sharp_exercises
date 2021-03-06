using System;
using System.Linq;
using StarWarsAPI.Controllers;
using StarWarsAPI.Services;
using Xunit;
using FluentAssertions;

namespace Swapi.Tests
{
    public class ControllerTests
    {
        [Fact]
        public async void heroes_list_should_be_bigger_than_1()
        {
            var service = new HeroesDownloader();
            var controller = new SwapiController(service);

            var heroes = await controller.HeroesCreator();

            heroes.HeroList.Count.Should().BeGreaterThan(1);
            heroes.HeroList.Count.Should().Be(10);
        }
        
        [Fact]
        public async void first_hero_name_should_be_Luke()
        {
            var service = new HeroesDownloader();
            var controller = new SwapiController(service);

            var heroes = await controller.HeroesCreator();

            heroes.HeroList[0].Name.Should().Be("Luke Skywalker");
        }
    }
}