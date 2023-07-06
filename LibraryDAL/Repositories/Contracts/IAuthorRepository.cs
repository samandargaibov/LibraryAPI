using LibraryDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL.Repositories.Contracts
{
    public interface IAuthorRepository : IRepositoryAsync<Author>
    {
    }
}
