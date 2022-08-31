using Microsoft.AspNetCore.Mvc;
using BLL.Services;
using Heroes3WebApp.Models;

namespace Heroes3WebApp.Controllers
{
    public class HeroController : Controller
    {
        private readonly IHeroService _heroService;
        public HeroController(IHeroService heroService)
        {
            _heroService = heroService;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult List()
        {
            var list = _heroService.GetList();

            var result = new List<HeroListViewModel>();

            foreach (var hero in list)
            {
                result.Add(new HeroListViewModel()
                {
                    Id = hero.Id,
                    TownId = hero.TownId,
                    Picture = hero.Picture,
                    Name = hero.Name,
                    TownName = hero.TownName,
                    Class = hero.Class,
                    Type = hero.Type,
                    TownPicture = hero.TownPicture
                });
            }

            return View(result);
        }
    }
}
