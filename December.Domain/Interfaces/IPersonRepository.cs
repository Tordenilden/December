using December.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace December.Domain.Interfaces
{
    /// <summary>
    /// CRUD
    /// </summary>
    public interface IPersonRepository
    {
        // get 
        Task<List<Person>> GetAll();
    }
}
