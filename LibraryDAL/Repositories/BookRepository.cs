using LibraryDAL.DataContext;
using LibraryDAL.Entities;
using LibraryDAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace LibraryDAL.Repositories
{
    public class BookRepository : EfCoreRepository<Book>, IBookRepository
    {
        private readonly AppDbContext _dbContext;

        public BookRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override async Task<ICollection<Book>> GetAllAsync()
        {
            var result = await _dbContext.Books.ToListAsync();

            return result;
        }
    }
}
