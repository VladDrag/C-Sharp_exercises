using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarWarsHeroes.Models;
using StarWarsHeroes.Services;

namespace StarWarsHeroes.Controllers
{
    public class HeroController : Controller
    {
        private IHeroService _service;

        public HeroController(IHeroService service) => _service = service;

        
        
    }
}