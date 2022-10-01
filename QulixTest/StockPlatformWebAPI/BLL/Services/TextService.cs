using BLL.DTO;
using DAL.DbModels;
using DAL.Interfaces;

namespace BLL.Services
{
    public class TextService : ITextService
    {
        private readonly ITextRepository<Text> _textRepository;
        public TextService(ITextRepository<Text> text)
        {
            _textRepository = text;
        }
        public async Task AddAsync(TextDetailDTO item)
        {
            var text = new Text()
            {
                Name = item.Name,
                Text1 = item.Text1,
                AuthorId = item.AuthorId,
                Cost = item.Cost,
                DateOfCreation = item.DateOfCreation,
                Raiting = item.Raiting,
                NumberOfSales = item.NumberOfSales               
            };

            await _textRepository.AddAsync(text);
        }

        public async Task<List<TextListDTO>> GetListAsync()
        {
            var result = new List<TextListDTO>();

            var texts = await _textRepository.GetAllAsync();

            foreach (var text in texts)
            {
                result.Add(new TextListDTO()
                {
                    Id = text.Id,
                    Name = text.Name,
                    Text1 = text.Text1
                });
            }

            return result;
        }
    }
}
