using Heroes3WebApp.Services;
using Microsoft.AspNetCore.Mvc;

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

            return View(list);
        }
    }
}
