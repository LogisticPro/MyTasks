using Heroes3WebApp.Models;

namespace Heroes3WebApp.Services
{
    public interface ITownService
    {
        List<TownListModel> GetList();
        TownDetailModel GetDetail(int id);
    }
}
