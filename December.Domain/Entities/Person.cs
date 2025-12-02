using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace December.Domain.Entities
{
    /// <summary>
    /// Create class
    /// setup the database
    /// create DbSet<className>
    /// add-migration InitialCreate     - write it in the console - choose the right project!!
    /// update-database
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Mail { get; set; }
        // Id is PK to a table
        public int Id { get; set; } // kan staves på alle måder + className
        //public int PersonId { get; set; }
        //FK to Movie table
        //public int MovieId { get; set; }
    }
}
