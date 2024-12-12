using ProductManagementAPI.Data;
using System.Data;
using System.Threading.Tasks;

public class UnitOfWork : IUnitOfWork
{
    private readonly IDbConnection _connection;
    private readonly IDbTransaction _transaction;
    private ICategoryRepository _categoryRepository;
    private IProductRepository _productRepository;

    public UnitOfWork(DapperDbContext dbContext)
    {
        _connection = dbContext.CreateConnection();
        _transaction = _connection.BeginTransaction();
    }

    public ICategoryRepository CategoryRepository =>
        _categoryRepository ??= new CategoryRepository(_connection, _transaction);

    public IProductRepository ProductRepository =>
        _productRepository ??= new ProductRepository(_connection, _transaction);

    public async Task CommitAsync()
    {
        try
        {
            _transaction?.Commit();
        }
        finally
        {
            _transaction?.Dispose();
        }
    }

    public async Task RollbackAsync()
    {
        try
        {
            _transaction?.Rollback();
        }
        finally
        {
            _transaction?.Dispose();
        }
    }

    public void Dispose()
    {
        _transaction?.Dispose();
        _connection?.Dispose();
    }
}

