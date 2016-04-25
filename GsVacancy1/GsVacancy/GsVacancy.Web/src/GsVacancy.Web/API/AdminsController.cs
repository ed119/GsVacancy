using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GsVacancy.BLL.Services;
using GsVacancy.BLL.Managers;


using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GsVacancy.Web.API
{
    [Route("api/[controller]")]
    public class AdminsController : Controller
    {
        private readonly IVacancyManager _vacancyManager;
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;

        public AdminsController(ISmsSender smsSender, IEmailSender emailSender, IVacancyManager vacancyManager)
        {
            _smsSender = smsSender;
            _emailSender = emailSender;
            _vacancyManager = vacancyManager;
        }

        // GET: api/values

        [HttpGet]
        //public IEnumerable<Vacancy> Get()
        //{
        //    return new List<Vacancy>
        //               {

        //                   new Vacancy { VacancyId = 1, Position = "Дворник", City = "TulyachyCity"},
        //                   new Vacancy { VacancyId = 1, Position = "Дворник", City = "TulyachyCity" },
        //                   new Vacancy { VacancyId = 1, Position = "Дворник", City = "TulyachyCity" }
        //               };
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
