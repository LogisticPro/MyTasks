using BLL.Dto;
using BLL.Services;
using Heroes3WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Heroes3WebApp.Controllers
{
    public class TownController : Controller
    {
        private readonly ITownService _townService;
        private readonly ILandscapeService _landscapeService;
        public TownController(ITownService townService, ILandscapeService landscapeService)
        {
            _townService = townService;
            _landscapeService = landscapeService;
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

        [HttpPost]
        public IActionResult CreateTown(TownDetailViewModel town)
        {
            var result = new TownDetailDto();

            result.LandscapeId = town.LandscapeId;
            result.LandscapeName = town.LandscapeName;
            result.Name = town.Name;
            result.DetailPicture = town.DetailPicture;
            result.Discription = town.Discription;
            result.HeroClass_1 = town.HeroClass_1;
            result.HeroClass_2 = town.HeroClass_2;
            result.ListPicture = town.ListPicture;

            _townService.Create(result);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateTown()
        {
            var lanscapes = _landscapeService.GetList();

            var result = new Dictionary<int, string>();

            foreach (var item in lanscapes)
            {
                result.Add(item.Id, item.Name);
            }

            this.ViewData["landscapes"] = new SelectList(lanscapes, "Id", "Name");

            return View();
        }
    }
}
