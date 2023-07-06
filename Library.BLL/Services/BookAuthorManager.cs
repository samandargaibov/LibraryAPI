using Library.BLL.Services.Contracts;
using LibraryDAL.Entities;
using LibraryDAL.Repositories.Contracts;

namespace Library.BLL.Services
{
    public class BookAuthorManager : IBookAuthorService
    {
        private IBookAuthorsRepository _bookAuthorRepository;

        public BookAuthorManager(IBookAuthorsRepository bookAuthorRepository)
        {
            _bookAuthorRepository = bookAuthorRepository;
        }

        public async Task CreateRelationAsync(int bookId, int authorId)
        {
            var bookAuthor = new BookAuthors
            {
                BookId = bookId,
                AuthorId = authorId
            };

            await _bookAuthorRepository.AddAsync(bookAuthor);
        }
    }
}
