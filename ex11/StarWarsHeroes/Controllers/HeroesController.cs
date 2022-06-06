using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarWarsHeroes.Models;
using StarWarsHeroes.Services;

namespace StarWarsHeroes.Controllers
{
    public class HeroesController : Controller
    {
        private static IHeroService _service = new HeroService();
        
        
        
        public async Task<IActionResult> Heroes()
        {
            return View(await _service.GetHeroes());
        }
    }
}