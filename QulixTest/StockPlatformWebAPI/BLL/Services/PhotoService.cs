using BLL.DTO;
using DAL.Interfaces;
using DAL.DbModels;

namespace BLL.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly IPhotoRepository<Photo> _photoRepository;
        private readonly IAuthorRepository<Author> _authorRepository;

        public PhotoService(IPhotoRepository<Photo> photo, IAuthorRepository<Author> author)
        {
            _photoRepository = photo;
            _authorRepository = author;
        }

        public async Task<PhotoDetailDTO> GetDetailAsync(int id)
        {
            var result = new PhotoDetailDTO();

            var photo = await _photoRepository.GetAsync(id);
            var author = await _authorRepository.GetAsync(photo.AuthorId);

            if (photo != null)
            {
                result.Id = photo.Id;
                result.AuthorId = author.Id;
                result.Cost = photo.Cost;
                result.DateOfCreation = photo.DateOfCreation;
                result.NumberOfSales = photo.NumberOfSales;
                result.Name = photo.Name;
                result.Link = photo.Link;
                result.Picture = photo.Picture;
                result.OriginalLength = photo.OriginalLength;
                result.OriginalWidth = photo.OriginalWidth;
                result.Raiting = photo.Raiting;
            }

            return result;
        }

        public async Task<List<PhotoListDTO>> GetListAsync()
        {
            var result = new List<PhotoListDTO>();

            var photos = await _photoRepository.GetAllAsync();

            foreach (var photo in photos)
            {
                result.Add(new PhotoListDTO()
                {
                    Id = photo.Id,
                    Name = photo.Name,
                    Picture = photo.Picture
                });
            }

            return result;
        }

        public async Task UpdateAsync(PhotoDetailDTO item)
        {
            var updatedPhoto = await _photoRepository.GetAsync(item.Id);
              
            if(updatedPhoto == null)
            {
                throw new NullReferenceException("Photo not found");
            }

            updatedPhoto.Id = item.Id;
            updatedPhoto.Name = item.Name;
            updatedPhoto.AuthorId = item.AuthorId;
            updatedPhoto.NumberOfSales = item.NumberOfSales;
            updatedPhoto.DateOfCreation = item.DateOfCreation;
            updatedPhoto.Cost = item.Cost;
            updatedPhoto.Picture = item.Picture;
            updatedPhoto.Link = item.Link;
            updatedPhoto.OriginalLength = item.OriginalLength;
            updatedPhoto.OriginalWidth = item.OriginalWidth;
            updatedPhoto.Raiting = item.Raiting;

            await _photoRepository.UpdateAsync(updatedPhoto);
        }
    }
}
