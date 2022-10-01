using BLL.Services;
using DAL.DbModels;
using Microsoft.AspNetCore.Mvc;
using StockPlatformWebAPI.Models;

namespace StockPlatformWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Author>> GetDetailAsync(int id)
        {
            var author = await _authorService.GetDetailAsync(id);

            var result = new AuthorDetailViewModel();

            result.Id = id;
            result.FirstName = author.FirstName;
            result.LastName = author.LastName;
            result.Nickname = author.Nickname;
            result.DateOfBirth = author.DateOfBirth;
            result.DateOfRegistration = author.DateOfRegistration;

            return new ObjectResult(result);
        }

        [HttpGet]
        public async Task<ActionResult<Author>> GetList()
        {
            var list = await _authorService.GetListAsync();

            var result = new List<AuthorListViewModel>();

            foreach (var author in list)
            {
                result.Add(new AuthorListViewModel()
                {
                    Id = author.Id,
                    Nickname = author.Nickname             
                });
            }

            return new ObjectResult(result);
        }
    }
}
