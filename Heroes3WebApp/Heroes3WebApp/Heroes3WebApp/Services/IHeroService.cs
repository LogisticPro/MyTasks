using Heroes3WebApp.Models;

namespace Heroes3WebApp.Services
{
    public interface IHeroService
    {
        List<HeroModel> GetList();
    }
}
