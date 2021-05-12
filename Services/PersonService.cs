using solutionthree.Models;
using solutionthree.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solutionthree.Services
{
    public class PersonService
    {
        private readonly IRepository _personRepo;
        public PersonService(IRepository personRepo)
        {
           _personRepo = personRepo;
        }
        public IEnumerable<Person> GetData()
        {
            try
            {
                return _personRepo.GetData();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public void Save(Person person)
        {
            try
            {
                _personRepo.Save(person);
            }
            catch (Exception) 
            {
                throw new Exception();
            }
            
        }
    }
}
