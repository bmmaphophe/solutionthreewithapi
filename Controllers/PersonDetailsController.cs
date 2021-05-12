using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using solutionthree.Models;
using solutionthree.Services;

namespace solutionthree.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PersonDetailsController : ControllerBase
    {
        private readonly ILogger<PersonDetailsController> _logger;
        private readonly PersonService _personService;

        public PersonDetailsController(PersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IEnumerable<Person> getPersoneData()
        {
            return _personService.GetData();
        }

        [HttpPost]
        public void  savePerson(Person person)
        {
            _personService.Save(person);
        }

    }
}
