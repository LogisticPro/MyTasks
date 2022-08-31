using DAL.DbModels;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class LandscapeRepository : IRepository<Landscape>
    {
        private readonly Heroes3DBContext _db;

        public LandscapeRepository(Heroes3DBContext context)
        {
            _db = context;
        }
        public void Create(Landscape item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Landscape Get(int id)
        {
            return _db.Landscapes.Find(id);
        }

        public IEnumerable<Landscape> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Landscape item)
        {
            throw new NotImplementedException();
        }
    }
}
