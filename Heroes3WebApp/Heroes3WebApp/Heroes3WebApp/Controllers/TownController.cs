using BLL.Services;
using Heroes3WebApp.Models;
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

            var result = new List<TownListViewModel>();

            foreach (var town in list)
            {
                result.Add(new TownListViewModel()
                {
                    Id = town.Id,
                    Name = town.Name,
                    Picture = town.Picture
                });
            }

            return View(result);
        }

        [HttpGet]
        public IActionResult TownInfo(int id)
        {
            var town = _townService.GetDetail(id);

            var result = new TownDetailViewModel();

            result.Id = town.Id;
            result.LandscapeId = town.LandscapeId;
            result.LandscapeName = town.LandscapeName;
            result.Name = town.Name;
            result.DetailPicture = town.DetailPicture;
            result.Discription = town.Discription;
            result.HeroClass_1 = town.HeroClass_1;
            result.HeroClass_2 = town.HeroClass_2;

            return View(result);
        }
    }
}
