using BLL.DTO;

namespace BLL.Services
{
    public interface IPhotoService
    {
        public Task<List<PhotoListDTO>> GetListAsync();
        public Task<PhotoDetailDTO> GetDetailAsync(int id);
        public Task UpdateAsync(PhotoDetailDTO photo);
    }
}
