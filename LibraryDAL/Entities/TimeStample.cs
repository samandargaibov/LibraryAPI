using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL.Entities
{
    public class TimeStample : Entity
    {
        public string? CreatedBy { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string? LastUpdatedBy { get; set; }
        
        public DateTime? LastUpdatedAt { get; set;}
    
    }
}
