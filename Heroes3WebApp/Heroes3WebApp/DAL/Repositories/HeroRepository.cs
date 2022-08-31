using DAL.DbModels;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    internal class HeroRepository : IRepository<Hero>
    {
        private readonly Heroes3DBContext _db;

        public HeroRepository(Heroes3DBContext context)
        {
            _db = context;
        }

        public void Create(Hero item)
        {
            _db.Heroes.Add(item);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            Hero item = _db.Heroes.Find(id);

            if (item != null)
            {
                _db.Heroes.Remove(item);
                _db.SaveChanges();
            }
        }

        public Hero Get(int id)
        {
            return _db.Heroes.Find(id);
        }

        public IEnumerable<Hero> GetAll()
        {
            return _db.Heroes.Include(x => x.Town).ToList();
        }

        public void Update(Hero item)
        {
            if( item != null)
            {
                _db.Heroes.Update(item);
                _db.SaveChanges();
            }
        }
    }
}
