using BLL.DTO;

namespace BLL.Services
{
    public interface IAuthorService
    {
        public Task<List<AuthorListDTO>> GetListAsync();
        public Task<AuthorDetailDTO> GetDetailAsync(int id);

    }
}
