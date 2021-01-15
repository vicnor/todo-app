using System.Collections.Generic;
using System.Threading.Tasks;
using TodoWebApi.Core.Models;

namespace TodoWebApi.Services
{
    public interface ITodoService
    {

        Task<IEnumerable<Todo>> GetAll();

        Task<Todo> GetById(int id);

        Task<Todo> Add(Todo entity);

        Task Update(Todo todoForUpdate, Todo todo);

        Task Remove(Todo todo);

    }
}
