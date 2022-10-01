using DAL.DbModels;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class TextRepository : ITextRepository<Text>
    {
        private readonly StockPlatformDBContext _db;

        public TextRepository(StockPlatformDBContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Text item)
        {
            _db.Texts.Add(item);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Text>> GetAllAsync()
        {
            return await _db.Texts.Include(x => x.Author).ToListAsync();
        }
    }
}
