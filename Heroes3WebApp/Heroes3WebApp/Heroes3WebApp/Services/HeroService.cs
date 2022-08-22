using Heroes3WebApp.DbModels;
using Heroes3WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Heroes3WebApp.Services
{
    public class HeroService : IHeroService
    {
        public List<HeroModel> GetList()
        {
            var result = new List<HeroModel>();

            using (var db = new Heroes3DBContext())
            {
                var heroes = db.Heroes.Include(x => x.Town).ToList();

                foreach (var hero in heroes)
                {
                    string? heroClass = string.Empty;

                    if(hero.Type == 1)
                    {
                        heroClass = hero.Town.HeroClass_1;
                    }
                    else if(hero.Type == 2)
                    {
                        heroClass = hero.Town.HeroClass_2;
                    }

                    result.Add(new HeroModel()
                    {
                        Id = hero.Id,
                        TownId = hero.TownId,
                        Picture = hero.Picture,
                        Name = hero.Name,                      
                        TownName = hero.Town.Name,
                        Class = heroClass,
                        Type = hero.Type,                      
                        TownPicture = hero.Town.Picture
                    });
                }
            }
            return result;
        }
    }
}
