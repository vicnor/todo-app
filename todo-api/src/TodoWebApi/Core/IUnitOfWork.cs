using System;
using System.Threading.Tasks;
using TodoWebApi.Core.Repositories;

namespace TodoWebApi.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ITodoRepository Todo { get; }

        Task<int> CommitAsync();
    }
}
