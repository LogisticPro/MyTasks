using BLL.Dto;
using DAL.DbModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TownService : ITownService
    {
        private readonly IRepository<Town> _repository;
        private readonly IRepository<Landscape> _landscapeRepository;

        public TownService(IRepository<Town> repository, IRepository<Landscape> landscapeRepository)
        {
            _repository = repository;
            _landscapeRepository = landscapeRepository;
        }

        public List<TownListDto> GetList()
        {
            var result = new List<TownListDto>();

            var towns = _repository.GetAll();

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

            var town = _repository.Get(id);
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
    }
}
