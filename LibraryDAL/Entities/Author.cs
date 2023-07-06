using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL.Entities
{
    public class Author : TimeStample
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public ICollection<BookAuthors> BookAuthors { get; set; }
    }
}
