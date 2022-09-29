using BLL.Dto;
using DAL.DbModels;
using DAL.Interfaces;

namespace BLL.Services
{
    public class LandscapeService : ILandscapeService
    {
        private IRepository<Landscape> _repository;

        public LandscapeService(IRepository<Landscape> repository)
        {
            _repository = repository;
        }
        public List<LandscapeDto> GetList()
        {
            var result = new List<LandscapeDto>();

            var list = _repository.GetAll();    

            foreach (var item in list)
            {
                result.Add(new LandscapeDto
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }

            return result;
        }
    }
}
