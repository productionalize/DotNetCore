// <copyright file="UserController.cs" company="Microsoft">
// Open source
// </copyright>

namespace DotNetCore.Controllers
{
    using Interfaces;
    using Model;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository repository;

        public UserController(IUserRepository repository)
        {
            this.repository = repository;
        }

        // GET api/values
        [HttpGet]
        public Task<IEnumerable<User>> Get() => repository.GetAll();

        // GET api/values/5
        [HttpGet("{id}")]
        public Task<User> Get(string id) => repository.Get(id);

        // POST api/values
        [HttpPost]
        public void Post([FromBody]User user) => repository.Create(user);

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]User user) => repository.Update(id, user);

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(string id) => repository.Delete(id);
    }
}