using Library.BLL.Dtos.AuthorDtos;
using Library.BLL.Dtos.BookDtos;
using Library.BLL.Services.Contracts;
using LibraryDAL.Repositories;
using LibraryDAL.Repositories.Contracts;

namespace Library.BLL.Services
{
    public class AuthorManager : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorManager(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<AuthorDto> GetAuthor(int? id)
        {
            var author = await _authorRepository.GetByIdAsync(id);

            if (author == null) return new AuthorDto();

            var authorDto = new AuthorDto
            {
                Id = author.Id,
                Name = author.Name,
                Surname = author.Surname,
                Age = author.Age
            };


            return authorDto;
        }

        public async Task<ICollection<AuthorDto>> GetAuthors()
        {
            var authors = await _authorRepository.GetAllAsync();

            var authorDtos = new List<AuthorDto>();

            foreach (var item in authors)
            {
                authorDtos.Add(new AuthorDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Surname= item.Surname,
                    Age= item.Age,
                });
            }

            return authorDtos;
        }
    }
}
