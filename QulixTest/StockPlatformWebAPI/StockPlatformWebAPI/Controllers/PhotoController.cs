using Microsoft.AspNetCore.Mvc;
using BLL.Services;
using StockPlatformWebAPI.Models;
using DAL.DbModels;
using BLL.DTO;

namespace StockPlatformWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IPhotoService _photoService;

        public PhotoController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Photo>> GetDetailAsync(int id)
        {
            var photo = await _photoService.GetDetailAsync(id);

            if(photo == null)
            {
                throw new NullReferenceException("Photo not found");
            }

            var result = new PhotoDetailViewModel();

            result.Id = photo.Id;
            result.AuthorId = photo.AuthorId;
            result.Name = photo.Name;
            result.Link = photo.Link;
            result.Picture = photo.Picture;
            result.DateOfCreation = photo.DateOfCreation;
            result.OriginalLength = photo.OriginalLength;
            result.OriginalWidth = photo.OriginalWidth;
            result.NumberOfSales = photo.NumberOfSales;
            result.Raiting = photo.Raiting;
            result.Cost = photo.Cost;

            return new ObjectResult(result);
        }

        [HttpGet]
        public async Task<ActionResult<Photo>> GetListAsync()
        {
            var list = await _photoService.GetListAsync();

            var result = new List<PhotoListViewModel>();

            foreach (var photo in list)
            {
                result.Add(new PhotoListViewModel()
                {
                    Id = photo.Id,
                    Name = photo.Name,
                    Picture = photo.Picture
                });
            }

             return new ObjectResult(result);
        }

        [HttpPut]
        public async Task<ActionResult<Photo>> UpdateAsync(PhotoDetailViewModel photo)
        {
            if (photo == null)
            {
                return BadRequest();
            }

            var result = new PhotoDetailDTO()
            {
                Picture = photo.Picture,
                DateOfCreation = photo.DateOfCreation,
                OriginalLength = photo.OriginalLength,
                OriginalWidth = photo.OriginalWidth,
                NumberOfSales = photo.NumberOfSales,
                Raiting = photo.Raiting,
                Cost = photo.Cost,
                Id = photo.Id,
                AuthorId = photo.AuthorId,
                Link = photo.Link,
                Name = photo.Name              
            };

            await _photoService.UpdateAsync(result);

            return Ok(result);
        }
    }
}
