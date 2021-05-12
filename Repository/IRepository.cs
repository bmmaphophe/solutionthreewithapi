using solutionthree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solutionthree.Repository
{
    public interface IRepository
    {
        IEnumerable<Person> GetData();
        void Save(Person eninty);
    }
}
