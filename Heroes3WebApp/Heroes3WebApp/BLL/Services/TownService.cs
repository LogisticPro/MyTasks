using BLL.Dto;
using DAL.DbModels;
using DAL.Interfaces;

namespace BLL.Services
{
    public class TownService : ITownService
    {
        private readonly IRepository<Town> _townRepository;
        private readonly IRepository<Landscape> _landscapeRepository;

        public TownService(IRepository<Town> repository, IRepository<Landscape> landscapeRepository)
        {
            _townRepository = repository;
            _landscapeRepository = landscapeRepository;
        }

        public List<TownListDto> GetList()
        {
            var result = new List<TownListDto>();

            var towns = _townRepository.GetAll();

            foreach (var town in towns)
            {
                result.Add(new TownListDto()
                {
                    Id = town.Id,
                    Name = town.Name,
                    Picture = town.Picture
                });
            }

            return result;
        }

        public TownDetailDto GetDetail(int id)
        {
            var result = new TownDetailDto();

            var town = _townRepository.Get(id);
            var landscape = _landscapeRepository.Get(town.LandscapeId);

            if (town != null)
            {
                result.Id = town.Id;
                result.LandscapeId = landscape.Id;
                result.LandscapeName = landscape.Name;
                result.Name = town.Name;
                result.DetailPicture = town.DetailPicture;
                result.Discription = town.Discription;
                result.HeroClass_1 = town.HeroClass_1;
                result.HeroClass_2 = town.HeroClass_2;
            }

            return result;
        }

        public void Delete(int id)
        {           
            var town = _townRepository.Get(id);

            if(town != null)
            {
                _townRepository.Delete(id);              
            }
        }

        public void Create(TownDetailDto item)
        {
            var town = new Town()
            {
                Name = item.Name,
                DetailPicture = item.DetailPicture,
                Discription = item.Discription,
                HeroClass_1 = item.HeroClass_1,
                HeroClass_2 = item.HeroClass_2,
                LandscapeId = item.LandscapeId,
                Picture = item.ListPicture
            };

            _townRepository.Create(town);
        }
    }
}
