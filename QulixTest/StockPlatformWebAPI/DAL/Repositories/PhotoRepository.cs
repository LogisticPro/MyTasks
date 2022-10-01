using DAL.DbModels;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    internal class PhotoRepository : IPhotoRepository<Photo>
    {
        private readonly StockPlatformDBContext _db;

        public PhotoRepository(StockPlatformDBContext db)
        {
            _db = db;
        }

        public async Task<Photo> GetAsync(int id)
        {
            return await _db.Photos.FindAsync(id);
        }

        public async Task<IEnumerable<Photo>> GetAllAsync()
        {
            return await _db.Photos.Include(x => x.Author).ToListAsync();
        }

        public async Task UpdateAsync(Photo item)
        {
            if (item != null)
            {
                _db.Photos.Update(item);
                await _db.SaveChangesAsync();
            }
        }
    }
}
