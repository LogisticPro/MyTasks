using BLL.DTO;

namespace BLL.Services
{
    public interface ITextService
    {
        public Task<List<TextListDTO>> GetListAsync();
        public Task AddAsync(TextDetailDTO item);
    }
}
