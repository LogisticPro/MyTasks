using Heroes3WebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace Heroes3WebApp.Controllers
{
    public class TownController : Controller
    {
        private readonly ITownService _townService;
        public TownController(ITownService townService)
        {
            _townService = townService;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult List()
        {
            var list = _townService.GetList();

            return View(list);
        }

        [HttpGet]
        public IActionResult TownInfo(int id)
        {
            var town = _townService.GetDetail(id);

            return View(town);
        }
    }
}
