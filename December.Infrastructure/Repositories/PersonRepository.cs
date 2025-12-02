using December.Domain.Entities;
using December.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace December.Infrastructure.Repositories
{
    /// <summary>
    /// How do I make this class work?
    /// 1) Inherit Interface
    /// 2) Create constructor with DatabaseContext
    /// 3) Implement all methods in the interface
    /// 4) Remember to register the repository in the Dependency Injection 
    ///    container in Program.cs
    /// </summary>
    public class PersonRepository : IPersonRepository
    {
        public DatabaseContext context;
        public PersonRepository(DatabaseContext c) { context = c; }
        public async Task<List<Person>> GetAll()
        {
            // vælg database.table.Where()
            // vælg database.table.Max()
            var t = await context.Persons.ToListAsync();
            return t;
        }
    }
}
