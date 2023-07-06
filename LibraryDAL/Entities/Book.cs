using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL.Entities
{
    public class Book : TimeStample
    {
        public string Name { get; set; }

        public ICollection<BookAuthors> BookAuthors { get; set; }
    }
}
