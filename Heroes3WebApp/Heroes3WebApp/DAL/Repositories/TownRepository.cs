using DAL.DbModels;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    internal class TownRepository : IRepository<Town>
    {
        private readonly Heroes3DBContext _db;

        public TownRepository(Heroes3DBContext context)
        {
            _db = context;
        }
        public void Create(Town item)
        {
            _db.Towns.Add(item);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            Town item = _db.Towns.Find(id);

            if (item != null)
            {
                _db.Towns.Remove(item);
                _db.SaveChanges();
            }
        }

        public Town Get(int id)
        {
            return _db.Towns.Find(id);
        }

        public IEnumerable<Town> GetAll()
        {
            return _db.Towns.ToList();
        }

        public void Update(Town item)
        {
            if (item != null)
            {
                _db.Towns.Update(item);
                _db.SaveChanges();
            }
        }
    }
}
