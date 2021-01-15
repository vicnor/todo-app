using TodoWebApi.Core.Models;
using TodoWebApi.Core.Repositories;

namespace TodoWebApi.Data.Repositories
{
    public class TodoRepository : Repository<Todo>, ITodoRepository
    {

        public TodoRepository(TodoDbContext context) : base(context)
        {

        }

    }
}
