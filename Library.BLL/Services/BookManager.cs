using Library.BLL.Dtos.BookDtos;
using Library.BLL.Services.Contracts;
using LibraryDAL.Repositories.Contracts;

namespace Library.BLL.Services
{
    public class BookManager : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookManager(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<BookDto> GetBook(int? id)
        {
            var book = await _bookRepository.GetByIdAsync(id);

            if (book == null) return new BookDto();

            var bookDto = new BookDto
            {
                Id = book.Id,
                Name = book.Name
            };


            return bookDto;
        }

        public async Task<ICollection<BookDto>> GetBooks()
        {
            var books = await _bookRepository.GetAllAsync();

            var bookDtos = new List<BookDto>();

            foreach(var item in books)
            {
                bookDtos.Add(new BookDto
                {
                    Id = item.Id,
                    Name = item.Name,
                });
            }

            return bookDtos;

        }
    }
}
