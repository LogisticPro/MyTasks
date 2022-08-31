using DAL.DbModels;
using DAL.Interfaces;

namespace DAL.Repositories
{
    internal class MonsterRepository : IRepository<Monster>
    {
        private readonly Heroes3DBContext _db;

        public MonsterRepository(Heroes3DBContext context)
        {
            _db = context;
        }
        public void Create(Monster item)
        {
            _db.Add(item);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            Monster item = _db.Monsters.Find(id);

            if (item != null)
            {
                _db.Monsters.Remove(item);
                _db.SaveChanges();
            }
        }

        public Monster Get(int id)
        {
            
            return _db.Monsters.Find(id);
        }

        public IEnumerable<Monster> GetAll()
        {
            return _db.Monsters.ToList();
        }

        public void Update(Monster item)
        {
            if(item != null)
            {
                _db.Monsters.Update(item);
                _db.SaveChanges();
            }          
        }
    }
}
