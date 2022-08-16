using Heroes3WebApp.DbModels;
using Heroes3WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Heroes3WebApp.Services
{
    public class TownService : ITownService
    {
        public List<TownListModel> GetList()
        {
            var result = new List<TownListModel>();

            using (var db = new Heroes3DBContext())
            {
                var towns = db.Towns.ToList();

                foreach (var town in towns)
                {
                    result.Add(new TownListModel()
                    {
                        Id = town.Id,
                        Name = town.Name,
                        Picture = town.Picture
                    });
                }
            }
            return result;
        }

        public TownDetailModel GetDetail(int id)
        {
            var result = new TownDetailModel();

            using (var db = new Heroes3DBContext())
            {
                var town = db.Towns.Include(x => x.Landscape).FirstOrDefault(x => x.Id == id);

                if (town != null)
                {
                    result.Id = town.Id;
                    result.LandscapeId = town.LandscapeId;
                    result.LandscapeName = town.Landscape.Name;
                    result.Name = town.Name;
                    result.Picture = town.Picture;
                    result.Discription = town.Discription;
                    result.HeroClass_1 = town.HeroClass_1;
                    result.HeroClass_2 = town.HeroClass_2;
                }             
            }

            return result;
        }
    }
}
