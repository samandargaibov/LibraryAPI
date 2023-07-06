using LibraryDAL.DataContext;
using LibraryDAL.Entities;
using LibraryDAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL.Repositories
{
    public class BookAuthorsRepository : EfCoreRepository<BookAuthors>, IBookAuthorsRepository
    {
        public BookAuthorsRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
