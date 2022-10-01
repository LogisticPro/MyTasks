using BLL.DTO;
using DAL.DbModels;
using DAL.Interfaces;

namespace BLL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository<Author> _authorRepository;
        public AuthorService(IAuthorRepository<Author> author)
        {
            _authorRepository = author;
        }

        public async Task<AuthorDetailDTO> GetDetailAsync(int id)
        {
            var result = new AuthorDetailDTO();

            var author = await _authorRepository.GetAsync(id);

            if (author == null)
            {
                throw new NullReferenceException("Author not found");
            }

            result.Id = author.Id;
            result.FirstName = author.FirstName;
            result.LastName = author.LastName;
            result.Nickname = author.Nickname;
            result.DateOfBirth = author.DateOfBirth;
            result.DateOfRegistration = author.DateOfRegistration;

            return result;
        }

        public async Task<List<AuthorListDTO>> GetListAsync()
        {
            var result = new List<AuthorListDTO>();

            var authors = await _authorRepository.GetAllAsync();

            foreach (var author in authors)
            {
                result.Add(new AuthorListDTO()
                {
                    Id = author.Id,
                    Nickname = author.Nickname
                });
            }

            return result;
        }
    }
}
