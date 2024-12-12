namespace ProductManagementAPI.Data;

using Dapper;
using ProductManagementAPI.Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

public class ProductRepository : IProductRepository
{
    private readonly IDbConnection _connection;
    private readonly IDbTransaction _transaction;

    public ProductRepository(IDbConnection connection, IDbTransaction transaction)
    {
        _connection = connection;
        _transaction = transaction;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _connection.QueryAsync<Product>("SELECT * FROM Products", transaction: _transaction);
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        return await _connection.QueryFirstOrDefaultAsync<Product>(
            "SELECT * FROM Products WHERE Id = @Id", new { Id = id }, transaction: _transaction);
    }

    public async Task AddAsync(Product product)
    {
        await _connection.ExecuteAsync(
            "INSERT INTO Products (Name, CategoryId, Price) VALUES (@Name, @CategoryId, @Price)",
            product, transaction: _transaction);
    }

    public async Task UpdateAsync(Product product)
    {
        await _connection.ExecuteAsync(
            "UPDATE Products SET Name = @Name, CategoryId = @CategoryId, Price = @Price WHERE Id = @Id",
            product, transaction: _transaction);
    }

    public async Task DeleteAsync(int id)
    {
        await _connection.ExecuteAsync(
            "DELETE FROM Products WHERE Id = @Id", new { Id = id }, transaction: _transaction);
    }
}
