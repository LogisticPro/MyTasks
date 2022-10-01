namespace DAL.Interfaces
{
    public interface ITextRepository<Text>
    {
        Task<IEnumerable<Text>> GetAllAsync();
        Task AddAsync(Text item);
    }
}
