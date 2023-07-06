using Library.BLL.Dtos.BookDtos;

namespace Library.BLL.Services.Contracts
{
    public interface IBookService
    {
        Task<ICollection<BookDto>> GetBooks();

        Task<BookDto> GetBook(int? id);

    }
}
