using Library.BLL.Dtos.AuthorDtos;

namespace Library.BLL.Services.Contracts
{
    public interface IAuthorService
    {
        Task<ICollection<AuthorDto>> GetAuthors();

        Task<AuthorDto> GetAuthor(int? id);
    }
}
