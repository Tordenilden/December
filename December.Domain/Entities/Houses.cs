using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace December.Domain.Entities
{
    public class Houses
    {
        public Houses() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public List<Person> Persons { get; set; } = new List<Person>(); // navigation property
    }
}
