﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoWebApi.Core.Models;
using TodoWebApi.Services;

namespace TodoWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {

        private readonly ITodoService todoService;

        public TodoController(ITodoService todoService)
        {
            this.todoService = todoService;
        }

        // POST: api/Todo
        [HttpPost(Name = "Add")]
        public async Task<Todo> Add([FromBody] Todo todo)
        {
            var added = await todoService.Add(todo);
            return added;
        }

        // GET: api/Todo
        [HttpGet(Name = "GetAll")]
        public async Task<IEnumerable<Todo>> GetAll()
        {
            return await todoService.GetAll();
        }

        // GET: api/Todo/5
        [HttpGet("{id}", Name = "GetById")]
        public async Task<ActionResult<Todo>> GetById(int id)
        {
            var todo = await todoService.GetById(id);

            if (todo == null)
            {
                return NotFound("Could not find todo with id " + id);
            }

            return todo;
        }

        // PUT: api/Todos/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Todo>> Update(int id, [FromBody] Todo todo)
        {
            var todoForUpdate = await todoService.GetById(id);

            if (todoForUpdate == null)
            {
                return NotFound("Could not find todo with id " + id);
            }

            await todoService.Update(todoForUpdate, todo);

            var updatedTodo = await todoService.GetById(id);
            return updatedTodo;
        }

        // DELETE: api/Todos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Remove(int id)
        {
            var todo = await todoService.GetById(id);

            if (todo == null)
            {
                return NotFound("Could not find todo with id " + id);
            }

            await todoService.Remove(todo);

            return NoContent();
        }

    }
}
