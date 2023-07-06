using LibraryDAL.DataContext;
using LibraryDAL.Entities;
using LibraryDAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace LibraryDAL.Repositories
{
    public class AuthorRepository : EfCoreRepository<Author>, IAuthorRepository
    {
        private readonly AppDbContext _dbContext;

        public AuthorRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override async Task<ICollection<Author>> GetAllAsync()
        {
            var result = await _dbContext.Authors.ToListAsync();

            return result;
        }
    }
}
