namespace DAL.Interfaces
{
    public interface IAuthorRepository<Author>
    {
        Task<IEnumerable<Author>> GetAllAsync();
        Task<Author> GetAsync(int id);
    }
}
