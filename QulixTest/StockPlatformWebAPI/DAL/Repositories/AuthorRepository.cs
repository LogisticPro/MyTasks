using DAL.DbModels;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class AuthorRepository : IAuthorRepository<Author>
    {
        private readonly StockPlatformDBContext _db;

        public AuthorRepository(StockPlatformDBContext db)
        {
            _db = db;
        }
        public async Task<Author> GetAsync(int id)
        {
            return await _db.Authors.FindAsync(id);
        }

        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            return await _db.Authors.ToListAsync();
        }
    }
}
