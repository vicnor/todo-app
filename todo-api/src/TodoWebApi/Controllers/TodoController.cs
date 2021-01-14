using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoWebApi.Core.Models;

namespace TodoWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {

        // GET: api/Todo
        [HttpGet(Name = "GetAll")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Todo/5
        [HttpGet("{id}", Name = "GetById")]
        public async Task<ActionResult<Todo>> GetById(int id)
        {
            return new Todo { Id = 1, Completed = false, CreatedOn = DateTime.Now, Title = "First Todo" };
            
        }

    }
}
