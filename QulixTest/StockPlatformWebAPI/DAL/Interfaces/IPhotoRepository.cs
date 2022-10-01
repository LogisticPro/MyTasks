namespace DAL.Interfaces
{
    public interface IPhotoRepository<Photo>
    {
        Task<IEnumerable<Photo>> GetAllAsync();
        Task<Photo> GetAsync(int id);
        Task UpdateAsync(Photo item);
    }
}
