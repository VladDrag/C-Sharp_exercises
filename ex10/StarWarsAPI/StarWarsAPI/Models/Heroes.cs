using System.Collections.Generic;

namespace StarWarsAPI.Models
{
    public class Heroes
    {
        public List<Hero> HeroList { get; set; }

        public int NumberOfHeroes => HeroList.Count;
    }
}