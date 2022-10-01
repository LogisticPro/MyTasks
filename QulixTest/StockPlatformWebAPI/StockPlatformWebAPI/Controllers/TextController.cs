using BLL.DTO;
using BLL.Services;
using DAL.DbModels;
using Microsoft.AspNetCore.Mvc;
using StockPlatformWebAPI.Models;

namespace StockPlatformWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly ITextService _textService;

        public TextController(ITextService textService)
        {
            _textService = textService;
        }

        [HttpGet]
        public async Task<ActionResult<Text>> GetListAsync()
        {
            var list = await _textService.GetListAsync();

            var result = new List<TextListViewModel>();

            foreach (var text in list)
            {
                result.Add(new TextListViewModel()
                {
                    Id = text.Id,
                    Name = text.Name,
                    Text1 = text.Text1
                });
            }

            return new ObjectResult(result);
        }

        [HttpPost]
        public async Task<ActionResult<Text>> CreateTextAsync(TextDetailViewModel text)
        {
            var result = new TextDetailDTO();

            result.Name = text.Name;
            result.Text1 = text.Text1;
            result.NumberOfSales = text.NumberOfSales;
            result.AuthorId = text.AuthorId;
            result.Cost = text.Cost;
            result.DateOfCreation = text.DateOfCreation;
            result.Raiting = text.Raiting;

            await _textService.AddAsync(result);

            return new ObjectResult(result);
        }
    }
}
