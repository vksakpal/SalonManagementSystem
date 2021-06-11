using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Clients : ControllerBase
    {
        [HttpGet]
        public string get()
        {
            return DateTime.Now.ToString();
        }

        [HttpGet("{id}")]
        public void get(int id)
        {

        }

        [HttpPut]
        public void put()
        {

        }

        [HttpPost]
        public void post()
        {

        }

        [HttpDelete]
        public void delete()
        {

        }
    }
}
