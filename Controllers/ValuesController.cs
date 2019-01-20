using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngelsTeam.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace AngelsTeam.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //private Diagnostics diagnostics;

        public ValuesController()//Diagnostics diagnostics)
        {
            // this.diagnostics = diagnostics;
        }
        // GET api/values



        // GET api/values/5
        [Authorize]
        [HttpGet("User")]
        public string GetUser()
        {
            return "User";
        }

        [Authorize(Roles = "Admin,Subscriber")]
        [HttpGet("Subscriber")]
        public string GetSubscriber()
        {
            return "Subscriber";
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("Admin")]
        public string GetAdmin()
        {
            return "Admin";
        }

        [HttpGet("Unauthorize")]
        public string GetUnauthorize()
        {
            return "Unauthorize";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value) { }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) { }
    }
}