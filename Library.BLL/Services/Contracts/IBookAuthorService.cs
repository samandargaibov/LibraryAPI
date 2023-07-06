using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Services.Contracts
{
    public interface IBookAuthorService
    {
        Task CreateRelationAsync(int bookId, int authorId);
    }
}
