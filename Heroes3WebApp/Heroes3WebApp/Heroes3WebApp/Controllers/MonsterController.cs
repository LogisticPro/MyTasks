using BLL.Services;
using Heroes3WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Heroes3WebApp.Controllers
{
    public class MonsterController : Controller
    {
        private readonly IMonsterService _monsterService;

        public MonsterController(IMonsterService monsterservice)
        {
            _monsterService = monsterservice; 
        }

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            var list = _monsterService.GetList();

            var result = new List<MonsterListViewModel>();

            foreach (var monster in list)
            {
                result.Add(new MonsterListViewModel()
                {
                    Id = monster.Id,
                    TownId = monster.TownId,
                    Picture = monster.Picture,
                    Name = monster.Name,
                    Hp = monster.Hp,
                    Attack = monster.Attack,
                    Defence = monster.Defence,
                    Damage = monster.Damage,
                    Speed = monster.Speed,
                    Discription = monster.Discription,
                    Level = monster.Level
                });
            }

            return View(result);
        }
    }
}
