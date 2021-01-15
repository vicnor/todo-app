using TodoWebApi.Core;
using System.Threading.Tasks;
using TodoWebApi.Data.Repositories;
using TodoWebApi.Core.Repositories;

namespace TodoWebApi.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly TodoDbContext context;
        private TodoRepository todoRepository;

        public UnitOfWork(TodoDbContext context)
        {
            this.context = context;
        }

        public ITodoRepository Todo => todoRepository = todoRepository ?? new TodoRepository(context);

        public async Task<int> CommitAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }

    }
}
