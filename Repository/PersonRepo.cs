using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solutionthree.Models;
using solutionthree.Models.Database;

namespace solutionthree.Repository
{
    public class PersonRepo : IRepository
    {
        private readonly DatabaseContext _databaseContext;

        public PersonRepo(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public IEnumerable<Person> GetData()
        {
            return _databaseContext.person.ToList<Person>();
        }
        public void Save(Person eninty)
        {
            _databaseContext.person.Add(eninty);
            _databaseContext.SaveChanges();
        }
    }
}
