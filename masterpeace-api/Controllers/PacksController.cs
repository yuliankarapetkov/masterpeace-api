using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace masterpeace_api.Controllers
{
    public class Pack
    {
        public string Name { get; set; }
        public int SessionsCount { get; set; }
        public bool IsCompleted { get; set; }
    }

    [Produces("application/json")]
    [Route("api/packs")]
    public class PacksController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Pack> Get()
        {
            return new Pack[] {
                new Pack()
                {
                    Name = "Тревожност",
                    SessionsCount = 30,
                    IsCompleted = false
                },
                new Pack()
                {
                    Name = "Щастие",
                    SessionsCount = 10,
                    IsCompleted = false
                },
                new Pack()
                {
                    Name = "Стрес",
                    SessionsCount = 30,
                    IsCompleted = true
                }
            };
        }
    }
}