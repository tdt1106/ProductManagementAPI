namespace ProductManagementAPI.Data;
using System;
using System.Threading.Tasks;

public interface IUnitOfWork : IDisposable
{
    ICategoryRepository CategoryRepository { get; }
    IProductRepository ProductRepository { get; }
    Task CommitAsync();
    Task RollbackAsync();
}
