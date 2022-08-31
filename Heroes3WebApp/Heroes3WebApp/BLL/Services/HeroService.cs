using BLL.Dto;
using DAL.DbModels;
using DAL.Interfaces;

namespace BLL.Services
{
    public class HeroService : IHeroService
    {
        private readonly IRepository<Hero> _repository;

        public HeroService(IRepository<Hero> repository)
        {
            _repository = repository;
        }

        public List<HeroListDto> GetList()
        {
            var result = new List<HeroListDto>();

            var heroes = _repository.GetAll();

            foreach (var hero in heroes)
            {
                string? heroClass = string.Empty;

                if (hero.Type == 1)
                {
                    heroClass = hero.Town.HeroClass_1;
                }
                else if (hero.Type == 2)
                {
                    heroClass = hero.Town.HeroClass_2;
                }

                result.Add(new HeroListDto()
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
            return result;
        }
    }
}