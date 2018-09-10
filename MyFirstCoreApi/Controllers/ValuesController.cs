using System;
using Microsoft.AspNetCore.Mvc;
using MyFirstCoreApi.Identity.DbContext;
using MyFirstCoreApi.Identity.Managers;

namespace MyFirstCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IIdentityDbContext context;
        private readonly IUserManager manager;

        public ValuesController(IIdentityDbContext context, IUserManager manager)
        {
            this.context = context;
            this.manager = manager;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<object> Get()
        {
            return new 
            {
                Context = this.context.Id.ToString("N"),
                Manager = this.manager.Id.ToString("N"),
                Date = DateTime.UtcNow
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
